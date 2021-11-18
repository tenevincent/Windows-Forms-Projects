namespace KE1.UdemyWinforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForms_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.backup_32x32;
            var scale = new AutoCompleteStringCollection();
            scale.Add("One Million");
            scale.Add("One Million 1");
            scale.Add("One Million 2");
            scale.Add("One Million 3");
            scale.Add("One Million 4");
            scale.Add("Two Million 4");
            scale.Add("Fourth Million 4");

            textBox4.AutoCompleteSource =  AutoCompleteSource.CustomSource;
            textBox4.AutoCompleteCustomSource = scale;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe", @"G:\Temp\GannReports\CONF\REPORT02.JSON");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // New text..
            btnStatusMessage.Text = textBox3.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // New text..
            btnStatusMessage.Text = textBox7.Text;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Purpose ==>: Gets the used character...
            //MessageBox.Show(((int)e.KeyChar).ToString());
            if ((int)e.KeyChar == 8) //for backspace
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9') //If the Char is in range of 48 to 57.
                e.Handled = true; //Don’t display the char in textbox.
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) // Purpose ==>: if a combination of keys is used
                MessageBox.Show("Control + A is Clicked");
        }

        private void textBox7_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox7.Text == "8")
            {
                errorProvider1.SetError(textBox7, "The value cannot be 7");
                e.Cancel = true; //Doesn’t allow the textbox to lose focus.
            }
            else
                errorProvider1.SetError(textBox7, "");
        }

        private void textBoxValidation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxValidation.Text == "")
            {
                errorProvider1.SetError(textBoxValidation, "The value cannot be empty");
                e.Cancel = true; //Doesn’t allow the textbox to lose focus.
            }
            else
                errorProvider1.SetError(textBoxValidation, "");
        }
    }
}