using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus_Tools_And_Status_ToolStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user has clicked the menu Edit");
        }

        private void toolbarItemEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user has clicked the menu EdittoolbarItemEdit_Click");
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The user has clicked menuItemSaveAs_Click");
        }
    }
}
