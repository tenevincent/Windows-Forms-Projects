using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.ContainerDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            addImage();
 
       }

        public void addImage()
        {
            // Be sure that you use an appropriate escape sequence (such as the
            // @) when specifying the location of the file.  
            imageList1.Images.Add(WindowsForms.ContainerDemoApp.Resources.check_32);
             imageList1.Images.Add(WindowsForms.ContainerDemoApp.Resources.edit_32);
             imageList1.Images.Add(WindowsForms.ContainerDemoApp.Resources.trash_32);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        // Save the current scale value
        // ScaleControl() is called during the Form's constructor
        private SizeF scale = new SizeF(4.0f, 4.0f);
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            scale = new SizeF(scale.Width * factor.Width, scale.Height * factor.Height);
            base.ScaleControl(factor, specified);
        }

        // Recursively search for SplitContainer controls
        private void Fix(Control c)
        {
            foreach (Control child in c.Controls)
            {
                if (child is SplitContainer)
                {
                    SplitContainer sp = (SplitContainer)child;
                    Fix(sp);
                    Fix(sp.Panel1);
                    Fix(sp.Panel2);
 
                }
                else
                {
                    Fix(child);
                }
            }
        }

        private void Fix(SplitContainer sp)
        {
            // Scale factor depends on orientation
            float sc = (sp.Orientation == Orientation.Vertical) ? scale.Width : scale.Height;
            if (sp.FixedPanel == FixedPanel.Panel1)
            {
                sp.SplitterDistance = (int)Math.Round((float)sp.SplitterDistance * sc);
            }
            else if (sp.FixedPanel == FixedPanel.Panel2)
            {
                int cs = (sp.Orientation == Orientation.Vertical) ? sp.Panel2.ClientSize.Width : sp.Panel2.ClientSize.Height;
                int newcs = (int)((float)cs * sc);
                sp.SplitterDistance -= (newcs - cs);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Fix(this);
        }
    }
}
