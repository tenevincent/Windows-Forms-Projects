using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExtendFormsAppInheritance
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.textBoxUserName.Text.Equals("tene"))
            {
                AppDataLogin.IsUserLogIn = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
