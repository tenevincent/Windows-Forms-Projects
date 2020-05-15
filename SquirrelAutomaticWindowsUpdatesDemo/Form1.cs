using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            this.Load += Form1_Load;

		}

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (var mgr = new UpdateManager(@"C:\Dev\Projects\Release"))
            {
                await mgr.UpdateApp();
            }
        }

        protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

            Assembly assembly = Assembly.GetExecutingAssembly();

			locationTextBox.Text = assembly.Location;
            versionTextBox.Text = assembly.GetName().Version.ToString(3);
		}
	}
}
