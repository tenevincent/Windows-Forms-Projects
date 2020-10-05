using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace LinqToSql
{
    public partial class LinqToSqlForm : Form
    {
        public LinqToSqlForm()
        {
            InitializeComponent();
        }



DataContext db =
 new DataContext("Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");

Table<Customer> Customers;

private void LinqToSqlForm_Load(object sender, EventArgs e)
{
    // Get a typed table to run queries.
  Customers = db.GetTable<Customer>();

    // Query for a list of Countries.
    var countriesQuery =
        from cust in Customers
        select cust.Country;


    foreach (var cust in countriesQuery.Distinct())
        countryComboBox.Items.Add(cust.ToString());

    countryComboBox.SelectedIndex = 0;
}

        [Table(Name = "Customers")]
        public class Customer
        {

            private string _CustomerID;

            [Column(IsPrimaryKey = true, Storage = "_CustomerID")]
            public string CustomerID
            {
                get
                {
                    return this._CustomerID;
                }
                set
                {
                    this._CustomerID = value;
                }

            }

            private string _CompanyName;

            [Column(Storage = "_CompanyName")]
            public string CompanyName
            {
                get
                {
                    return this._CompanyName;
                }
                set
                {
                    this._CompanyName = value;
                }
            }
            private string _Country;

            [Column(Storage = "_Country")]
            public string Country
            {
                get
                {
                    return this._Country;
                }
                set
                {
                    this._Country = value;
                }
            }

    }

private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
{
    var query =
        from cust in Customers
        where cust.Country == countryComboBox.SelectedItem.ToString()
        select cust;

    resultsGrid.DataSource = query;
}

private void saveButton_Click(object sender, EventArgs e)
{
    try
    {
        db.SubmitChanges();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}



        }



}
