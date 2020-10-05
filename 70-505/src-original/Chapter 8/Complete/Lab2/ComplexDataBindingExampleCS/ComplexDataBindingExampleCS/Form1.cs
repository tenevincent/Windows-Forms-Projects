using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComplexDataBindingExampleCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGridButton_Click(object sender, EventArgs e)
        {
            // Load the products table with data from the database
            productsTableAdapter1.Fill(northwindDataSet1.Products);

            // Create a new BindingSource component
            BindingSource productsBindingSource = new BindingSource(northwindDataSet1, "Products");

            // Bind the grid to the BindingSource component
            ProductsGrid.DataSource = productsBindingSource;

            // Hook the navigator to the BindingSource
            bindingNavigator1.BindingSource = productsBindingSource;


        }
    }
}