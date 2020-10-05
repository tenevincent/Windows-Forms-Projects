namespace LinqToObjects
{
    partial class LinqToObjectsForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.query1Button = new System.Windows.Forms.Button();
            this.query2Button = new System.Windows.Forms.Button();
            this.query3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLabel.Location = new System.Drawing.Point(7, 11);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(73, 15);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Query results:";
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(5, 36);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(166, 212);
            this.resultsListBox.TabIndex = 1;
            // 
            // query1Button
            // 
            this.query1Button.Location = new System.Drawing.Point(178, 36);
            this.query1Button.Name = "query1Button";
            this.query1Button.Size = new System.Drawing.Size(94, 23);
            this.query1Button.TabIndex = 2;
            this.query1Button.Text = "1st LINQ Query";
            this.query1Button.UseVisualStyleBackColor = true;
            this.query1Button.Click += new System.EventHandler(this.query1Button_Click);
            // 
            // query2Button
            // 
            this.query2Button.Location = new System.Drawing.Point(178, 66);
            this.query2Button.Name = "query2Button";
            this.query2Button.Size = new System.Drawing.Size(94, 23);
            this.query2Button.TabIndex = 3;
            this.query2Button.Text = "2nd LINQ Query";
            this.query2Button.UseVisualStyleBackColor = true;
            this.query2Button.Click += new System.EventHandler(this.query2Button_Click);
            // 
            // query3Button
            // 
            this.query3Button.Location = new System.Drawing.Point(178, 96);
            this.query3Button.Name = "query3Button";
            this.query3Button.Size = new System.Drawing.Size(94, 23);
            this.query3Button.TabIndex = 4;
            this.query3Button.Text = "3rd LINQ Query";
            this.query3Button.UseVisualStyleBackColor = true;
            this.query3Button.Click += new System.EventHandler(this.query3Button_Click);
            // 
            // LinqToObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.query3Button);
            this.Controls.Add(this.query2Button);
            this.Controls.Add(this.query1Button);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.infoLabel);
            this.Name = "LinqToObjectsForm";
            this.Text = "LINQ to Objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button query1Button;
        private System.Windows.Forms.Button query2Button;
        private System.Windows.Forms.Button query3Button;
    }
}

