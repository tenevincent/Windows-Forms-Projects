using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAppDemo.Views
{
    public partial class MoreControls : UserControl
    {
        public MoreControls()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The link label was clicked...");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The link 02 label was clicked...");
        }

        int counter;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.imageList1.Images[counter];
            counter++;
        }
    }
}
