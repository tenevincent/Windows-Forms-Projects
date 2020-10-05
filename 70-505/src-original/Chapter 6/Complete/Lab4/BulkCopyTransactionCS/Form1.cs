using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BulkCopyTransactionCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection SourceConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void BulkCopyButton_Click(object sender, EventArgs e)
        {
            BulkCopyCustomers();
        }

        private void PrepareTableButton_Click(object sender, EventArgs e)
        {
            SqlCommand GetCustomersCommand = new SqlCommand("DELETE FROM CustomerHistory WHERE CustomerID <> 'WHITC'", SourceConnection);
            SourceConnection.Open();
            GetCustomersCommand.ExecuteNonQuery();
            SourceConnection.Close();

        }

    
        private void BulkCopyCustomers()
        {
            SqlCommand GetCustomersCommand = new SqlCommand("SELECT * FROM Customers", SourceConnection);
            
            SourceConnection.Open();
            SqlDataReader reader = GetCustomersCommand.ExecuteReader();

            SqlBulkCopy BulkCopier = new SqlBulkCopy(SourceConnection.ConnectionString, SqlBulkCopyOptions.UseInternalTransaction);
            BulkCopier.BatchSize = 50;

            BulkCopier.DestinationTableName = "CustomerHistory";

            try
            {
                BulkCopier.WriteToServer(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                BulkCopier.Close();
                reader.Close();
                SourceConnection.Close();
            }
        }
    }
}