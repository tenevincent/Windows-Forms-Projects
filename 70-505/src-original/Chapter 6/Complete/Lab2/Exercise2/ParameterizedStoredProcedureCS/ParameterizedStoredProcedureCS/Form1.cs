using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParameterizedStoredProcedureCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection NorthwindConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");
        
        private void ExecuteStoredProcedureButton_Click(object sender, EventArgs e)
        {
            // Create a new Command object
            SqlCommand SalesByCategoryCommand = new SqlCommand();

            // Set the command properties
            SalesByCategoryCommand.Connection = NorthwindConnection;
            SalesByCategoryCommand.CommandType = CommandType.StoredProcedure;
            SalesByCategoryCommand.CommandText = "SalesByCategory";


            // Create the @CategoryName parameter
            SqlParameter CategoryNameParameter = new SqlParameter();

            // Set its name and data type
            CategoryNameParameter.ParameterName = "@CategoryName";
            CategoryNameParameter.SqlDbType = SqlDbType.NVarChar;

            // Create the OrdYear parameter
            SqlParameter OrdYearParameter =new SqlParameter("@OrdYear", SqlDbType.NVarChar);

            // Add the parameters to the Commmand object
            SalesByCategoryCommand.Parameters.Add(CategoryNameParameter);
            SalesByCategoryCommand.Parameters.Add(OrdYearParameter);


            // Set the parameter values to the
            // the text in the CategoryNameTextBox
            // and the OrdYearTextBox

            CategoryNameParameter.Value = CategoryNameTextBox.Text;
            OrdYearParameter.Value = OrdYearTextBox.Text;

            // Create a StringBuilder to store the results of the query
            System.Text.StringBuilder results = new System.Text.StringBuilder();

            // Open the connection before executing the command
            SalesByCategoryCommand.Connection.Open();

            // Assign the results of the SQL statement to a data reader
            SqlDataReader reader = SalesByCategoryCommand.ExecuteReader();

            while (reader.Read())
            {
                for(int i = 0; i< reader.FieldCount; i++)
                {
                results.Append(reader[i].ToString() + "\t");
                }
                results.Append(Environment.NewLine);
            }
            // Close the data reader and the connection
            reader.Close();
            SalesByCategoryCommand.Connection.Close();

            ResultsTextBox.Text = results.ToString();

        }
    }
}