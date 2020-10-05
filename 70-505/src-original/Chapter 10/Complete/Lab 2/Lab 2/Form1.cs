using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ArrayCounter = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            float MyLines = 0;
            float YPosition = 0;
            int Counter = 0;
            string CurrentLine;
            MyLines = e.MarginBounds.Height /
               this.Font.GetHeight(e.Graphics);
            while (Counter < MyLines && ArrayCounter <= strings.Length - 1)
            {
                CurrentLine = strings[ArrayCounter];
                YPosition = TopMargin + Counter * this.Font.GetHeight(e.Graphics);
                e.Graphics.DrawString(CurrentLine, this.Font, Brushes.Black, LeftMargin,
                   YPosition, new StringFormat());
                Counter++;
                ArrayCounter++;
            }
            if (!(ArrayCounter >= strings.GetLength(0) - 1))
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                printDocument1.Print();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        string s;
        string[] strings;
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult aResult;
            aResult = openFileDialog1.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader aReader = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                s = aReader.ReadToEnd();
                aReader.Close();
                strings = s.Split('\n');
            }
        }
    }
}