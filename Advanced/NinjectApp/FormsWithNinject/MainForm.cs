using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI
{
    public partial class MainForm : Form
    {
        private readonly IRepository<Process> productionRepository;
        private readonly ITest test;

        public MainForm(IRepository<Process> productionRepository, ITest test)
        {
            InitializeComponent();
            this.productionRepository = productionRepository;
            this.test = test;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
