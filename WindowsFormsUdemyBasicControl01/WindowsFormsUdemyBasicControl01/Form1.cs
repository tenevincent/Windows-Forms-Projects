﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUdemyBasicControl01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += (sender, args) =>
             {

                 //string message = "Do you want to close this window?";
                 //string title = "Close Window";
                 //MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                 //DialogResult result = MessageBox.Show(message, title, buttons);
                 //if (result == DialogResult.OK)
                 //{
                 //    // this.Close();
                 //}
                 //else
                 //{
                 //    args.Cancel = true;
                 //}

             };

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}