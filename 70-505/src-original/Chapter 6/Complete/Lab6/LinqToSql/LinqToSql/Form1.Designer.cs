namespace LinqToSql
{
    partial class LinqToSqlForm
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
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(5, 10);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(272, 21);
            this.countryComboBox.TabIndex = 0;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // resultsGrid
            // 
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Location = new System.Drawing.Point(5, 37);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.Size = new System.Drawing.Size(272, 219);
            this.resultsGrid.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(202, 262);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LinqToSqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 297);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultsGrid);
            this.Controls.Add(this.countryComboBox);
            this.Name = "LinqToSqlForm";
            this.Text = "LINQ to SQL";
            this.Load += new System.EventHandler(this.LinqToSqlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.DataGridView resultsGrid;
        private System.Windows.Forms.Button saveButton;
    }
}

