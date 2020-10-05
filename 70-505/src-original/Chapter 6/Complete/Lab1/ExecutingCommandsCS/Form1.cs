using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExecutingCommandsCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection NorthWindConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");

        private void ExecuteSqlButton_Click(object sender, EventArgs e)
        {
            //Create a StringBuilder to store the results of the query
            System.Text.StringBuilder results = new System.Text.StringBuilder();
     
            // Create an instance of the Command object
            SqlCommand ExecuteSqlCommand = new SqlCommand();

            // Set the command's connection to the Northwind database
            ExecuteSqlCommand.Connection = NorthWindConnection;

            // Executing SQL statements uses CommandType = Text
            ExecuteSqlCommand.CommandType = CommandType.Text;

            // The CommandText is set to the SQL statement we want to run
            // Comment out the next line and uncomment the line below it to return multiple result sets
            ExecuteSqlCommand.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            // ExecuteSqlCommand.CommandText = "SELECT CustomerID, CompanyName FROM Customers; SELECT ProductName, UnitsInStock FROM Products";

            // You must open the connection before executing the command
            ExecuteSqlCommand.Connection.Open();

            // Assign the results of the SQL statement to a data reader
            SqlDataReader reader = ExecuteSqlCommand.ExecuteReader();


            bool MoreResults = false;

            do
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                MoreResults = reader.NextResult();
            } while (MoreResults);
                
            // Close the data reader and the connection
            reader.Close();
            ExecuteSqlCommand.Connection.Close();

            ResultsTextBox.Text = results.ToString();
        }

        private void ExecuteSprocButton_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();

            SqlCommand ExecuteSprocCommand = new SqlCommand();

            ExecuteSprocCommand.Connection = NorthWindConnection;
            ExecuteSprocCommand.CommandType = CommandType.StoredProcedure;
            ExecuteSprocCommand.CommandText = "Ten Most Expensive Products";

            ExecuteSprocCommand.Connection.Open();
            SqlDataReader reader = ExecuteSprocCommand.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i<reader.FieldCount;i++)
                {
                    results.Append(reader[i].ToString() + "\t");
                }
                results.Append(Environment.NewLine);
            }
            reader.Close();
            ExecuteSprocCommand.Connection.Close();

            ResultsTextBox.Text = results.ToString();

        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            SqlCommand CreateTableCommand = new SqlCommand();

            CreateTableCommand.Connection = NorthWindConnection;
            CreateTableCommand.CommandType = CommandType.Text;
            CreateTableCommand.CommandText = "CREATE TABLE SalesPersons (" +
            "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
            "[FirstName] [nvarchar](50)  NULL, " +
            "[LastName] [nvarchar](50)  NULL)";

            CreateTableCommand.Connection.Open();
            CreateTableCommand.ExecuteNonQuery();
            CreateTableCommand.Connection.Close();

        }

        private void ExecuteXMLButton_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();

            SqlCommand ExecuteXMLCommand = new SqlCommand();
            ExecuteXMLCommand.Connection = NorthWindConnection;
            ExecuteXMLCommand.CommandType = CommandType.Text;

            // Add the For XML Auto clause to return the data as well formed XML
            ExecuteXMLCommand.CommandText = "SELECT CustomerID FROM Customers For XML Auto";

            ExecuteXMLCommand.Connection.Open();
            System.Xml.XmlReader reader = ExecuteXMLCommand.ExecuteXmlReader();

            while (reader.Read())
            {
                results.Append(reader["CustomerID"].ToString());
                results.Append(Environment.NewLine);
            }
                         

            reader.Close();

            reader.Close();
            ExecuteXMLCommand.Connection.Close();
            ResultsTextBox.Text = results.ToString();
        }

        private void ExecuteScalarButton_Click(object sender, EventArgs e)
        {
            SqlCommand ExecuteScalarCommand = new SqlCommand();
            ExecuteScalarCommand.Connection = NorthWindConnection;
            ExecuteScalarCommand.CommandType = CommandType.Text;
            ExecuteScalarCommand.CommandText = "SELECT Count(*) FROM Customers";

            ExecuteScalarCommand.Connection.Open();
            int CustomerCount = (int)ExecuteScalarCommand.ExecuteScalar();
            MessageBox.Show("There are " + CustomerCount.ToString() + " customers");
            ExecuteScalarCommand.Connection.Close();
        }
    }
}