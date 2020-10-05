namespace ParameterizedQueriesCS
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
            this.ExecuteSqlButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExecuteSqlButton
            // 
            this.ExecuteSqlButton.Location = new System.Drawing.Point(236, 244);
            this.ExecuteSqlButton.Name = "ExecuteSqlButton";
            this.ExecuteSqlButton.Size = new System.Drawing.Size(89, 23);
            this.ExecuteSqlButton.TabIndex = 5;
            this.ExecuteSqlButton.Text = "Execute Sql";
            this.ExecuteSqlButton.UseVisualStyleBackColor = true;
            this.ExecuteSqlButton.Click += new System.EventHandler(this.ExecuteSqlButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(9, 35);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(316, 203);
            this.ResultsTextBox.TabIndex = 4;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(10, 6);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(220, 20);
            this.CityTextBox.TabIndex = 3;
            this.CityTextBox.Text = "London";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 277);
            this.Controls.Add(this.ExecuteSqlButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Name = "Form1";
            this.Text = "Parameterized Query CS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ExecuteSqlButton;
        internal System.Windows.Forms.TextBox ResultsTextBox;
        internal System.Windows.Forms.TextBox CityTextBox;
    }
}

