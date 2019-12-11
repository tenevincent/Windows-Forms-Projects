using FirstAppDemo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.listBox1.Items.Add("Check List Box");
            this.listBox1.Items.Add("Link label");
        }

        private void btnAddUserName_Click(object sender, EventArgs e)
        {
            var message = "Enter message: " + this.textBoxUserName;
            MessageBox.Show(this, message, "Click Button");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frenchToolStripMenuItem.Checked = true;
        //    englishToolStripMenuItem.Checked = false;
        //}

        //private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    englishToolStripMenuItem.Checked = true;
        //    frenchToolStripMenuItem.Checked = false;            
        //}

        private bool okToClose = false;

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Opacity -= 0.05;
            if(this.Opacity < 0.05)
            {
                okToClose = true;
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!okToClose)
            {
                e.Cancel = true;
                this.timer1.Enabled = true;
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formDlg = new DialogForm();
            formDlg.ShowDialog();

        }

        private void Form1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("The form was clicked!");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            string locationText = $"({e.X}, {e.Y})";
            this.listBox1.Items.Insert(0,locationText);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           
            this.Text = "("+ this.Size.Width + "," + this.Size.Height + ")";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "key: " + e.Button;
            this.listBox1.Items.Add("Mouse Down: " + e.Button);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.listBox1.Items.Add("Preview KeyDown: " + e.KeyCode);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.listBox1.Items.Add("Preview KeyPress: " + e.KeyChar);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.listBox1.Items.Add("KeyUp: " + e.KeyCode);
        }

        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(textBoxUserName.Text);
                errorProvider1.SetError(textBoxUserName, "");
            }
            catch (Exception ex)
            { 
                errorProvider1.SetError(textBoxUserName, "Not an integer value.");
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.labelHelp.Text = "Please enter a text here!";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.labelHelp.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if(listBox1.SelectedIndex < 0) { return; }


            this.splitContainer1.Panel2.Controls.Clear();

            if (listBox1.SelectedIndex == 0)
            {
                var checkListView = new CheckListBoxView();
                checkListView.Dock = DockStyle.Fill;
                this.splitContainer1.Panel2.Controls.Add(checkListView);
            }
            else if (listBox1.SelectedIndex == 1)
            {

                var checkListView = new MoreControls();
                checkListView.Dock = DockStyle.Fill;
                this.splitContainer1.Panel2.Controls.Add(checkListView);
            }
        }
    }
}
    