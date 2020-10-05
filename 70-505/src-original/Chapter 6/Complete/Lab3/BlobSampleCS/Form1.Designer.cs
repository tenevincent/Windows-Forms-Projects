namespace BlobSampleCS
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.RefreshBlobListButton = new System.Windows.Forms.Button();
            this.BlobList = new System.Windows.Forms.ComboBox();
            this.FetchBlobButton = new System.Windows.Forms.Button();
            this.SaveBlobButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(138, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Current BLOBs in database:";
            // 
            // RefreshBlobListButton
            // 
            this.RefreshBlobListButton.Location = new System.Drawing.Point(12, 57);
            this.RefreshBlobListButton.Name = "RefreshBlobListButton";
            this.RefreshBlobListButton.Size = new System.Drawing.Size(188, 21);
            this.RefreshBlobListButton.TabIndex = 9;
            this.RefreshBlobListButton.Text = "Refresh List";
            this.RefreshBlobListButton.UseVisualStyleBackColor = true;
            this.RefreshBlobListButton.Click += new System.EventHandler(this.RefreshBlobListButton_Click);
            // 
            // BlobList
            // 
            this.BlobList.FormattingEnabled = true;
            this.BlobList.Location = new System.Drawing.Point(12, 30);
            this.BlobList.Name = "BlobList";
            this.BlobList.Size = new System.Drawing.Size(188, 21);
            this.BlobList.TabIndex = 8;
            // 
            // FetchBlobButton
            // 
            this.FetchBlobButton.Location = new System.Drawing.Point(12, 152);
            this.FetchBlobButton.Name = "FetchBlobButton";
            this.FetchBlobButton.Size = new System.Drawing.Size(188, 29);
            this.FetchBlobButton.TabIndex = 7;
            this.FetchBlobButton.Text = "Fetch BLOB from Database";
            this.FetchBlobButton.UseVisualStyleBackColor = true;
            this.FetchBlobButton.Click += new System.EventHandler(this.FetchBlobButton_Click);
            // 
            // SaveBlobButton
            // 
            this.SaveBlobButton.Location = new System.Drawing.Point(12, 117);
            this.SaveBlobButton.Name = "SaveBlobButton";
            this.SaveBlobButton.Size = new System.Drawing.Size(188, 29);
            this.SaveBlobButton.TabIndex = 6;
            this.SaveBlobButton.Text = "Save BLOB to Database";
            this.SaveBlobButton.UseVisualStyleBackColor = true;
            this.SaveBlobButton.Click += new System.EventHandler(this.SaveBlobButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 191);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.RefreshBlobListButton);
            this.Controls.Add(this.BlobList);
            this.Controls.Add(this.FetchBlobButton);
            this.Controls.Add(this.SaveBlobButton);
            this.Name = "Form1";
            this.Text = "BlobSampleCS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button RefreshBlobListButton;
        internal System.Windows.Forms.ComboBox BlobList;
        internal System.Windows.Forms.Button FetchBlobButton;
        internal System.Windows.Forms.Button SaveBlobButton;
    }
}

