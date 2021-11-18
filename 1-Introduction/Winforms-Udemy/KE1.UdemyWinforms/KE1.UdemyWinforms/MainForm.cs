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
    }
}