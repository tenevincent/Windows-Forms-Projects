namespace ParameterizedStoredProcedureCS
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
            this.ExecuteStoredProcedureButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExecuteStoredProcedureButton
            // 
            this.ExecuteStoredProcedureButton.Location = new System.Drawing.Point(146, 248);
            this.ExecuteStoredProcedureButton.Name = "ExecuteStoredProcedureButton";
            this.ExecuteStoredProcedureButton.Size = new System.Drawing.Size(153, 23);
            this.ExecuteStoredProcedureButton.TabIndex = 11;
            this.ExecuteStoredProcedureButton.Text = "Execute Stored Procedure";
            this.ExecuteStoredProcedureButton.UseVisualStyleBackColor = true;
            this.ExecuteStoredProcedureButton.Click += new System.EventHandler(this.ExecuteStoredProcedureButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 52);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(287, 190);
            this.ResultsTextBox.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(142, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Order Year:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Category name:";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(145, 26);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrdYearTextBox.TabIndex = 7;
            this.OrdYearTextBox.Text = "1997";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(12, 26);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryNameTextBox.TabIndex = 6;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 285);
            this.Controls.Add(this.ExecuteStoredProcedureButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Name = "Form1";
            this.Text = "Parameterized Stored ProcedureCS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ExecuteStoredProcedureButton;
        internal System.Windows.Forms.TextBox ResultsTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox OrdYearTextBox;
        internal System.Windows.Forms.TextBox CategoryNameTextBox;
    }
}

