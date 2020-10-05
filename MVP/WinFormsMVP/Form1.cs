using FormsModelViewPresenter.Models;
using FormsModelViewPresenter.Presenter;
using FormsModelViewPresenter.Services;
using FormsModelViewPresenter.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsModelViewPresenterDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            var repository = new CustomerXmlRepository(Application.StartupPath);

            var service = new CustomerService(repository);
            var form = new CustomerForm();
            var presenter = new CustomerPresenter(form, service);
             
            form.ShowDialog();

        }
    }
}
