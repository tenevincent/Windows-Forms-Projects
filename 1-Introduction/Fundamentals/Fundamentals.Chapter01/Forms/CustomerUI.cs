using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentals.Chapter01.Forms
{
    public partial class CustomerUI : UserControl
    {
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
           var result = radColorDialog1.ShowDialog();
            

            btnColor.DialogResult = DialogResult.OK;

        }
    }
}
