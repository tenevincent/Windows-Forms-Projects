using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BulkCopySampleCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection SourceConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\SQL Server 2000 Sample Databases\NORTHWND.MDF"";Integrated Security=True;Connect Timeout=30;User Instance=True");
        private SqlConnection DestinationConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\SQL Server 2000 Sample Databases\NORTHWND.MDF"";Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void CopyCustomersButton_Click(object sender, EventArgs e)
        {
            BulkCopyCustomers();
        }

        private void BulkCopyCustomers()
        {
            SqlCommand GetCustomersCommand = new SqlCommand("SELECT * FROM Customers", SourceConnection);

            SourceConnection.Open();
            SqlDataReader reader = GetCustomersCommand.ExecuteReader();

            SqlBulkCopy BulkCopier = new SqlBulkCopy(DestinationConnection);

            DestinationConnection.Open();
            BulkCopier.DestinationTableName = "CustomerHistory";
            BulkCopier.WriteToServer(reader);

            reader.Close();
            SourceConnection.Close();
            DestinationConnection.Close();

        }

        private void BulkCopyOrders()
        {
            SqlCommand GetOrdersCommand = new SqlCommand("SELECT * FROM Orders", SourceConnection);

            SourceConnection.Open();
            SqlDataReader reader = GetOrdersCommand.ExecuteReader();

            SqlBulkCopy BulkCopier = new SqlBulkCopy(DestinationConnection);

            DestinationConnection.Open();
            BulkCopier.DestinationTableName = "OrderHistory";
            BulkCopier.WriteToServer(reader);

            reader.Close();
            SourceConnection.Close();
            DestinationConnection.Close();

        }

        private void CopyOrdersButton_Click(object sender, EventArgs e)
        {
            BulkCopyOrders();
        }

        private void ExecuteBulkInsertButton_Click(object sender, EventArgs e)
        {
            string BulkInsertStatement = "BULK INSERT CustomerHistory " +
                         "FROM 'C:\\Datasources\\NorthwindCustomers.txt'";

            SqlCommand BulkInsertCommand = new SqlCommand(BulkInsertStatement, SourceConnection);


            try
            {
                SourceConnection.Open();
                BulkInsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SourceConnection.Close();
            }
                
        }

    }
}