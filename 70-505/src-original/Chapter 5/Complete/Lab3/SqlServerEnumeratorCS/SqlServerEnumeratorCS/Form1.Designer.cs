namespace SqlServerEnumeratorCS
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
            this.GetDataSourcesButton = new System.Windows.Forms.Button();
            this.VisibleSqlServers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VisibleSqlServers)).BeginInit();
            this.SuspendLayout();
            // 
            // GetDataSourcesButton
            // 
            this.GetDataSourcesButton.Location = new System.Drawing.Point(339, 138);
            this.GetDataSourcesButton.Name = "GetDataSourcesButton";
            this.GetDataSourcesButton.Size = new System.Drawing.Size(120, 27);
            this.GetDataSourcesButton.TabIndex = 5;
            this.GetDataSourcesButton.Text = "Get Visible Servers";
            this.GetDataSourcesButton.UseVisualStyleBackColor = true;
            this.GetDataSourcesButton.Click += new System.EventHandler(this.GetDataSourcesButton_Click);
            // 
            // VisibleSqlServers
            // 
            this.VisibleSqlServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisibleSqlServers.Location = new System.Drawing.Point(12, 12);
            this.VisibleSqlServers.Name = "VisibleSqlServers";
            this.VisibleSqlServers.Size = new System.Drawing.Size(447, 120);
            this.VisibleSqlServers.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 173);
            this.Controls.Add(this.GetDataSourcesButton);
            this.Controls.Add(this.VisibleSqlServers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VisibleSqlServers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button GetDataSourcesButton;
        internal System.Windows.Forms.DataGridView VisibleSqlServers;
    }
}

