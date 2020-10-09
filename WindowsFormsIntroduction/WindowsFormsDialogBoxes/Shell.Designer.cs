
namespace WindowsFormsDialogBoxes
{
    partial class Shell
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenDialogBox = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnColorDialogBox = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenDialogBox
            // 
            this.btnOpenDialogBox.Location = new System.Drawing.Point(12, 23);
            this.btnOpenDialogBox.Name = "btnOpenDialogBox";
            this.btnOpenDialogBox.Size = new System.Drawing.Size(168, 39);
            this.btnOpenDialogBox.TabIndex = 0;
            this.btnOpenDialogBox.Text = "Open Custom Dialog Box";
            this.btnOpenDialogBox.UseVisualStyleBackColor = true;
            this.btnOpenDialogBox.Click += new System.EventHandler(this.btnOpenDialogBox_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(678, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "stripStatusLabel";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnColorDialogBox
            // 
            this.btnColorDialogBox.Location = new System.Drawing.Point(12, 84);
            this.btnColorDialogBox.Name = "btnColorDialogBox";
            this.btnColorDialogBox.Size = new System.Drawing.Size(168, 39);
            this.btnColorDialogBox.TabIndex = 2;
            this.btnColorDialogBox.Text = "Color DialogBox";
            this.btnColorDialogBox.UseVisualStyleBackColor = true;
            this.btnColorDialogBox.Click += new System.EventHandler(this.btnColorDialogBox_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(313, 32);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(376, 23);
            this.textBoxInput.TabIndex = 3;
            this.textBoxInput.Text = "Enter a message here...";
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(12, 146);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(168, 39);
            this.btnFontDialog.TabIndex = 4;
            this.btnFontDialog.Text = "Font DialogBox";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(12, 203);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(168, 39);
            this.btnOpenFileDialog.TabIndex = 5;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(12, 267);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(168, 39);
            this.btnSaveFileDialog.TabIndex = 6;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.btnColorDialogBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOpenDialogBox);
            this.Name = "Shell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDialogBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnColorDialogBox;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

