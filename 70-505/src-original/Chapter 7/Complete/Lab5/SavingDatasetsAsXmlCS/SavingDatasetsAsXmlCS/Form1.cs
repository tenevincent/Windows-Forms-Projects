using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SavingDatasetsAsXmlCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FillDataSetButton_Click(object sender, EventArgs e)
        {
            // Fill the Customers and Orders tables.
            CustomersAdapter.Fill(northwindDataset1.Customers);
            OrdersAdapter.Fill(northwindDataset1.Orders);

            // Bind the grid to the Customers table.
            CustomersGrid.DataSource = northwindDataset1.Customers;

        }

        private void SaveXmlDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                northwindDataset1.WriteXml(@"C:\DataSources\Northwind.xml");
                MessageBox.Show("Data saved as Northwind.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SaveXmlSchemaButton_Click(object sender, EventArgs e)
        {
            try
            {
                northwindDataset1.WriteXmlSchema(@"C:\DataSources\Northwind.xsd");
                MessageBox.Show("Schema saved as Northwind.xsd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}