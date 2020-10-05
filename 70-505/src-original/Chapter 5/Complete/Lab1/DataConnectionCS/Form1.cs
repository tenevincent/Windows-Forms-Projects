using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.OracleClient;

namespace DataConnectionCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare the connection objects for the four data providers
        private SqlConnection ConnectionToSql = new SqlConnection("Data Source=.\\SqlExpress;Initial Catalog=Northwind;Integrated Security=True");
        private OleDbConnection ConnectionToOleDb = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DataSources\\Nwind.mdb");
        private OdbcConnection ConnectionToOdbc = new OdbcConnection("Dsn=MS Access Database;dbq=C:\\DataSources\\Nwind.mdb;defaultdir=C:\\DataSources;driverid=281;fil=MS Access;maxbuffersize=2048;pagetimeout=5;uid=admin");
        private OracleConnection ConnectionToOracle = new OracleConnection("");

        private void OpenSqlServerButton_Click(object sender, EventArgs e)
        {
            ConnectionToSql.Open();
        }

        private void OpenOleDbButton_Click(object sender, EventArgs e)
        {
            ConnectionToOleDb.Open();
        }

        private void OpenOdbcButton_Click(object sender, EventArgs e)
        {
            ConnectionToOdbc.Open();
        }

        private void OpenOracleButton_Click(object sender, EventArgs e)
        {
            ConnectionToOracle.Open();
        }

        private void CloseSqlButton_Click(object sender, EventArgs e)
        {
            ConnectionToSql.Close();
        }

        private void CloseOleDbButton_Click(object sender, EventArgs e)
        {
            ConnectionToOleDb.Close();
        }

        private void CloseOdbcButton_Click(object sender, EventArgs e)
        {
            ConnectionToOdbc.Close();
        }

        private void CloseOracleButton_Click(object sender, EventArgs e)
        {
            ConnectionToOracle.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionToSql.StateChange += new System.Data.StateChangeEventHandler(this.ConnectionToSql_StateChange);
            ConnectionToOleDb.StateChange += new System.Data.StateChangeEventHandler(this.ConnectionToOleDb_StateChange);
            ConnectionToOdbc.StateChange += new System.Data.StateChangeEventHandler(this.ConnectionToOdbc_StateChange);
            ConnectionToOracle.StateChange += new System.Data.StateChangeEventHandler(this.ConnectionToOracle_StateChange);
            ConnectionToSql.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.ConnectionToSql_InfoMessage);
        }

        private void ConnectionToSql_StateChange(object sender, StateChangeEventArgs e)
        {
            SqlConnectionStateLabel.Text = e.CurrentState.ToString();        
        }

        private void ConnectionToOleDb_StateChange(object sender, StateChangeEventArgs e)
        {
            OleDbConnectionStateLabel.Text = e.CurrentState.ToString(); 
        }
        
        private void ConnectionToOdbc_StateChange(object sender, StateChangeEventArgs e)
        {
            OdbcConnectionStateLabel.Text = e.CurrentState.ToString(); 
        }
        
        private void ConnectionToOracle_StateChange(object sender, StateChangeEventArgs e)
        {
            OracleConnectionStateLabel.Text = e.CurrentState.ToString(); 
        }

        private void GetSqlInfoButton_Click(object sender, EventArgs e)
        {
            ConnectionToSql.FireInfoMessageEventOnUserErrors = true;
            ConnectionToSql.ChangeDatabase("Northwind1");

        }

        private void ConnectionToSql_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void GetOleDbInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConnectionToOleDb.ServerVersion.ToString(), "Server Version");
        }

        private void GetOdbcInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConnectionToOdbc.ServerVersion.ToString(), "Server Version");
        }

        private void GetOracleInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConnectionToOracle.ServerVersion.ToString(), "Server Version");
        }


 
        private void RaiseSqlExceptionButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Execute InvalidProcedure", ConnectionToSql);

            try
            {
                ConnectionToSql.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectionToSql.Close();
            }
        }




 
    }
}