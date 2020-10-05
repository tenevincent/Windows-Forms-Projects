namespace ExecutingCommandsCS
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
            this.ExecuteXMLButton = new System.Windows.Forms.Button();
            this.ExecuteScalarButton = new System.Windows.Forms.Button();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.ExecuteSprocButton = new System.Windows.Forms.Button();
            this.ExecuteSqlButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExecuteXMLButton
            // 
            this.ExecuteXMLButton.Location = new System.Drawing.Point(117, 230);
            this.ExecuteXMLButton.Name = "ExecuteXMLButton";
            this.ExecuteXMLButton.Size = new System.Drawing.Size(96, 23);
            this.ExecuteXMLButton.TabIndex = 11;
            this.ExecuteXMLButton.Text = "Execute XML";
            this.ExecuteXMLButton.UseVisualStyleBackColor = true;
            this.ExecuteXMLButton.Click += new System.EventHandler(this.ExecuteXMLButton_Click);
            // 
            // ExecuteScalarButton
            // 
            this.ExecuteScalarButton.Location = new System.Drawing.Point(13, 230);
            this.ExecuteScalarButton.Name = "ExecuteScalarButton";
            this.ExecuteScalarButton.Size = new System.Drawing.Size(96, 23);
            this.ExecuteScalarButton.TabIndex = 10;
            this.ExecuteScalarButton.Text = "Execute Scalar";
            this.ExecuteScalarButton.UseVisualStyleBackColor = true;
            this.ExecuteScalarButton.Click += new System.EventHandler(this.ExecuteScalarButton_Click);
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(221, 202);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(96, 23);
            this.CreateTableButton.TabIndex = 9;
            this.CreateTableButton.Text = "Create Table";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // ExecuteSprocButton
            // 
            this.ExecuteSprocButton.Location = new System.Drawing.Point(117, 201);
            this.ExecuteSprocButton.Name = "ExecuteSprocButton";
            this.ExecuteSprocButton.Size = new System.Drawing.Size(96, 23);
            this.ExecuteSprocButton.TabIndex = 8;
            this.ExecuteSprocButton.Text = "Execute Sproc";
            this.ExecuteSprocButton.UseVisualStyleBackColor = true;
            this.ExecuteSprocButton.Click += new System.EventHandler(this.ExecuteSprocButton_Click);
            // 
            // ExecuteSqlButton
            // 
            this.ExecuteSqlButton.Location = new System.Drawing.Point(13, 201);
            this.ExecuteSqlButton.Name = "ExecuteSqlButton";
            this.ExecuteSqlButton.Size = new System.Drawing.Size(96, 23);
            this.ExecuteSqlButton.TabIndex = 7;
            this.ExecuteSqlButton.Text = "Execute SQL";
            this.ExecuteSqlButton.UseVisualStyleBackColor = true;
            this.ExecuteSqlButton.Click += new System.EventHandler(this.ExecuteSqlButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(307, 183);
            this.ResultsTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 263);
            this.Controls.Add(this.ExecuteXMLButton);
            this.Controls.Add(this.ExecuteScalarButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.ExecuteSprocButton);
            this.Controls.Add(this.ExecuteSqlButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Name = "Form1";
            this.Text = "Executing Commands CS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ExecuteXMLButton;
        internal System.Windows.Forms.Button ExecuteScalarButton;
        internal System.Windows.Forms.Button CreateTableButton;
        internal System.Windows.Forms.Button ExecuteSprocButton;
        internal System.Windows.Forms.Button ExecuteSqlButton;
        internal System.Windows.Forms.TextBox ResultsTextBox;
    }
}

