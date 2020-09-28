using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsIntroduction.UserForms
{
    public partial class LabelsDisplaysUserControls : UserControl
    {
        public LabelsDisplaysUserControls()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;
            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}
