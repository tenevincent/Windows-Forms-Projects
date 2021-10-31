using MediatR;
using Northwind.Ports.In;
using System;
using System.Diagnostics;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
