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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (!(toolStripComboBox1.Text == ""))
            {
                webBrowser1.Navigate(toolStripComboBox1.Text);
                toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
                if (toolStripComboBox1.Items.Count == 11)
                {
                    toolStripComboBox1.Items.RemoveAt(0);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"http://search.msn.com/results.aspx?q=" + 
     toolStripTextBox1.Text);

        }
    }
}