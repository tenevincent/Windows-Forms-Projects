namespace LinqToDataSet
{
    partial class LinqToDataSetForm
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
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.getCustomersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(12, 12);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(147, 21);
            this.countryComboBox.TabIndex = 0;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(14, 39);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(145, 186);
            this.resultsListBox.TabIndex = 1;
            // 
            // getCustomersButton
            // 
            this.getCustomersButton.Location = new System.Drawing.Point(165, 49);
            this.getCustomersButton.Name = "getCustomersButton";
            this.getCustomersButton.Size = new System.Drawing.Size(88, 23);
            this.getCustomersButton.TabIndex = 2;
            this.getCustomersButton.Text = "Get Customers";
            this.getCustomersButton.UseVisualStyleBackColor = true;
            this.getCustomersButton.Click += new System.EventHandler(this.getCustomersButton_Click);
            // 
            // LinqToDataSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 246);
            this.Controls.Add(this.getCustomersButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.countryComboBox);
            this.Name = "LinqToDataSetForm";
            this.Text = "LINQ to DataSet";
            this.Load += new System.EventHandler(this.LinqToDataSetForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button getCustomersButton;
    }
}

