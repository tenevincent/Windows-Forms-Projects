using System;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                var btn = new Button() { Text = "Button " + i };
                this.flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SetFlowBreak(button3, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            tableLayoutPanel1.Controls.Add(aButton, 1, 1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (splitContainer1.FixedPanel == FixedPanel.Panel1)
                splitContainer1.FixedPanel = FixedPanel.None;
            else 
                splitContainer1.FixedPanel = FixedPanel.Panel1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = !(splitContainer1.IsSplitterFixed);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(splitContainer1.Panel1Collapsed);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}