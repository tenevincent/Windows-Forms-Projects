using Fundamentals.Chapter01.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentals.Chapter01
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var usercontrol = new CustomerUI();
            usercontrol.Dock = DockStyle.Fill;

            this.AcceptButton = usercontrol.btnColor;
            this.Controls.Add(usercontrol);
        }
    }
}
