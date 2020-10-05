using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqToDataSet
{
    public partial class LinqToDataSetForm : Form
    {
        public LinqToDataSetForm()
        {
            InitializeComponent();
        }




NorthwindDataSet northwindDataSet
    = new NorthwindDataSet();
NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter
    = new NorthwindDataSetTableAdapters.CustomersTableAdapter();


private void LinqToDataSetForm_Load(object sender, EventArgs e)
{
    customersTableAdapter.Fill(northwindDataSet.Customers);

    var countriesQuery =
        from cust in northwindDataSet.Customers.AsEnumerable()
        orderby cust.Country
        select cust.Country;


    foreach (var cust in countriesQuery.Distinct())
        countryComboBox.Items.Add(cust.ToString());

    countryComboBox.SelectedIndex = 0;
}


private void getCustomersButton_Click(object sender, EventArgs e)
{
    resultsListBox.Items.Clear();

    var query =
        from customer in
            northwindDataSet.Customers.AsEnumerable()
        where customer.Country == countryComboBox.SelectedItem.ToString()
        select customer;

    foreach (var cust in query)
    {
    resultsListBox.Items.Add(cust.CompanyName);
    }
}

    }
}
