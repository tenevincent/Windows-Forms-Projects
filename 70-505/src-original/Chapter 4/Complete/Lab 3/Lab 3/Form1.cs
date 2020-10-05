using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Click");
        }

       private void label1_DoubleClick(object sender, EventArgs e)
        {
           listBox1.Items.Add("DoubleClick");
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseClick");
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseDoubleClick");
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseDown");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("MouseEnter");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            listBox1.Items.Add("MouseHover");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
           listBox1.Items.Add("MouseLeave");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseMove");
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add("MouseUp");
        }
    }
}