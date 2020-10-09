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

namespace WindowsFormsDialogBoxes
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void btnOpenDialogBox_Click(object sender, EventArgs e)
        {
            var forms = new FormsFirstDialogBox();
            forms.FirstName = "Vincent";
            forms.LastName = "Tene";
            forms.Address = "Schillerstrasse 67";
            forms.Age = 43;
            forms.Owner = this;
            forms.Icon = this.Icon;
            forms.StartPosition = FormStartPosition.CenterParent;
            forms.WindowState = FormWindowState.Normal;
            forms.FormClosed += (sender1, args1) =>
             {
                 forms = null;
             };

            forms.Show();



            // var result = forms.ShowDialog();
            //this.toolStripStatusLabel1.Text = result.ToString();
            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show("The user has selected OK");
            //}
        }

        private void btnColorDialogBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogBox = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorDialogBox.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            colorDialogBox.ShowHelp = true;
            // Sets the initial color select to the current text color.
            colorDialogBox.Color = toolStripStatusLabel1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialogBox.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel1.ForeColor = colorDialogBox.Color;
                textBoxInput.ForeColor = colorDialogBox.Color;
            }
                
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBoxInput.Font;
            fontDialog1.Color = textBoxInput.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBoxInput.Font = fontDialog1.Font;
                textBoxInput.ForeColor = fontDialog1.Color;
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog1.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog1.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            Stream myStream;
           // SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }
    }
}
