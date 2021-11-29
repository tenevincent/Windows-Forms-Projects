namespace ListItemsControlsApp
{
    public partial class MainFormUI : Form
    {
        public MainFormUI()
        {
            InitializeComponent();
        }

        private void MainFormUI_Load(object sender, EventArgs e)
        {
           // string path = @"C:\Users\dss\Desktop\Assignments\Assignments\WinForms Assignments and Documentation\TreeviewWinApp\TreeviewWinApp\Images";
            //Setting images for the Imagelist. Which will be set to rootnodes,childnodes and sibling nodes.   
           
            imageList.Images.Clear();
            imageList.Images.Add(ListItemsControlsApp.Resources.favicon);
            imageList.Images.Add(ListItemsControlsApp.Resources.icon1);
            imageList.Images.Add(ListItemsControlsApp.Resources.colors);
            imageList.Images.Add(ListItemsControlsApp.Resources.DfIcon);
            tvCountries.ImageList = imageList;

            //Create the root node
            TreeNode rootNode = tvCountries.Nodes.Add("USA");
            rootNode.ImageIndex = 0;
            rootNode.Tag = "usa";

            //Create child nodes for the root node
            TreeNode states1 = rootNode.Nodes.Add("New York");
            states1.ImageIndex = 1;        
            rootNode.Tag = "new_york";
          

            TreeNode states2 = rootNode.Nodes.Add("Michigan");
            states2.ImageIndex = 1;
            rootNode.Tag = "michigan";
            TreeNode states3 = rootNode.Nodes.Add("Wisconsin");
            states3.ImageIndex = 1;
            TreeNode states4 = rootNode.Nodes.Add("California");
            states4.ImageIndex = 1;

            //Create sibbling nodes for the child nodes
            TreeNode child = states1.Nodes.Add("Rochester");
            child.ImageIndex = 2;
            child = states1.Nodes.Add("new York");
            child.ImageIndex = 2;
            child = states1.Nodes.Add("Albany");
            child.ImageIndex = 2;

            child = states2.Nodes.Add("Detroit");
            child.ImageIndex = 2;
            child = states2.Nodes.Add("Ann Arbor");
            child.ImageIndex = 2;
            child = states2.Nodes.Add("Lansing");
            child.ImageIndex = 2;

            child = states3.Nodes.Add("Milwaukee");
            child.ImageIndex = 2;
            child = states3.Nodes.Add("Madison");
            child.ImageIndex = 2;
            child = states3.Nodes.Add("La Cross");
            child.ImageIndex = 2;

            child = states4.Nodes.Add("Los Angeles");
            child.ImageIndex = 2;
            child = states4.Nodes.Add("San Fransisco");
            child.ImageIndex = 2;
            child = states4.Nodes.Add("San Diego");
            child.ImageIndex = 2;
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            // List all nodes of TreeView 
            this.lbItems.Items.Clear();
            List<TreeNode> allNodes = new List<TreeNode>();
            allNodes = FindNodeByText(this.tvCountries, "", false);
            foreach (TreeNode tn in allNodes)
            {
                lbItems.Items.Add(tn.Text);
            }
        }

        private List<TreeNode> FindNodeByText(TreeView treeView, string nodeText, bool matchWholeWord)
        {
            // Store the found node 
            List<TreeNode> lstFoundNode = new List<TreeNode>();


            // Travel stack 
            Stack<TreeNode> nodeStack = new Stack<TreeNode>();
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                nodeStack.Push(treeView.Nodes[i]);
            }


            while (nodeStack.Count != 0)
            {
                TreeNode treeNode = nodeStack.Pop();
                if (matchWholeWord)
                {
                    if (treeNode.Text == nodeText)
                    {
                        lstFoundNode.Add(treeNode);
                    }
                }
                else
                {
                    if (treeNode.Text.Contains(nodeText))
                    {
                        lstFoundNode.Add(treeNode);
                    }
                }


                for (int i = 0; i < treeNode.Nodes.Count; i++)
                {
                    nodeStack.Push(treeNode.Nodes[i]);
                }
            }
            return lstFoundNode;
        }


        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = lbItems.SelectedItem.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            txtName.Text = "";
        }


        private void tvCountries_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtName.Text =e.Node.Text;
        }

        private void tvCountries_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            txtName.Text = e.Node.Text;
        }
    }
}