using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentals.ButtonsApp
{
    public partial class MainFormApp : Form , IApplicationShellView
    {
        public MainFormApp()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Checkbox seleted");
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu seleted");
        }

        private void MainFormApp_Load(object sender, EventArgs e)
        {

        }
    }
}
