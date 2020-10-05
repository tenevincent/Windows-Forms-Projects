using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccessingRecordsetsCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new DataTable to hold our data
            DataTable CustomersTable = new DataTable("Customers");

            // Create a new DataAdapter to fill the DataTable
            System.Data.OleDb.OleDbDataAdapter Adapter = new System.Data.OleDb.OleDbDataAdapter();


            // Fill the Customers DataTable with the
            // ADO RecordSet.
            Adapter.Fill(CustomersTable, GetRecordSet());


            // Display the Customers table in the DataGridView.
            dataGridView1.DataSource = CustomersTable;
        }

private ADODB.Recordset GetRecordSet()
{ 
    // Set to a valid OleDb connection string to the 
    // Northwind database.
    String NorthwindOleDbConnection = "Provider=SQLOLEDB;Data Source=.\\sqlexpress;Integrated Security=SSPI;Initial Catalog=Northwind";

    // Create the New RecordSet
    ADODB.Recordset rs = new ADODB.Recordset();
    rs.Open("SELECT * FROM Customers", NorthwindOleDbConnection, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 0);
    return rs;
}

    }
}