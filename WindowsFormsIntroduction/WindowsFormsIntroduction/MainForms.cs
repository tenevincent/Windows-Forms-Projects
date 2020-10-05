using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsIntroduction.UserForms;

namespace WindowsFormsIntroduction
{




    public partial class MainForms : Form
    {
        public class ControlLstItem
        {
            public string Name { get; set; }
        }



         public List<ControlLstItem> MenuItems { get; set; }
        public MainForms()
        {
            InitializeComponent();
        }

        private void MainForms_Load(object sender, EventArgs e)
        {
            this.MenuItems = new List<ControlLstItem>();
            this.MenuItems.Add(new ControlLstItem() { Name = "Select an menu" });
            this.MenuItems.Add(new ControlLstItem() { Name = "Label and Input" });
            this.MenuItems.Add(new ControlLstItem() { Name = "Labels and Display" });


            this.listBox1.DataSource = this.MenuItems;
            this.listBox1.DisplayMember = nameof(ControlLstItem.Name);

            this.listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleListBoxItemsSelection();

        }

        private void HandleListBoxItemsSelection()
        {
            this.splitContainer1.Panel2.Controls.Clear();
            int index = this.listBox1.SelectedIndex;
            if (index == 1)
                this.splitContainer1.Panel2.Controls.Add(new UserDataForms());
            else if (index == 2)
                this.splitContainer1.Panel2.Controls.Add(new LabelsDisplaysUserControls());
        }
    }
}
