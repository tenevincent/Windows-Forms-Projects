using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\myFile.txt"))
            {
                System.IO.StreamReader myReader = new System.IO.StreamReader(@"C:\myFile.txt");
                System.Windows.Forms.MessageBox.Show(myReader.ReadToEnd());
                myReader.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("File not found");
            }
        }
    }
}