using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {

            timer1.Stop();
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "French";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "English";
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "German";
        }

        private bool isClosing = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (isClosing) { return; }

            isClosing = true;

           //var result = MessageBox.Show("Do you want the exit the app?", "Exit App", MessageBoxButtons.OKCancel);
           // if(result != DialogResult.OK)
           // {
           //     e.Cancel = true;
           // }
            this.Close();
            isClosing = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "The control has been loaded...";
        }

        private void menuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.toolStripStatusLabel1.Text = "x=" + e.X + ",y=" + e.Y;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "x=" + this.Width + ",y=" + this.Height;
        }
    }
}
