using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InputOutputParametersCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection NorthwindConnection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");

        private void GetFreightCostButton_Click(object sender, EventArgs e)
        {
            // C#
            // Create a new Command object
            SqlCommand GetFreightCost = new SqlCommand();

            // Set the command properties
            GetFreightCost.Connection = NorthwindConnection;
            GetFreightCost.CommandType = CommandType.StoredProcedure;
            GetFreightCost.CommandText = "GetFreightCost";

            // Create the Output parameter to receive the freight cost
            SqlParameter FreightCostParameter = new SqlParameter();
            FreightCostParameter.Direction = ParameterDirection.Output;

            // Set its name and data type
            FreightCostParameter.ParameterName = "@Freight";
            FreightCostParameter.SqlDbType = SqlDbType.Money;

            // Create the OrderID parameter and set its value
            SqlParameter OrderIDParameter =new SqlParameter("@OrderID", SqlDbType.Int);
            OrderIDParameter.Value = OrderIDTextBox.Text;

            // Add both parameters to the Commmand object
            GetFreightCost.Parameters.Add(FreightCostParameter);
            GetFreightCost.Parameters.Add(OrderIDParameter);

            // open the connection before executing the command
            GetFreightCost.Connection.Open();

            // Execute the sproc; because we are using parameters
            // to access the data we call ExecuteNonQuery instead of
            // ExecuteReader.
            GetFreightCost.ExecuteNonQuery();
            GetFreightCost.Connection.Close();
            FreightCostTextBox.Text = FreightCostParameter.Value.ToString();

        }

        private void GetContactNameButton_Click(object sender, EventArgs e)
        {
            // C#
            // Create a new Command object
            SqlCommand GetContactNameCommand = new SqlCommand();

            // Set the command properties
            GetContactNameCommand.Connection = NorthwindConnection;
            GetContactNameCommand.CommandType = CommandType.StoredProcedure;
            GetContactNameCommand.CommandText = "GetContactName";

            // Create the InputOutput parameter to send and receive data
            SqlParameter NameParameter = new SqlParameter();
            NameParameter.Direction = ParameterDirection.InputOutput;

            // Set its name, data type, and value
            NameParameter.ParameterName = "@Name";
            NameParameter.SqlDbType = SqlDbType.NVarChar;
            NameParameter.Value = CompanyNameTextBox.Text;

            // Add the parameters to the Commmand object
            GetContactNameCommand.Parameters.Add(NameParameter);

            // Open the connection before executing the command
            GetContactNameCommand.Connection.Open();

            // Execute the sproc
            GetContactNameCommand.ExecuteNonQuery();
            GetContactNameCommand.Connection.Close();
            ContactNameTextBox.Text = NameParameter.Value.ToString();

        }
    }
}