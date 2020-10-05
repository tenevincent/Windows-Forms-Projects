using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HandlingConnectionErrorsCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void GoodConnectButton_Click(object sender, EventArgs e)
{
    // This is a valid connection string
    String GoodConnection = "Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True;";
    ConnectToDatabase(GoodConnection);
}

private void ConnectToInvalidUserButton_Click(object sender, EventArgs e)
{
    // This connection string has invalid credentials
    String InvalidUserConnection = "Data Source=.\\sqlexpress;Initial Catalog=Northwind;User ID = InvalidUser";
    ConnectToDatabase(InvalidUserConnection);
}

private void ConnectToInvalidDatabaseButton_Click(object sender, EventArgs e)
{
    // This connection string has an invalid/unavailable database 
    String InvalidDatabaseConnection = "Data Source=.\\sqlexpress;Initial Catalog=InvalidDatabase;Integrated Security=True";
    ConnectToDatabase(InvalidDatabaseConnection);
}



private void ConnectToDatabase(string connectionString)
{
    SqlConnection connection = new SqlConnection(connectionString);

    try
    {
        connection.Open();
    }
    catch (SqlException ex)
    {
        string errorMessage = "";
        // Iterate through all errors returned
        // You can check the error numbers to handle specific errors
        foreach (SqlError ConnectionError in ex.Errors)
        {
            errorMessage += ConnectionError.Message + " (error: " + ConnectionError.Number.ToString() + ")" + Environment.NewLine;
            if (ConnectionError.Number == 18452)
            {
                MessageBox.Show("Invalid Login Detected, please provide valid credentials!");
            }
        }
        MessageBox.Show(errorMessage);
    }
    finally
    {
        connection.Close();
    }
}
    }
}