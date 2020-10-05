namespace BulkCopySampleCS
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
            this.CopyCustomersButton = new System.Windows.Forms.Button();
            this.CopyOrdersButton = new System.Windows.Forms.Button();
            this.ExecuteBulkInsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CopyCustomersButton
            // 
            this.CopyCustomersButton.Location = new System.Drawing.Point(12, 12);
            this.CopyCustomersButton.Name = "CopyCustomersButton";
            this.CopyCustomersButton.Size = new System.Drawing.Size(146, 23);
            this.CopyCustomersButton.TabIndex = 0;
            this.CopyCustomersButton.Text = "Copy Customers";
            this.CopyCustomersButton.UseVisualStyleBackColor = true;
            this.CopyCustomersButton.Click += new System.EventHandler(this.CopyCustomersButton_Click);
            // 
            // CopyOrdersButton
            // 
            this.CopyOrdersButton.Location = new System.Drawing.Point(12, 41);
            this.CopyOrdersButton.Name = "CopyOrdersButton";
            this.CopyOrdersButton.Size = new System.Drawing.Size(146, 23);
            this.CopyOrdersButton.TabIndex = 1;
            this.CopyOrdersButton.Text = "Copy Orders";
            this.CopyOrdersButton.UseVisualStyleBackColor = true;
            this.CopyOrdersButton.Click += new System.EventHandler(this.CopyOrdersButton_Click);
            // 
            // ExecuteBulkInsertButton
            // 
            this.ExecuteBulkInsertButton.Location = new System.Drawing.Point(13, 90);
            this.ExecuteBulkInsertButton.Name = "ExecuteBulkInsertButton";
            this.ExecuteBulkInsertButton.Size = new System.Drawing.Size(143, 23);
            this.ExecuteBulkInsertButton.TabIndex = 2;
            this.ExecuteBulkInsertButton.Text = "BULK INSERT";
            this.ExecuteBulkInsertButton.UseVisualStyleBackColor = true;
            this.ExecuteBulkInsertButton.Click += new System.EventHandler(this.ExecuteBulkInsertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 154);
            this.Controls.Add(this.ExecuteBulkInsertButton);
            this.Controls.Add(this.CopyOrdersButton);
            this.Controls.Add(this.CopyCustomersButton);
            this.Name = "Form1";
            this.Text = "Bulk Copy Sample C#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CopyCustomersButton;
        private System.Windows.Forms.Button CopyOrdersButton;
        private System.Windows.Forms.Button ExecuteBulkInsertButton;
    }
}

