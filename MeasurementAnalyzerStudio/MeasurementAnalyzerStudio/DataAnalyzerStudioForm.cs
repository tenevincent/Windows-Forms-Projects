using MeasurementAnalyzerStudio.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasurementAnalyzerStudio
{
    public partial class DataAnalyzerStudioForm : Form
    {
        public DataAnalyzerStudioForm()
        {
            InitializeComponent();
            this.Load += (sender, args) =>
            {
                this.panelMain.Controls.Clear();

                var mainUserControl = new MainAnalyzerUserControl();
                mainUserControl.Dock = DockStyle.Fill;
                this.panelMain.Controls.Add(mainUserControl);

            };
        }

    }
}
