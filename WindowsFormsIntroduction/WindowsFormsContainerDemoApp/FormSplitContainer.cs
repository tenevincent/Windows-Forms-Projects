using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsContainerDemoApp
{
    public partial class FormSplitContainer : Form
    {
        public FormSplitContainer()
        {
            InitializeComponent();

            this.TabManager.HandleCreated += TabManager_HandleCreated;
            this.TabManager.SelectedIndexChanged += TabManager_SelectedIndexChanged;
        }

        private void TabManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the last TabPage is selected then Create a new TabPage
            if (TabManager.SelectedIndex == TabManager.TabPages.Count - 1)
                ; // CreateTabPage();
        }

        private void TabManager_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(this.TabManager.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.TabManager.TabPages[e.Index];
                var tabRect = this.TabManager.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                if (e.Index == this.TabManager.TabCount - 1) // Add button to the last TabPage only
                {
                    var addImage = Resources.close_window_16;
                    e.Graphics.DrawImage(addImage,
                        tabRect.Left + (tabRect.Width - addImage.Width) / 2,
                        tabRect.Top + (tabRect.Height - addImage.Height) / 2);
                }
                else // draw Close button to all other TabPages
                {
                    var closeImage = Resources.close_window_16;
                    e.Graphics.DrawImage(closeImage,
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                    TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                        tabRect, tabPage.ForeColor, TextFormatFlags.Left);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
 


        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {

            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < this.TabManager.TabPages.Count - 1; i++)
            {
                var tabRect = this.TabManager.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = Resources.close_window_16;
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.TabManager.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
