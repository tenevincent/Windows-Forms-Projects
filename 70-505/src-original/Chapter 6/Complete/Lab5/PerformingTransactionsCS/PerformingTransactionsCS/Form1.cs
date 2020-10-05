using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PerformingTransactionsCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection NorthwindConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");


        private void PerformTransactionButton_Click(object sender, EventArgs e)
        {
            PerformTransaction();
        }

        private void DeleteExtraRecords()
        {
            // If you have already ran the application 
            // delete the 2 records to prevent a primary
            // key violation. 
            SqlCommand Command1 = new SqlCommand("DELETE FROM Territories WHERE TerritoryID = 98012; " +
                "DELETE FROM Region WHERE RegionID = 10", NorthwindConnection);
            NorthwindConnection.Open();
            Command1.ExecuteNonQuery();
            NorthwindConnection.Close();
        }
        private void PerformTransaction()
        {
            // Remove the records from this example
            // so it works each time the button is clicked!
            DeleteExtraRecords();

            // Create the transaction
            SqlTransaction transaction;

            // Create 2 commands to execute in the transaction
            SqlCommand Command1 = new SqlCommand("INSERT INTO Region" +
                "(RegionID, RegionDescription)" +
                "VALUES (10,'Northwest')", NorthwindConnection);
            SqlCommand Command2 = new SqlCommand("INSERT INTO Territories" +
                "(TerritoryID, TerritoryDescription, RegionID)" +
                "VALUES (98012, 'Bothell', 10)", NorthwindConnection);


            // Open the connection and begin the transaction
            NorthwindConnection.Open();
            transaction = NorthwindConnection.BeginTransaction();

            // Set the commands to execute within the transaction
            Command1.Transaction = transaction;
            Command2.Transaction = transaction;

            // Execute the commands
            Command1.ExecuteNonQuery();
            Command2.ExecuteNonQuery();

            // After executing the commands display a dialog
            // that allows the user to complete or abort the 
            // transaction.
            DialogResult response = MessageBox.Show("Commands have already been executed." +
                Environment.NewLine + "Proceed with transaction?", "Performing Transaction",
                MessageBoxButtons.YesNo);

            // Process the response and either 
            // Commit or Rollback.
            switch (response)
            {
                case DialogResult.Yes:
                    transaction.Commit();
                    break;
                case DialogResult.No:
                    transaction.Rollback();
                    break;
            }

            NorthwindConnection.Close();
        }


    }
}