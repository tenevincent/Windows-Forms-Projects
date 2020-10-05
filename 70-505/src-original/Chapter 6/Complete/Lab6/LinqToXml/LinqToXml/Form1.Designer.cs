namespace LinqToXml
{
    partial class LinqToXmlForm
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
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.LoadProductsButton = new System.Windows.Forms.Button();
            this.GetProductInfoButton = new System.Windows.Forms.Button();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(6, 15);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(171, 264);
            this.resultsListBox.TabIndex = 0;
            // 
            // LoadProductsButton
            // 
            this.LoadProductsButton.Location = new System.Drawing.Point(183, 15);
            this.LoadProductsButton.Name = "LoadProductsButton";
            this.LoadProductsButton.Size = new System.Drawing.Size(94, 23);
            this.LoadProductsButton.TabIndex = 1;
            this.LoadProductsButton.Text = "Load Products";
            this.LoadProductsButton.UseVisualStyleBackColor = true;
            this.LoadProductsButton.Click += new System.EventHandler(this.LoadProductsButton_Click);
            // 
            // GetProductInfoButton
            // 
            this.GetProductInfoButton.Location = new System.Drawing.Point(183, 44);
            this.GetProductInfoButton.Name = "GetProductInfoButton";
            this.GetProductInfoButton.Size = new System.Drawing.Size(94, 23);
            this.GetProductInfoButton.TabIndex = 2;
            this.GetProductInfoButton.Text = "Get Product Info";
            this.GetProductInfoButton.UseVisualStyleBackColor = true;
            this.GetProductInfoButton.Click += new System.EventHandler(this.GetProductInfoButton_Click);
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(188, 106);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(102, 20);
            this.quantityPerUnitTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity Per Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unit Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(190, 156);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 6;
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.Location = new System.Drawing.Point(190, 206);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsInStockTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Units In Stock:";
            // 
            // LinqToXmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 291);
            this.Controls.Add(this.unitsInStockTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityPerUnitTextBox);
            this.Controls.Add(this.GetProductInfoButton);
            this.Controls.Add(this.LoadProductsButton);
            this.Controls.Add(this.resultsListBox);
            this.Name = "LinqToXmlForm";
            this.Text = "LINQ to XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button LoadProductsButton;
        private System.Windows.Forms.Button GetProductInfoButton;
        private System.Windows.Forms.TextBox quantityPerUnitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.Label label3;
    }
}

