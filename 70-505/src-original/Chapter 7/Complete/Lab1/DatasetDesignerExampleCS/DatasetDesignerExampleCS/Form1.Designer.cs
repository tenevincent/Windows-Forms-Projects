namespace DatasetDesignerExampleCS
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
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.GetCustomersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(9, 13);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(357, 238);
            this.CustomersListBox.TabIndex = 0;
            // 
            // GetCustomersButton
            // 
            this.GetCustomersButton.Location = new System.Drawing.Point(249, 258);
            this.GetCustomersButton.Name = "GetCustomersButton";
            this.GetCustomersButton.Size = new System.Drawing.Size(116, 23);
            this.GetCustomersButton.TabIndex = 1;
            this.GetCustomersButton.Text = "Get Customers";
            this.GetCustomersButton.UseVisualStyleBackColor = true;
            this.GetCustomersButton.Click += new System.EventHandler(this.GetCustomersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 302);
            this.Controls.Add(this.GetCustomersButton);
            this.Controls.Add(this.CustomersListBox);
            this.Name = "Form1";
            this.Text = "Dataset Designer Example CS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Button GetCustomersButton;
    }
}

