using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAppDemo.Views
{
    public partial class CheckListBoxView : UserControl
    {
        public CheckListBoxView()
        {
            InitializeComponent();


            this.checkedListBox1.Items.Add("Tene");
            this.checkedListBox1.Items.Add("Vincent");
            this.checkedListBox1.Items.Add("Ashley");
            this.checkedListBox1.Items.Add("Bradley");
            this.checkedListBox1.Items.Add("Donald");
            this.checkedListBox1.Items.Add("Michael");
            this.checkedListBox1.Items.Add("Scoffield");
            this.checkedListBox1.Items.Add("Mariam");


        }
    }
}
