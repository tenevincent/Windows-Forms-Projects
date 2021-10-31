using System;
using System.Windows.Forms;

namespace LinkLabels
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lnkBuy.Links.Add(10, 10, "http://www.amazon.com");
            lnkBuy.Links.Add(24, 16, "http://www.bn.com");
            lnkWebSite.Links.Add(4, 17, "http://www.prosetech.com");
        }

        private void linkWebSite_Clicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;
            System.Diagnostics.Process.Start((string)e.Link.LinkData);
        }
    }
}