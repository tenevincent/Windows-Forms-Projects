namespace PerformingTransactionsCS
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
            this.PerformTransactionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PerformTransactionButton
            // 
            this.PerformTransactionButton.Location = new System.Drawing.Point(149, 37);
            this.PerformTransactionButton.Name = "PerformTransactionButton";
            this.PerformTransactionButton.Size = new System.Drawing.Size(138, 23);
            this.PerformTransactionButton.TabIndex = 0;
            this.PerformTransactionButton.Text = "Perform Transaction";
            this.PerformTransactionButton.UseVisualStyleBackColor = true;
            this.PerformTransactionButton.Click += new System.EventHandler(this.PerformTransactionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 66);
            this.Controls.Add(this.PerformTransactionButton);
            this.Name = "Form1";
            this.Text = "Performing Transactions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PerformTransactionButton;
    }
}

