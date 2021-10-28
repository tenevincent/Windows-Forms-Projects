using MediatR;
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
        private readonly IMediator mediator;

        public MainForm(IRepository<Process> productionRepository, ITest test, IMediator mediator)
        {
            InitializeComponent();
            this.productionRepository = productionRepository;
            this.test = test;
            this.mediator = mediator;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
