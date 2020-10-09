using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDialogBoxes
{
    public partial class FormsFirstDialogBox : Form
    {
        public FormsFirstDialogBox()
        {
            InitializeComponent();

            this.Age = 43;
            this.FirstName = "Vincent";
            this.LastName = "Tene";
        }

        public string FirstName
        {
            get
            {
                return this.textBoxFirstName.Text;
            }

            set
            { 
                this.textBoxFirstName.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.textBoxLastName.Text;
            }

            set
            {
                this.textBoxLastName.Text = value;
            }
        }
        
        
        public string Address
        {
            get
            {
                return this.textBoxAddress.Text;
            }

            set
            {
                this.textBoxAddress.Text = value;
            }
        }


        public int Age
        {
            get
            {
                return int.Parse(this.textBoxAge.Text);
            }

            set
            {
                this.textBoxAge.Text = value.ToString();
            }
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
