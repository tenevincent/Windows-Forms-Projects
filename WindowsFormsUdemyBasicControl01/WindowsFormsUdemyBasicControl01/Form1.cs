using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (null != dateTimePicker1?.Value)
            {
                this.labelStatusBar.Text = dateTimePicker1.Value.ToString();

            }
             
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (null != dateTimePicker1?.Value)
              this.labelStatusBar.Text = dateTimePicker1.Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = this.dateTimePicker2.Value.ToString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.labelStatusBar.Text = this.dateTimePicker2.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = this.dateTimePicker2.Value.ToString();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = this.maskedTextBox1.Text.ToString();
        }
    }
}
