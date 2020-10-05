using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;

namespace ParameterizedQueriesCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection NorthwindConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);

        private void ExecuteSqlButton_Click(object sender, EventArgs e)
        {
            // Create a new Command object
            SqlCommand CustomersByCityCommand = new SqlCommand();

            // Set the command properties
            CustomersByCityCommand.Connection = NorthwindConnection;
            CustomersByCityCommand.CommandType = CommandType.Text;
            CustomersByCityCommand.CommandText = "SELECT CustomerID, CompanyName, City " +
                                                "FROM Customers " +
                                                "WHERE City = @City";

            // Create the @City parameter
            SqlParameter CityParameter = new SqlParameter();

            // Set its name and data type
            CityParameter.ParameterName = "@City";
            CityParameter.SqlDbType = SqlDbType.NVarChar;

            // Since the city column in the database allows
            // null values we can set the IsNullable property
            // to allow null values.
            CityParameter.IsNullable = true;

            // Add the parameter to the Commmand object
            CustomersByCityCommand.Parameters.Add(CityParameter);


            // Set the parameters value to the
            // the text in the CityTextBox
            CityParameter.Value = CityTextBox.Text;

            // Create a StringBuilder to store the results of the query
            System.Text.StringBuilder results =new System.Text.StringBuilder();

            // You must open the connection before executing the command
            CustomersByCityCommand.Connection.Open();

            // Assign the results of the SQL statement to a data reader
            SqlDataReader reader = CustomersByCityCommand.ExecuteReader();

            while (reader.Read())
            {
                for (int i=0; i< reader.FieldCount; i++)
                {
                    results.Append(reader[i].ToString() + "\t");
                }
                results.Append(Environment.NewLine);
            }

            // Close the data reader and the connection
            reader.Close();
            CustomersByCityCommand.Connection.Close();

            ResultsTextBox.Text = results.ToString();
        }
    }
}