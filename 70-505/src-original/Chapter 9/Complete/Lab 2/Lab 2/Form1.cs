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
                if (doc.OuterXml == "")
                {
                    MessageBox.Show("Please load the XML file first");
                    return;
                }
                System.Xml.XmlNodeList aList;
                System.Xml.XmlNode aNode;
                System.Xml.XmlElement anElement;
                aList = doc.GetElementsByTagName("book");
                aNode = aList.Item(aList.Count - 1);
                anElement = doc.CreateElement("book");
                anElement.SetAttribute("ISBN", txtISBN.Text);
                anElement.SetAttribute("Title", txtTitle.Text);
                anElement.SetAttribute("Price", txtPrice.Text);
                if (!(listView1.Items.Count == 0))
                {
                    System.Xml.XmlElement bElement;
                    System.Xml.XmlText atext;
                    foreach (ListViewItem j in listView1.Items)
                    {
                        bElement = doc.CreateElement("chapter");
                        bElement.SetAttribute("num", j.SubItems[0].Text);
                        bElement.SetAttribute("name", j.SubItems[1].Text);
                        atext = doc.CreateTextNode(j.SubItems[2].Text);
                        bElement.AppendChild(atext);
                        anElement.AppendChild(bElement);
                    }
                }
                aNode.ParentNode.InsertAfter(anElement, aNode);
                txtChapterName.Text = "";
                txtChapterText.Text = "";
                txtISBN.Text = "";
                txtPrice.Text = "";
                txtTitle.Text = "";
                listView1.Clear();
            }
            else
            {
                MessageBox.Show("Please add all the information");
            }
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            doc.Load(openFileDialog1.FileName);
        }

        private void btnViewXml_Click(object sender, EventArgs e)
        {
            Form2 aForm = new Form2();
            aForm.textBox1.Text = doc.OuterXml;
            aForm.ShowDialog();
        }
                     
    }
}