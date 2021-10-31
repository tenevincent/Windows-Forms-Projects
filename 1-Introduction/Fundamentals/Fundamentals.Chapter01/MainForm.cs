using Fundamentals.Chapter01.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Fundamentals.Chapter01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.statusBarLabel.Text =  textBox1.Text +  "...";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = textBox1.Text + "\n"
                         + textBox2.Text + "\n" 
                         + dateTimePicker1.Value.ToString();
            MessageBox.Show(result);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.statusBarLabel.Text = dateTimePicker1.Value + "...";
        }

        private void rabBtnAdd_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("The button has been selected!");
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
             RadMessageBox.Show("The button has been selected!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.rabBtnAdd.ButtonElement.ToolTipText = "I am a button";
            this.radSplitButton1.DropDownButtonElement.ToolTipText = "I am a toggle button";
     


            comboBoxMenu.Items.Add("Item 1");
            comboBoxMenu.Items.Add("Item 2");
            comboBoxMenu.Items.Add("Item 3");
            comboBoxMenu.Items.Add("Item 4");
            comboBoxMenu.Items.Add("Item 5");

            // radMultiColumnComboBox1.
            RadMenuItem item = new RadMenuItem("Lemon");
            radDropDownButton1.Items.Add(item);
            item = new RadMenuItem("Orange");
         
            radDropDownButton1.Items.Add(item);
            item = new RadMenuItem("Mango");
            radDropDownButton1.Items.Add(item);
            item = new RadMenuItem("Orange");
            radDropDownButton1.Items.Add(item);
            item = new RadMenuItem("Banane");
            radDropDownButton1.Items.Add(item);
            
            item.Click += (sender2, args2) =>
             {
                 RadMessageBox.Show("The checkbox has changed!");

             }
            ;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            RadMessageBox.Show("The checkbox has changed!");

        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadMessageBox.Show(comboBoxMenu.SelectedItem?.ToString());

        }

        private void radRepeatButton1_Click(object sender, EventArgs e)
        {
            this.radProgressBar1.Value1 += 1;
            this.radProgressBar1.Value2 += 1;
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            var form = new DeliverForm();
            form.Owner = this;
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            form.Owner = this;
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
