using System.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clears the Treeview control
            treeView1.Nodes.Clear();
            // Creates a new XmlReader and reads the XML file found in the open file 
            // dialog box.
            XmlReader aReader;
            openFileDialog1.ShowDialog();
            aReader = XmlReader.Create(openFileDialog1.FileName);
            TreeNode aNode = new TreeNode();
            TreeNode bNode;
            TreeNode parentNode = new TreeNode();
            // Loops through the nodes of the XML file
            while (aReader.Read())
            {
                switch (aReader.NodeType)
                {
                    // If an element is found, it creates a new node, reads the 
                    // attributes, and Adds the name of the element and the attributes
                    // as a new node to the Treeview
                    case XmlNodeType.Element:
                        aNode = new TreeNode(aReader.Name);
                        if (aReader.AttributeCount > 0)
                        {
                            aReader.MoveToFirstAttribute();
                            aNode.Text += " " + aReader.Name + "=" + aReader.Value;
                            for (int i = 1; i < aReader.AttributeCount; i++)
                            {
                                aReader.MoveToNextAttribute();
                                aNode.Text += " " + aReader.Name + "=" + aReader.Value;
                            }
                        }
                        if (parentNode.Text == "")
                            treeView1.Nodes.Add(aNode);
                        else
                            parentNode.Nodes.Add(aNode);
                        parentNode = aNode;
                        // When an EndElement is encountered, the parent element is set 
                        // one level up.
                        break;
                    case XmlNodeType.EndElement:
                        parentNode = parentNode.Parent;
                        break;
                    // When a Text node is encounterd, a new node is made as a child
                    // node containing the text is created
                    case XmlNodeType.Text:
                        bNode = new TreeNode(aReader.Value);
                        aNode.Nodes.Add(bNode);
                        break;
                }
            }

        }
    }
}