using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms.Library;



namespace WorkingWithConrols02
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btnCancel.Click += (sender, args) => { MessageBox.Show("Cancel button clicked!"); };


            this.Load += (sender, args) =>
            {
                this.comboBox1.Items.Clear();
                this.comboBox1.DisplayMember = nameof(Student.CompleteName);

                this.comboBox1.Items.Add(new Student() {Id  = 1, Name =  "vincent 01", FirstName =  "Tene 01"});
                this.comboBox1.Items.Add(new Student() { Id = 1, Name = "vincent 02", FirstName = "Tene 02" });
                this.comboBox1.Items.Add(new Student() { Id = 1, Name = "vincent 03", FirstName = "Tene 03" });
                this.comboBox1.Items.Add(new Student() { Id = 1, Name = "vincent 04", FirstName = "Tene 04" });
                this.comboBox1.Items.Add(new Student() { Id = 1, Name = "vincent 05", FirstName = "Tene 05" });
                this.comboBox1.Items.Add(new Student() { Id = 1, Name = "vincent 05", FirstName = "Tene 05" });


                this.listBox1.Items.Clear();
                this.listBox1.DisplayMember = nameof(Student.CompleteName);

                this.listBox1.Items.Add(new Student() { Id = 1, Name = "vincent 01", FirstName = "Tene 01" });
                this.listBox1.Items.Add(new Student() { Id = 1, Name = "vincent 02", FirstName = "Tene 02" });
                this.listBox1.Items.Add(new Student() { Id = 1, Name = "vincent 03", FirstName = "Tene 03" });
                this.listBox1.Items.Add(new Student() { Id = 1, Name = "vincent 04", FirstName = "Tene 04" });
                this.listBox1.Items.Add(new Student() { Id = 1, Name = "vincent 05", FirstName = "Tene 05" });
                this.listBox1.Items.Add(new Student() { Id = 1, Name = "vincent 05", FirstName = "Tene 05" });



                this.checkedListBox1.Items.Clear();
                this.checkedListBox1.DisplayMember = nameof(Student.CompleteName);

                this.checkedListBox1.Items.Add(new Student() { Id = 1, Name = "vincent 01", FirstName = "Tene 01" });
                this.checkedListBox1.Items.Add(new Student() { Id = 1, Name = "vincent 02", FirstName = "Tene 02" });
                this.checkedListBox1.Items.Add(new Student() { Id = 1, Name = "vincent 03", FirstName = "Tene 03" });
                this.checkedListBox1.Items.Add(new Student() { Id = 1, Name = "vincent 04", FirstName = "Tene 04" });
                this.checkedListBox1.Items.Add(new Student() { Id = 1, Name = "vincent 05", FirstName = "Tene 05" });
                this.checkedListBox1.Items.Add(new Student() { Id = 1, Name = "vincent 05", FirstName = "Tene 05" });


            };
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok button clicked!");
            //this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(textBoxEmail, "");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //string errorMsg;
            //if (!AppUtilsDemo.ValidEmailAddress(textBoxEmail.Text, out errorMsg))
            //{
            //    // Cancel the event and select the text to be corrected by the user.
            //    e.Cancel = true;
            //    textBoxEmail.Select(0, textBoxEmail.Text.Length);

            //    // Set the ErrorProvider error with the text to display. 
            //    this.errorProvider1.SetError(textBoxEmail, errorMsg);
            //}
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = "current state is :" + checkBox1.CheckState.ToString();
        }

        private void btnComboxBoxHandler_Click(object sender, EventArgs e)
        {
            var selectedItem = this.comboBox1.SelectedItem + "\n" +
                               this.comboBox2.SelectedItem + "\n" +
                               this.comboBox3.SelectedItem + "\n";
            
            MessageBox.Show(selectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = this.listBox1.SelectedItems.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = checkedListBox1.CheckedItems.Count.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = this.numericUpDown1.Value.ToString();
        }

        private async void btnProgressBar_Click(object sender, EventArgs e)
        {
         
            for (int ii = 0; ii < 100; ii++)
            {
                this.progressBar1.Value = ii;
               await Task.Delay(500);
            }
        }
    }
}
