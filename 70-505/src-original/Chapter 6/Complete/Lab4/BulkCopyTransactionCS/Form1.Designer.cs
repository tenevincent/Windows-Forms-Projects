namespace BulkCopyTransactionCS
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
            this.PrepareTableButton = new System.Windows.Forms.Button();
            this.BulkCopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrepareTableButton
            // 
            this.PrepareTableButton.Location = new System.Drawing.Point(12, 12);
            this.PrepareTableButton.Name = "PrepareTableButton";
            this.PrepareTableButton.Size = new System.Drawing.Size(122, 23);
            this.PrepareTableButton.TabIndex = 0;
            this.PrepareTableButton.Text = "Prepare Table";
            this.PrepareTableButton.UseVisualStyleBackColor = true;
            this.PrepareTableButton.Click += new System.EventHandler(this.PrepareTableButton_Click);
            // 
            // BulkCopyButton
            // 
            this.BulkCopyButton.Location = new System.Drawing.Point(11, 41);
            this.BulkCopyButton.Name = "BulkCopyButton";
            this.BulkCopyButton.Size = new System.Drawing.Size(122, 23);
            this.BulkCopyButton.TabIndex = 1;
            this.BulkCopyButton.Text = "Execute Bulk Copy";
            this.BulkCopyButton.UseVisualStyleBackColor = true;
            this.BulkCopyButton.Click += new System.EventHandler(this.BulkCopyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 81);
            this.Controls.Add(this.BulkCopyButton);
            this.Controls.Add(this.PrepareTableButton);
            this.Name = "Form1";
            this.Text = "Bulk Copy Transaction C#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrepareTableButton;
        private System.Windows.Forms.Button BulkCopyButton;
    }
}

