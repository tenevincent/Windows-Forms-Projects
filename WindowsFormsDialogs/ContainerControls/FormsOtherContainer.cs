using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerControls
{
    public partial class FormsOtherContainer : Form
    {
        public FormsOtherContainer()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {



        }

        private void FormsOtherContainer_Load(object sender, EventArgs e)
        {
            var firstNode = new TreeNode("Blazor");
           
            firstNode.Nodes.Add(new TreeNode("Blazor 01"));
            firstNode.Nodes.Add(new TreeNode("Blazor 02"));
            firstNode.Nodes.Add(new TreeNode("Blazor 03"));
            firstNode.Nodes.Add(new TreeNode("Blazor 04"));
            treeView1.Nodes.Add(firstNode);

            var secondNode = new TreeNode("Restful API");
            secondNode.Nodes.Add(new TreeNode("Restful 01"));
            secondNode.Nodes.Add(new TreeNode("Restful 02"));
            secondNode.Nodes.Add(new TreeNode("Restful 03"));

            treeView1.Nodes.Add(secondNode);
        }
    }
}
