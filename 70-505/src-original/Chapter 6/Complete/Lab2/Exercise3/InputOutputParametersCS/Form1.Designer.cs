namespace InputOutputParametersCS
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ContactNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.FreightCostTextBox = new System.Windows.Forms.TextBox();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.GetContactNameButton = new System.Windows.Forms.Button();
            this.GetFreightCostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 121);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 13);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Company name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(135, 121);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 13);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Contact name:";
            // 
            // ContactNameTextBox
            // 
            this.ContactNameTextBox.Location = new System.Drawing.Point(135, 137);
            this.ContactNameTextBox.Name = "ContactNameTextBox";
            this.ContactNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.ContactNameTextBox.TabIndex = 17;
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(9, 137);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.CompanyNameTextBox.TabIndex = 16;
            this.CompanyNameTextBox.Text = "Alfreds Futterkiste";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Order ID:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(135, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Freight cost:";
            // 
            // FreightCostTextBox
            // 
            this.FreightCostTextBox.Location = new System.Drawing.Point(135, 29);
            this.FreightCostTextBox.Name = "FreightCostTextBox";
            this.FreightCostTextBox.Size = new System.Drawing.Size(120, 20);
            this.FreightCostTextBox.TabIndex = 13;
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Location = new System.Drawing.Point(9, 29);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(120, 20);
            this.OrderIDTextBox.TabIndex = 12;
            this.OrderIDTextBox.Text = "10250";
            // 
            // GetContactNameButton
            // 
            this.GetContactNameButton.Location = new System.Drawing.Point(12, 163);
            this.GetContactNameButton.Name = "GetContactNameButton";
            this.GetContactNameButton.Size = new System.Drawing.Size(243, 23);
            this.GetContactNameButton.TabIndex = 11;
            this.GetContactNameButton.Text = "Get Contact Name";
            this.GetContactNameButton.UseVisualStyleBackColor = true;
            this.GetContactNameButton.Click += new System.EventHandler(this.GetContactNameButton_Click);
            // 
            // GetFreightCostButton
            // 
            this.GetFreightCostButton.Location = new System.Drawing.Point(12, 55);
            this.GetFreightCostButton.Name = "GetFreightCostButton";
            this.GetFreightCostButton.Size = new System.Drawing.Size(243, 23);
            this.GetFreightCostButton.TabIndex = 10;
            this.GetFreightCostButton.Text = "Get Freight Cost";
            this.GetFreightCostButton.UseVisualStyleBackColor = true;
            this.GetFreightCostButton.Click += new System.EventHandler(this.GetFreightCostButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 200);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ContactNameTextBox);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.FreightCostTextBox);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.GetContactNameButton);
            this.Controls.Add(this.GetFreightCostButton);
            this.Name = "Form1";
            this.Text = "InputOutput Parameters CS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox ContactNameTextBox;
        internal System.Windows.Forms.TextBox CompanyNameTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox FreightCostTextBox;
        internal System.Windows.Forms.TextBox OrderIDTextBox;
        internal System.Windows.Forms.Button GetContactNameButton;
        internal System.Windows.Forms.Button GetFreightCostButton;
    }
}

