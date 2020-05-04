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
    public partial class EmailValidationTextBoxView : UserControl
    {
        public EmailValidationTextBoxView()
        {
            InitializeComponent();
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(textBoxEmail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxEmail.Select(0, textBoxEmail.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(textBoxEmail, errorMsg);
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(textBoxEmail, "");
        }


        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKeyPress_TextChanged(object sender, EventArgs e)
        { 


        }

        private void textBoxKeyPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(((int)e.KeyChar).ToString());
            if ((int)e.KeyChar == 8) //for backspace
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9') //If the Char is in range of 48 to 57.
                e.Handled = true; //Don’t display the char in textbox.
        }

        private void textBoxDown_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailValidationTextBoxView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                MessageBox.Show("Control + A is Clicked");
        }
    }
}
