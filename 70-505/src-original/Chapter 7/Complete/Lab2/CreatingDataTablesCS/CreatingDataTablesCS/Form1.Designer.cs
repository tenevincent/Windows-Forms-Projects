namespace CreatingDataTablesCS
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
            this.TableGrid = new System.Windows.Forms.DataGridView();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TableGrid
            // 
            this.TableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid.Location = new System.Drawing.Point(7, 15);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.Size = new System.Drawing.Size(441, 247);
            this.TableGrid.TabIndex = 0;
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(12, 268);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(105, 23);
            this.CreateTableButton.TabIndex = 1;
            this.CreateTableButton.Text = "Create Table";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(123, 268);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(105, 23);
            this.AddRowButton.TabIndex = 2;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 308);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.TableGrid);
            this.Name = "Form1";
            this.Text = "Creating Data Tables";
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableGrid;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button AddRowButton;
    }
}

