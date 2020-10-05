using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        int chaptercounter = 1;
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddChapter_Click(object sender, EventArgs e)
        {
            if (!(txtChapterName.Text == ""))
            {
                ListViewItem anItem = new ListViewItem(new String[] {chaptercounter.ToString(), txtChapterName.Text, txtChapterText.Text });
                listView1.Items.Add(anItem);
                chaptercounter++;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!(txtISBN.Text == "") & !(txtTitle.Text == "") & !(txtPrice.Text == ""))
            {
            }
            else
            {
                MessageBox.Show("Please add all the information");
            }
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
                     
    }
}