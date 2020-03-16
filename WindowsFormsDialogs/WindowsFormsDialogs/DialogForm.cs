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

namespace WindowsFormsDialogs
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }


            this.labelMessage.Text = "File Content at path: " + filePath;
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var content = "This is a content to be written!";
                    myStream.Write(Encoding.ASCII.GetBytes(content),0,content.Length);
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {

            var fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;
            fontDialog1.Font = labelMessage.Font;
            fontDialog1.Color = labelMessage.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                labelMessage.Font = fontDialog1.Font;
                labelMessage.ForeColor = fontDialog1.Color;
            }
        }


        private bool fileOpened = false;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog;
        private string openFileName, folderName;
        // Declare the PrintDocument object.
        private System.Drawing.Printing.PrintDocument docToPrint =
            new System.Drawing.Printing.PrintDocument();



        private void btnPrintDialog_Click(object sender, EventArgs e)
        {

            var printDialog = new PrintDialog();
            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog.AllowSomePages = true;

            // Show the help button.
            printDialog.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            printDialog.Document = docToPrint;

            DialogResult result = printDialog.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            colorDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog.Color;
        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            this.openFileDialog = new  OpenFileDialog();
            this.folderBrowserDialog1 = new  FolderBrowserDialog();


            // If a file is not opened, then set the initial directory to the
            // FolderBrowserDialog.SelectedPath value.
            if (!fileOpened)
            {
                openFileDialog.InitialDirectory = folderBrowserDialog1.SelectedPath;
                openFileDialog.FileName = null;
            }


            // Display the openFile dialog.
            DialogResult result = openFileDialog.ShowDialog();
            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                openFileName = openFileDialog.FileName;
                try
                {
                    // Output the requested file in richTextBox1.
                    Stream stream = openFileDialog.OpenFile();
                    richTextBox1.LoadFile(stream, RichTextBoxStreamType.RichText);
                    stream.Close();
                    fileOpened = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is:"
                                    + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
                    fileOpened = false;
                }
                Invalidate();
            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
