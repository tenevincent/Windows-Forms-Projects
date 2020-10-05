namespace DataConnectionCS
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
            this.RaiseSqlExceptionButton = new System.Windows.Forms.Button();
            this.GetOracleInfoButton = new System.Windows.Forms.Button();
            this.GetOdbcInfoButton = new System.Windows.Forms.Button();
            this.GetOleDbInfoButton = new System.Windows.Forms.Button();
            this.GetSqlInfoButton = new System.Windows.Forms.Button();
            this.CloseOracleButton = new System.Windows.Forms.Button();
            this.CloseOdbcButton = new System.Windows.Forms.Button();
            this.CloseOleDbButton = new System.Windows.Forms.Button();
            this.CloseSqlButton = new System.Windows.Forms.Button();
            this.OracleConnectionStateLabel = new System.Windows.Forms.Label();
            this.OdbcConnectionStateLabel = new System.Windows.Forms.Label();
            this.OleDbConnectionStateLabel = new System.Windows.Forms.Label();
            this.SqlConnectionStateLabel = new System.Windows.Forms.Label();
            this.OpenOracleButton = new System.Windows.Forms.Button();
            this.OpenOdbcButton = new System.Windows.Forms.Button();
            this.OpenOleDbButton = new System.Windows.Forms.Button();
            this.OpenSqlServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RaiseSqlExceptionButton
            // 
            this.RaiseSqlExceptionButton.Location = new System.Drawing.Point(202, 150);
            this.RaiseSqlExceptionButton.Name = "RaiseSqlExceptionButton";
            this.RaiseSqlExceptionButton.Size = new System.Drawing.Size(224, 23);
            this.RaiseSqlExceptionButton.TabIndex = 33;
            this.RaiseSqlExceptionButton.Text = "Raise Sql Exception";
            this.RaiseSqlExceptionButton.UseVisualStyleBackColor = true;
            this.RaiseSqlExceptionButton.Click += new System.EventHandler(this.RaiseSqlExceptionButton_Click);
            // 
            // GetOracleInfoButton
            // 
            this.GetOracleInfoButton.Location = new System.Drawing.Point(202, 112);
            this.GetOracleInfoButton.Name = "GetOracleInfoButton";
            this.GetOracleInfoButton.Size = new System.Drawing.Size(98, 23);
            this.GetOracleInfoButton.TabIndex = 32;
            this.GetOracleInfoButton.Text = "Get Oracle Info";
            this.GetOracleInfoButton.UseVisualStyleBackColor = true;
            this.GetOracleInfoButton.Click += new System.EventHandler(this.GetOracleInfoButton_Click);
            // 
            // GetOdbcInfoButton
            // 
            this.GetOdbcInfoButton.Location = new System.Drawing.Point(202, 82);
            this.GetOdbcInfoButton.Name = "GetOdbcInfoButton";
            this.GetOdbcInfoButton.Size = new System.Drawing.Size(98, 23);
            this.GetOdbcInfoButton.TabIndex = 31;
            this.GetOdbcInfoButton.Text = "GetODBC Info";
            this.GetOdbcInfoButton.UseVisualStyleBackColor = true;
            this.GetOdbcInfoButton.Click += new System.EventHandler(this.GetOdbcInfoButton_Click);
            // 
            // GetOleDbInfoButton
            // 
            this.GetOleDbInfoButton.Location = new System.Drawing.Point(202, 52);
            this.GetOleDbInfoButton.Name = "GetOleDbInfoButton";
            this.GetOleDbInfoButton.Size = new System.Drawing.Size(98, 23);
            this.GetOleDbInfoButton.TabIndex = 30;
            this.GetOleDbInfoButton.Text = "Get OLE DB Info";
            this.GetOleDbInfoButton.UseVisualStyleBackColor = true;
            this.GetOleDbInfoButton.Click += new System.EventHandler(this.GetOleDbInfoButton_Click);
            // 
            // GetSqlInfoButton
            // 
            this.GetSqlInfoButton.Location = new System.Drawing.Point(202, 22);
            this.GetSqlInfoButton.Name = "GetSqlInfoButton";
            this.GetSqlInfoButton.Size = new System.Drawing.Size(98, 23);
            this.GetSqlInfoButton.TabIndex = 29;
            this.GetSqlInfoButton.Text = "Get SQL Info";
            this.GetSqlInfoButton.UseVisualStyleBackColor = true;
            this.GetSqlInfoButton.Click += new System.EventHandler(this.GetSqlInfoButton_Click);
            // 
            // CloseOracleButton
            // 
            this.CloseOracleButton.Location = new System.Drawing.Point(332, 112);
            this.CloseOracleButton.Name = "CloseOracleButton";
            this.CloseOracleButton.Size = new System.Drawing.Size(94, 23);
            this.CloseOracleButton.TabIndex = 28;
            this.CloseOracleButton.Text = "Close Oracle";
            this.CloseOracleButton.UseVisualStyleBackColor = true;
            this.CloseOracleButton.Click += new System.EventHandler(this.CloseOracleButton_Click);
            // 
            // CloseOdbcButton
            // 
            this.CloseOdbcButton.Location = new System.Drawing.Point(332, 82);
            this.CloseOdbcButton.Name = "CloseOdbcButton";
            this.CloseOdbcButton.Size = new System.Drawing.Size(94, 23);
            this.CloseOdbcButton.TabIndex = 27;
            this.CloseOdbcButton.Text = "Close ODBC";
            this.CloseOdbcButton.UseVisualStyleBackColor = true;
            this.CloseOdbcButton.Click += new System.EventHandler(this.CloseOdbcButton_Click);
            // 
            // CloseOleDbButton
            // 
            this.CloseOleDbButton.Location = new System.Drawing.Point(332, 52);
            this.CloseOleDbButton.Name = "CloseOleDbButton";
            this.CloseOleDbButton.Size = new System.Drawing.Size(94, 23);
            this.CloseOleDbButton.TabIndex = 26;
            this.CloseOleDbButton.Text = "Close OLE DB";
            this.CloseOleDbButton.UseVisualStyleBackColor = true;
            this.CloseOleDbButton.Click += new System.EventHandler(this.CloseOleDbButton_Click);
            // 
            // CloseSqlButton
            // 
            this.CloseSqlButton.Location = new System.Drawing.Point(332, 22);
            this.CloseSqlButton.Name = "CloseSqlButton";
            this.CloseSqlButton.Size = new System.Drawing.Size(94, 23);
            this.CloseSqlButton.TabIndex = 25;
            this.CloseSqlButton.Text = "Close SQL";
            this.CloseSqlButton.UseVisualStyleBackColor = true;
            this.CloseSqlButton.Click += new System.EventHandler(this.CloseSqlButton_Click);
            // 
            // OracleConnectionStateLabel
            // 
            this.OracleConnectionStateLabel.AutoSize = true;
            this.OracleConnectionStateLabel.Location = new System.Drawing.Point(131, 112);
            this.OracleConnectionStateLabel.Name = "OracleConnectionStateLabel";
            this.OracleConnectionStateLabel.Size = new System.Drawing.Size(39, 13);
            this.OracleConnectionStateLabel.TabIndex = 24;
            this.OracleConnectionStateLabel.Text = "Closed";
            // 
            // OdbcConnectionStateLabel
            // 
            this.OdbcConnectionStateLabel.AutoSize = true;
            this.OdbcConnectionStateLabel.Location = new System.Drawing.Point(129, 82);
            this.OdbcConnectionStateLabel.Name = "OdbcConnectionStateLabel";
            this.OdbcConnectionStateLabel.Size = new System.Drawing.Size(39, 13);
            this.OdbcConnectionStateLabel.TabIndex = 23;
            this.OdbcConnectionStateLabel.Text = "Closed";
            // 
            // OleDbConnectionStateLabel
            // 
            this.OleDbConnectionStateLabel.AutoSize = true;
            this.OleDbConnectionStateLabel.Location = new System.Drawing.Point(129, 52);
            this.OleDbConnectionStateLabel.Name = "OleDbConnectionStateLabel";
            this.OleDbConnectionStateLabel.Size = new System.Drawing.Size(39, 13);
            this.OleDbConnectionStateLabel.TabIndex = 22;
            this.OleDbConnectionStateLabel.Text = "Closed";
            // 
            // SqlConnectionStateLabel
            // 
            this.SqlConnectionStateLabel.AutoSize = true;
            this.SqlConnectionStateLabel.Location = new System.Drawing.Point(129, 22);
            this.SqlConnectionStateLabel.Name = "SqlConnectionStateLabel";
            this.SqlConnectionStateLabel.Size = new System.Drawing.Size(39, 13);
            this.SqlConnectionStateLabel.TabIndex = 21;
            this.SqlConnectionStateLabel.Text = "Closed";
            // 
            // OpenOracleButton
            // 
            this.OpenOracleButton.Location = new System.Drawing.Point(20, 112);
            this.OpenOracleButton.Name = "OpenOracleButton";
            this.OpenOracleButton.Size = new System.Drawing.Size(94, 23);
            this.OpenOracleButton.TabIndex = 20;
            this.OpenOracleButton.Text = "Open Oracle";
            this.OpenOracleButton.UseVisualStyleBackColor = true;
            this.OpenOracleButton.Click += new System.EventHandler(this.OpenOracleButton_Click);
            // 
            // OpenOdbcButton
            // 
            this.OpenOdbcButton.Location = new System.Drawing.Point(20, 82);
            this.OpenOdbcButton.Name = "OpenOdbcButton";
            this.OpenOdbcButton.Size = new System.Drawing.Size(94, 23);
            this.OpenOdbcButton.TabIndex = 19;
            this.OpenOdbcButton.Text = "Open ODBC";
            this.OpenOdbcButton.UseVisualStyleBackColor = true;
            this.OpenOdbcButton.Click += new System.EventHandler(this.OpenOdbcButton_Click);
            // 
            // OpenOleDbButton
            // 
            this.OpenOleDbButton.Location = new System.Drawing.Point(20, 52);
            this.OpenOleDbButton.Name = "OpenOleDbButton";
            this.OpenOleDbButton.Size = new System.Drawing.Size(94, 23);
            this.OpenOleDbButton.TabIndex = 18;
            this.OpenOleDbButton.Text = "Open OLE DB";
            this.OpenOleDbButton.UseVisualStyleBackColor = true;
            this.OpenOleDbButton.Click += new System.EventHandler(this.OpenOleDbButton_Click);
            // 
            // OpenSqlServerButton
            // 
            this.OpenSqlServerButton.Location = new System.Drawing.Point(20, 22);
            this.OpenSqlServerButton.Name = "OpenSqlServerButton";
            this.OpenSqlServerButton.Size = new System.Drawing.Size(94, 23);
            this.OpenSqlServerButton.TabIndex = 17;
            this.OpenSqlServerButton.Text = "Open SQL";
            this.OpenSqlServerButton.UseVisualStyleBackColor = true;
            this.OpenSqlServerButton.Click += new System.EventHandler(this.OpenSqlServerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 186);
            this.Controls.Add(this.RaiseSqlExceptionButton);
            this.Controls.Add(this.GetOracleInfoButton);
            this.Controls.Add(this.GetOdbcInfoButton);
            this.Controls.Add(this.GetOleDbInfoButton);
            this.Controls.Add(this.GetSqlInfoButton);
            this.Controls.Add(this.CloseOracleButton);
            this.Controls.Add(this.CloseOdbcButton);
            this.Controls.Add(this.CloseOleDbButton);
            this.Controls.Add(this.CloseSqlButton);
            this.Controls.Add(this.OracleConnectionStateLabel);
            this.Controls.Add(this.OdbcConnectionStateLabel);
            this.Controls.Add(this.OleDbConnectionStateLabel);
            this.Controls.Add(this.SqlConnectionStateLabel);
            this.Controls.Add(this.OpenOracleButton);
            this.Controls.Add(this.OpenOdbcButton);
            this.Controls.Add(this.OpenOleDbButton);
            this.Controls.Add(this.OpenSqlServerButton);
            this.Name = "Form1";
            this.Text = "Data Connections (C#)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button RaiseSqlExceptionButton;
        internal System.Windows.Forms.Button GetOracleInfoButton;
        internal System.Windows.Forms.Button GetOdbcInfoButton;
        internal System.Windows.Forms.Button GetOleDbInfoButton;
        internal System.Windows.Forms.Button GetSqlInfoButton;
        internal System.Windows.Forms.Button CloseOracleButton;
        internal System.Windows.Forms.Button CloseOdbcButton;
        internal System.Windows.Forms.Button CloseOleDbButton;
        internal System.Windows.Forms.Button CloseSqlButton;
        internal System.Windows.Forms.Label OracleConnectionStateLabel;
        internal System.Windows.Forms.Label OdbcConnectionStateLabel;
        internal System.Windows.Forms.Label OleDbConnectionStateLabel;
        internal System.Windows.Forms.Label SqlConnectionStateLabel;
        internal System.Windows.Forms.Button OpenOracleButton;
        internal System.Windows.Forms.Button OpenOdbcButton;
        internal System.Windows.Forms.Button OpenOleDbButton;
        internal System.Windows.Forms.Button OpenSqlServerButton;
    }
}

