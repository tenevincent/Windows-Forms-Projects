using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy.FormsWorking.WithControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var src = new AutoCompleteStringCollection();
            src.Add("Green");
            src.Add("Orange");
            src.Add("Blue");
            src.Add("White");
            src.Add("Magenta");
            src.Add("Black");
            src.Add("Brown");
            textBox2.AutoCompleteCustomSource = src;


            //var contextMenu = new ContextMenu();
            //contextMenu.MenuItems.Add("Copy");
            //contextMenu.MenuItems.Add("Delete");
            //contextMenu.MenuItems.Add("Edit");
            //contextMenu.MenuItems.Add("Remove");            
            //this.textBox5.ContextMenu = contextMenu;

            var image = new Bitmap(@"C:\temp\wand.jpg");

            this.contextMenuStrip1.Items.Add("Copy", Resources.delete_32, 
                (senderArgs, evt) => {
                MessageBox.Show("Copy clicked!");
            });

            this.contextMenuStrip1.Items.Add("Edit", Resources.copy_32,
    (senderArgs, evt) => {
        MessageBox.Show("Edit clicked!");
    });

            this.contextMenuStrip1.Items.Add("Delete", Resources.delete_32,
    (senderArgs, evt) => {
        MessageBox.Show("Delete clicked!");
    });

            this.contextMenuStrip1.Items.Add("Remove", Resources.copy_32,
    (senderArgs, evt) => {
        MessageBox.Show("Remove clicked!");
    });


            this.contextMenuStrip1.Click += ContextMenuStrip1_Click;
            this.textBox5.ContextMenuStrip = this.contextMenuStrip1;

        }

        private void ContextMenuStrip1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(@"C:\temp\wand.jpg");
            this.pictureBox1.Image = bitmap;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.btnLoadImage.BackColor = Color.FromArgb(100, 255, 0, 0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = textBox2.Text;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPressEvent(e);
        }

        private static void HandleKeyPressEvent(KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back || e.KeyChar == (int)Keys.Delete)
            {
                return;
            }


            if (e.KeyChar < '0' || e.KeyChar > '9' || e.KeyChar == (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
           bool isSuccess = int.TryParse(textBox5.Text, out int result);
            if (!isSuccess)
            {
                errorProvider1.SetError(textBox5, "The value cannot be empty");
                e.Cancel = true; //Doesn’t allow the textbox to lose focus.
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }
        }
    }
}
