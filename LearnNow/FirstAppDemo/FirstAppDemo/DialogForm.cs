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
    public partial class DialogForm : Form
    {

        int counter = 0;
        public DialogForm()
        {
            InitializeComponent();


            this.comboBox1.Items.Add("Tene");
            this.comboBox1.Items.Add("Vincent");
            this.comboBox1.Items.Add("Ashley");
            this.comboBox1.Items.Add("Bradley");
            this.comboBox1.Items.Add("Donald");
            this.comboBox1.Items.Add("Michael");
            this.comboBox1.Items.Add("Scoffield");
            this.comboBox1.Items.Add("Mariam");

            this.listBox1.Items.Add("Tene");
            this.listBox1.Items.Add("Vincent");
            this.listBox1.Items.Add("Ashley");
            this.listBox1.Items.Add("Bradley");
            this.listBox1.Items.Add("Donald");
            this.listBox1.Items.Add("Michael");
            this.listBox1.Items.Add("Scoffield");
            this.listBox1.Items.Add("Mariam");


            this.listBox1.SelectedValueChanged += ListBox1_SelectedValueChanged;
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {

           var items =  this.listBox1.SelectedItems;
            this.Text = items.Count + "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = checkBox1.Checked.ToString();
            counter++;

            this.pictureBox1.Image = imageList1.Images[counter];
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            string selection = comboBox1?.SelectedItem?.ToString();
            this.Text = selection;
        }
    }
}
