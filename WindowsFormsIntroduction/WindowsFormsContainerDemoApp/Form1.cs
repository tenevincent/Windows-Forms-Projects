using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContainerDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int page = 3;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Add(new TabPage() { Text = $"Page {++page}" });

            var form = new FormSplitContainer();
            form.ShowDialog();

        }
    }
}
