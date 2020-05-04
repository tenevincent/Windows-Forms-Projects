using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUdemyBasicControl01
{
    public partial class EmployeeUserView : UserControl
    {
        public EmployeeUserView()
        {
            InitializeComponent();
        }

        private void EmployeeUserView_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image  =WindowsFormsUdemyBasicControl01.Properties.Resources.wand;

            string[] names = { "deccan", "deccansoft", "deccan chronical", "testing", "demo" };
            AutoCompleteStringCollection sc = new AutoCompleteStringCollection();
            foreach (string name in names)
                sc.Add(name);


            textAutoComplete.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            textAutoComplete.AutoCompleteCustomSource = sc;
            textAutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          var process=   System.Diagnostics.Process.Start(@"C:\Users\User\Downloads\Updated competency exams and certifications for 2020.pdf");
            process.WaitForExit();

            MessageBox.Show("process: " +      process.ExitCode);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
