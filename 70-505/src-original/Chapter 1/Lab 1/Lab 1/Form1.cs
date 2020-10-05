using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int index = 0;
        private List<FormBorderStyle> formBorderStyles = new List<FormBorderStyle>();

        private void button1_Click(object sender, EventArgs e)
        {
            if(index < formBorderStyles.Count)
            {
                this.FormBorderStyle = formBorderStyles[index];
                this.Text = this.FormBorderStyle.ToString();
                index++;
            }
            else
            {
                index = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formBorderStyles.Add( FormBorderStyle.FixedDialog);
            formBorderStyles.Add(FormBorderStyle.FixedSingle);
            formBorderStyles.Add(FormBorderStyle.None);
            formBorderStyles.Add(FormBorderStyle.FixedSingle);
            formBorderStyles.Add(FormBorderStyle.SizableToolWindow);
            formBorderStyles.Add(FormBorderStyle.SizableToolWindow);

        }
    }
}