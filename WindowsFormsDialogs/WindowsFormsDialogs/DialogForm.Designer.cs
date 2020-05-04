namespace WindowsFormsDialogs
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.btnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomDialog = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(24, 43);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(102, 23);
            this.btnOpenDialog.TabIndex = 0;
            this.btnOpenDialog.Text = "Open File Dialog";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(21, 690);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(35, 13);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "label1";
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(24, 82);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(102, 23);
            this.btnSaveFileDialog.TabIndex = 2;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(24, 125);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(102, 23);
            this.btnFontDialog.TabIndex = 3;
            this.btnFontDialog.Text = "Font Dialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnFolderBrowserDialog
            // 
            this.btnFolderBrowserDialog.Location = new System.Drawing.Point(24, 223);
            this.btnFolderBrowserDialog.Name = "btnFolderBrowserDialog";
            this.btnFolderBrowserDialog.Size = new System.Drawing.Size(102, 38);
            this.btnFolderBrowserDialog.TabIndex = 4;
            this.btnFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.btnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDialog.Click += new System.EventHandler(this.btnFolderBrowserDialog_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(225, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(937, 181);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Location = new System.Drawing.Point(24, 285);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(102, 36);
            this.btnPrintDialog.TabIndex = 6;
            this.btnPrintDialog.Text = "Print Dialog";
            this.btnPrintDialog.UseVisualStyleBackColor = true;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Location = new System.Drawing.Point(24, 168);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(102, 23);
            this.btnColorDialog.TabIndex = 7;
            this.btnColorDialog.Text = "Color Dialog";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(937, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsDialogs.Properties.Resources.Dialog_Pro_Exception;
            this.pictureBox1.Location = new System.Drawing.Point(225, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 387);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomDialog
            // 
            this.btnCustomDialog.Location = new System.Drawing.Point(24, 358);
            this.btnCustomDialog.Name = "btnCustomDialog";
            this.btnCustomDialog.Size = new System.Drawing.Size(102, 36);
            this.btnCustomDialog.TabIndex = 10;
            this.btnCustomDialog.Text = "CustomDialog";
            this.btnCustomDialog.UseVisualStyleBackColor = true;
            this.btnCustomDialog.Click += new System.EventHandler(this.btnCustomDialog_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter a valid Email (Email validation)";
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomDialog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFolderBrowserDialog);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.btnOpenDialog);
            this.Name = "DialogForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.Button btnFolderBrowserDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnPrintDialog;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}

