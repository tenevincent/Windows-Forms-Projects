namespace HandlingConnectionErrorsCS
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
            this.GoodConnectButton = new System.Windows.Forms.Button();
            this.ConnectToInvalidUserButton = new System.Windows.Forms.Button();
            this.ConnectToInvalidDatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoodConnectButton
            // 
            this.GoodConnectButton.Location = new System.Drawing.Point(13, 13);
            this.GoodConnectButton.Name = "GoodConnectButton";
            this.GoodConnectButton.Size = new System.Drawing.Size(191, 23);
            this.GoodConnectButton.TabIndex = 0;
            this.GoodConnectButton.Text = "Connect (valid connection string)";
            this.GoodConnectButton.UseVisualStyleBackColor = true;
            this.GoodConnectButton.Click += new System.EventHandler(this.GoodConnectButton_Click);
            // 
            // ConnectToInvalidUserButton
            // 
            this.ConnectToInvalidUserButton.Location = new System.Drawing.Point(13, 42);
            this.ConnectToInvalidUserButton.Name = "ConnectToInvalidUserButton";
            this.ConnectToInvalidUserButton.Size = new System.Drawing.Size(191, 23);
            this.ConnectToInvalidUserButton.TabIndex = 1;
            this.ConnectToInvalidUserButton.Text = "Connect to invalid user";
            this.ConnectToInvalidUserButton.UseVisualStyleBackColor = true;
            this.ConnectToInvalidUserButton.Click += new System.EventHandler(this.ConnectToInvalidUserButton_Click);
            // 
            // ConnectToInvalidDatabaseButton
            // 
            this.ConnectToInvalidDatabaseButton.Location = new System.Drawing.Point(13, 71);
            this.ConnectToInvalidDatabaseButton.Name = "ConnectToInvalidDatabaseButton";
            this.ConnectToInvalidDatabaseButton.Size = new System.Drawing.Size(191, 23);
            this.ConnectToInvalidDatabaseButton.TabIndex = 2;
            this.ConnectToInvalidDatabaseButton.Text = "Connect to invalid database";
            this.ConnectToInvalidDatabaseButton.UseVisualStyleBackColor = true;
            this.ConnectToInvalidDatabaseButton.Click += new System.EventHandler(this.ConnectToInvalidDatabaseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 116);
            this.Controls.Add(this.ConnectToInvalidDatabaseButton);
            this.Controls.Add(this.ConnectToInvalidUserButton);
            this.Controls.Add(this.GoodConnectButton);
            this.Name = "Form1";
            this.Text = "Handling Database Connection Errors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoodConnectButton;
        private System.Windows.Forms.Button ConnectToInvalidUserButton;
        private System.Windows.Forms.Button ConnectToInvalidDatabaseButton;
    }
}

