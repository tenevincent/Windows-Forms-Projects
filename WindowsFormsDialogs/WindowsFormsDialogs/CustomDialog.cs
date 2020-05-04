using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDialogs
{
    public partial class CustomDialog : Form
    {
        public CustomDialog()
        {
            InitializeComponent();
        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                this.Text = $" the user has entered: {e.KeyCode}";
            }

            this.Text = $" the user has entered: {e.KeyCode}";
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Control.TabIndexChanged event.");

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Control.TabIndexChanged event.");
        }
    }
}
