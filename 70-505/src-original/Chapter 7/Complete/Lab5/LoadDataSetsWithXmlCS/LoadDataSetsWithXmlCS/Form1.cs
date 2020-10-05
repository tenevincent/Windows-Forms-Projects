using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoadDataSetsWithXmlCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            // Create a DataSet to load the schema into
            DataSet northwindDataset = new DataSet();

        private void LoadSchemaButton_Click(object sender, EventArgs e)
        {
            
            
            // Read the schema information (.xsd file) into the dataset.
            northwindDataset.ReadXmlSchema(@"C:\Datasources\Northwind.xsd");

            // Bind the CustomersGrid and OrdersGrid to display the data.
            CustomersGrid.DataSource = northwindDataset.Tables["Customers"];
            OrdersGrid.DataSource = northwindDataset.Tables["Orders"];

        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            // Read the schema xml data into the dataset
            northwindDataset.ReadXml(@"C:\Datasources\Northwind.xml");

        }
    }
}