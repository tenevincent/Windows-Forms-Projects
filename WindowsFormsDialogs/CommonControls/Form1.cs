using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls
{

    class Student
    {

        public string Name { get; set; }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxContact_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Student> list = new List<Student>();
            list.Add(new Student() { Name = "Tene" });
            list.Add(new Student() { Name = "Kengne" });
            list.Add(new Student() { Name = "Vincent" });
            list.Add(new Student() { Name = "De" });
            list.Add(new Student() { Name = "paul" });

            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Items.AddRange(list.ToArray());

            this.comboBox1.SelectedValueChanged += (send, args) =>
            {
                var item = send as Student;

                MessageBox.Show(item?.Name);
            };

            textBox1.Text = "3";



            // Create the list to use as the custom source. 
            var source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
                            {
                        "January",
                        "February",
                        "March",
                        "April",
                        "May",
                        "June",
                        "July",
                        "August",
                        "September",
                        "October",
                        "November",
                        "December"
                            });


            textBoxLastName.AutoCompleteCustomSource = source;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  System.Diagnostics.Process.Start("http://www.gann.de");

            pictureBox1.WaitOnLoad = true;
            Task.Delay(4000);
            this.pictureBox1.LoadAsync("https://2.bp.blogspot.com/-189l83O8gR4/Wx-I0XgP1YI/AAAAAAAAAjg/cUSh08z_ky8KnDjqurYaw1VJneQbS43uACEwYBhgL/s1600/12121_1.jpg");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.label4.Text = numericUpDown1.Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save the data");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //errorProvider1.SetError(textBox1, "");
            //this.Close();

            //MessageBox.Show("Cancel the action!");

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            bool isSuccess = int.TryParse(textBox1.Text, out int result);
            if (!isSuccess)
            {
                errorProvider1.SetError(textBox1, "The value cannot be empty");
                e.Cancel = true; //Doesn’t allow the textbox to lose focus.
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = "3";
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            checkBox1.Checked ^= true;

            var calnder = new CalenderForm();
            calnder.ShowDialog();



        }
    }
}
