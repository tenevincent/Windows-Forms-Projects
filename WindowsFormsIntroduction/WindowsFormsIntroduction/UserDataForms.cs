using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsIntroduction
{
    public partial class UserDataForms : UserControl
    {
        public UserDataForms()
        {
            InitializeComponent();

            this.Load += (sender, args) =>
            {
                var btnTooltip = new ToolTip();

                btnTooltip.ToolTipTitle = "Save the data";
                btnTooltip.ToolTipIcon = ToolTipIcon.Info;
              btnTooltip.SetToolTip(btnSave,"Save the user data here...");
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A button has been Clicked!");
        }
    }
}
