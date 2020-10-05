using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SqlServerEnumeratorCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetDataSourcesButton_Click(object sender, EventArgs e)
        {
            System.Data.Sql.SqlDataSourceEnumerator instance =
                System.Data.Sql.SqlDataSourceEnumerator.Instance;
            VisibleSqlServers.DataSource = instance.GetDataSources();
        }
    }
}