using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataAdapterWizardExampleCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the grid to display the customers table
            dataGridView1.DataSource = northwindDataset1.Customers;

            // Call the Fill method of the DataAdapter to
            // load the customers table with data.
            sqlDataAdapter1.Fill(northwindDataset1.Customers);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Call the Update method of the data adapter
            // to save the changes to the database.
            sqlDataAdapter1.Update(northwindDataset1);

        }

        private void sqlDataAdapter1_FillError(object sender, FillErrorEventArgs e)
        {
            // Display a dialog to respond to the error
            DialogResult response = MessageBox.Show("The following error occurred while Filling the DataSet: " + e.Errors.Message.ToString() + " Continue attempting to fill?", "FillError Encountered", MessageBoxButtons.YesNo);

            // Attempt to continue if user selects Yes
            if (response == DialogResult.Yes)
            {
              e.Continue = true;
            }
            else
            {
                e.Continue = false;
            }
        }

        private void sqlDataAdapter1_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
            // Create a Customer Row and assign it the row being changed
            northwindDataset.CustomersRow CustRow = (northwindDataset.CustomersRow)e.Row;

            // Display a dialog to confirm the update
            DialogResult response = MessageBox.Show("Continue updating " + CustRow.CustomerID.ToString() + "?", "Continue Update?", MessageBoxButtons.YesNo);

            // Cancel the update if user selects No
            if (response == DialogResult.No)
            {
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            // Create a Customer Row and assign it the row being changed
            northwindDataset.CustomersRow CustRow = (northwindDataset.CustomersRow)e.Row;
            MessageBox.Show(CustRow.CustomerID.ToString() + " has been updated");

            // After the row is updated reset the table to reflect the changes
            northwindDataset1.Customers.Clear();
            sqlDataAdapter1.Fill(northwindDataset1.Customers);

        }



    }
}