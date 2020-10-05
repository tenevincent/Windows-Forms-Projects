using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreatingDataTablesCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Instantiate a new table (global to the form).
        private DataTable CustomersTable = new DataTable("Customers");

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            // Set the DataGridView to display the table
            TableGrid.DataSource = CustomersTable;

            // Define the schema of the table
            // by adding DataColumn objects to
            // the table's Columns collection.
            CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
            CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
            CustomersTable.Columns.Add("City", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Region", Type.GetType("System.String"));
            CustomersTable.Columns.Add("PostalCode", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Fax", Type.GetType("System.String"));

            // Set the CustomerID column as the primary key
            DataColumn[] KeyColumns = new DataColumn[1];
            KeyColumns[0] = CustomersTable.Columns["CustomerID"];
            CustomersTable.PrimaryKey = KeyColumns;


            // Set the CustomerID and CompanyName columns
            // to disallow Null values.
            CustomersTable.Columns["CustomerID"].AllowDBNull = false;
            CustomersTable.Columns["CompanyName"].AllowDBNull = false;

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            // Create a record (DataRow) to add to the table.
            DataRow CustRow = CustomersTable.NewRow();
            Object[] CustRecord =  {"ALFKI", "Alfreds Futterkiste", "Maria Anders", 
                "Sales Representative", "Obere Str. 57", "Berlin", 
                  null, "12209", "Germany", "030-0074321","030-0076545"};
            CustRow.ItemArray = CustRecord;
            CustomersTable.Rows.Add(CustRow);
        }
    }
}