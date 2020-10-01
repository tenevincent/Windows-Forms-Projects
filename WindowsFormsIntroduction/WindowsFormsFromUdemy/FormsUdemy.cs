using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFromUdemy
{
    public partial class FormsUdemy : Form
    {
        public FormsUdemy()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ProcessStartInfo(@"C:\Users\Tene\Downloads\Chapter+1+answers.pdf").StartProcess();
            var process = "https://smartwebapps.de/course/view.php?id=2#section-3";
            new ProcessStartInfo(process).StartProcess();

        }

        private void FormsUdemy_Load(object sender, EventArgs e)
        {
            this.imageList1.Images.Clear();

            this.imageList1.Images.Add(Resources.twitter_256);
            this.imageList1.Images.Add(Resources.user_48);
            this.imageList1.Images.Add(Resources.user_512);
            this.pictureBox1.Image = this.imageList1.Images[2];
            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;



            //this.pictureBox1.Image = new Bitmap(@"C:\Users\Tene\Downloads\twitter-256.png");

            //this.pictureBox1.Load(@"C:\Users\Tene\Downloads\user-48.png");


            var autocomplete = new AutoCompleteStringCollection();
            autocomplete.AddRange(new string[] { "One hundred", "Two hundred", "Three hundred" });
            txtBoxAutoComplete.AutoCompleteCustomSource = autocomplete;
            txtBoxAutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;


            cmbStudent.Items.Clear();

            var students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(1, $"Student {i+1}"));
            }
            cmbStudent.Items.AddRange(students.ToArray());
            this.listBoxItems.Items.AddRange(students.ToArray());

            this.checkedListBox1.Items.AddRange(students.ToArray());


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(((int)e.KeyChar).ToString());
            if ((int)e.KeyChar == 8) //for backspace
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9') //If the Char is in range of 48 to 57.
                e.Handled = true; //Don’t display the char in textbox.
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                MessageBox.Show("Control + A is Clicked");
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBoxValidation_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxValidation.Text == "")
            {
                errorProvider1.SetError(textBoxValidation, "The value cannot be empty");
                e.Cancel = true; //Doesn’t allow the textbox to lose focus.
            }
            else
                errorProvider1.SetError(textBoxValidation, "");
        }

        private void txtBoxAutoComplete_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(((int)e.KeyChar).ToString());
            if ((int)e.KeyChar == 8) //for backspace
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9') //If the Char is in range of 48 to 57.
                e.Handled = true; //Don’t display the char in textbox.
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveContent_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveContent_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Save the content");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.textBoxValidation.Text = "valid";
            MessageBox.Show("Cancel the content");
            this.Close();
        }

        private void FormsUdemy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBoxValidation.Text = "valid";
            e.Cancel = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cmbStudent.SelectedItem.ToString());
        }

        private void btnDateTimePicker_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.dateTimePicker.Value.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMonthCalendar_Click(object sender, EventArgs e)
        {
            var forms = new CalenderForm();

            forms.Owner = this;
            forms.WindowState = FormWindowState.Normal;
            forms.StartPosition = FormStartPosition.CenterParent;
            forms.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selected = "";
            foreach (var item in this.checkedListBox1.CheckedItems)
            {
                selected += item + "\n";
            }
            MessageBox.Show(selected);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.numericUpDown1.Value.ToString());
        }
    }

    class Student //Write outside the Form Class.
    {
        public int Id;
        public string Name;
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
