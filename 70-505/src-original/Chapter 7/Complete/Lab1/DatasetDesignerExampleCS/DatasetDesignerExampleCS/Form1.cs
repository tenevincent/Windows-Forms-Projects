using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatasetDesignerExampleCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            // Instantiate a Northwind typed dataset.
            NorthwindDataset NorthwindDataset1 = new NorthwindDataset();

            // Instantiate a CustomersTableAdapter.
            NorthwindDatasetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = new NorthwindDatasetTableAdapters.CustomersTableAdapter();

            // Call the default Fill method to load all customers
            // into the Customers DataTable.
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);

            // Loop through the rows in the Customers table
            // and add the value from the CompanyName column
            // to the ListBox.
            foreach (NorthwindDataset.CustomersRow NWCustomer in NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}