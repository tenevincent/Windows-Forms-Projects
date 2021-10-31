using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DynamicUI
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void cmd_Click(object sender, EventArgs e)
		{
			Control ctrl = (Control)sender;
			Assembly assembly = Assembly.GetAssembly(typeof(Menu));
			Form frm = (Form)assembly.CreateInstance("DynamicUI." + ctrl.Text);
			frm.ShowDialog();
		}

		private void Menu_Load(object sender, EventArgs e)
		{

		}
	}
}