using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsFromUdemy
{
    public partial class CalenderForm : Form
    {
        public CalenderForm()
        {
            InitializeComponent();
        }

        private void CalenderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
