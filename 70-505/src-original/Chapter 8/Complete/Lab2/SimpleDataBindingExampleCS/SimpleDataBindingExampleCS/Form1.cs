using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDataBindingExampleCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingSource productsBindingSource;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the products table with data
            productsTableAdapter1.Fill(northwindDataSet1.Products);

            // Create a BindingSource to the Products table
             productsBindingSource = new BindingSource(northwindDataSet1, "Products");

            // Configure the bindings of the TextBoxes
            ProductIDTextBox.DataBindings.Add("Text", productsBindingSource, "ProductID");
            ProductNameTextBox.DataBindings.Add("Text", productsBindingSource, "ProductName");

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }
    }
}