using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsBook.Chapter3
{
    public partial class MainForm : Form
    {
        // Declare the PrintDocument object.
        private System.Drawing.Printing.PrintDocument docToPrint =
            new System.Drawing.Printing.PrintDocument();


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF" +
            "|All files (*.*)|*.*";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = true;
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFiles = "";
                foreach (string file in myDialog.FileNames)
                {
                    selectedFiles += file + "\n";
                }
                richTextBox1.Text = "You chose: " + selectedFiles;
            }
        }

        private void btnSaveDialog_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    var bytesContent = Encoding.UTF8.GetBytes(richTextBox1.Text);

                    stream.Write(bytesContent, 0, bytesContent.Length);
                    stream.Close();
                }
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (radColorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = radColorDialog1.SelectedColor;
                HslColor hslColor = radColorDialog1.SelectedHslColor;

                richTextBox1.ForeColor = color;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void btnPageSetupDialog_Click(object sender, EventArgs e)
        {

            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            pageSetupDialog1.PageSettings =
                new System.Drawing.Printing.PageSettings();

            // Initialize dialog's PrinterSettings property to hold user
            // set printer settings.
            pageSetupDialog1.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();

            //Do not show the network in the printer dialog.
            pageSetupDialog1.ShowNetwork = false;

            //Show the dialog storing the result.
            DialogResult result = pageSetupDialog1.ShowDialog();

            // If the result is OK, display selected settings in
            // ListBox1. These values can be used when printing the
            // document.
            if (result == DialogResult.OK)
            {
                object[] results = new object[]{
            pageSetupDialog1.PageSettings.Margins,
            pageSetupDialog1.PageSettings.PaperSize,
            pageSetupDialog1.PageSettings.Landscape,
            pageSetupDialog1.PrinterSettings.PrinterName,
            pageSetupDialog1.PrinterSettings.PrintRange};
                listBox1.Items.AddRange(results);
            }
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {

            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = true;

            // Show the help button.
            printDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }
    }
}


