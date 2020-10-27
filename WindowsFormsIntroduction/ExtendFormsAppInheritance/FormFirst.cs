
using MaterialThemeCore;
using MaterialThemeCore.MaterialControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendFormsAppInheritance
{
    public partial class FormFirst :  MaterialThemeForm
    {
        public FormFirst()
        {
            InitializeComponent();

            var materialTheme = MaterialTheme.Instance;
            materialTheme.AddFormToManage(this);
            materialTheme.Theme = MaterialTheme.Themes.LIGHT;
            materialTheme.MaterialColor = new MaterialColor(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

          
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var form = new FormSecondForms();
            form.Show();

        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void FormFirst_Load(object sender, EventArgs e)
        {
            this.loginMenuItem.Click += MenuItemLogin_Click;
            OnHandleMenusVisibility();
        }

        private void OnHandleMenusVisibility()
        {
            //if (!AppDataLogin.IsUserLogIn)
            //{
            //    this.panel1.Visible = false;
            //    this.menuStripLogin.Visible = true;
            //    this.menuStripMain.Visible = false;
            //    this.toolStripMain.Visible = false;
            //}
            //else
            //{
            //    this.panel1.Visible = true;
            //    this.menuStripLogin.Visible = false;
            //    this.menuStripMain.Visible = true;
            //    this.toolStripMain.Visible = true;
            //}
        }

        private void MenuItemLogin_Click(object sender, EventArgs e)
        {
            var form = new LoginPage();
           var result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.panel1.Visible = true;
            }

            OnHandleMenusVisibility();
        }
    }
}
