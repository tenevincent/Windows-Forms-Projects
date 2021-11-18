
namespace Fundamentals.Chapter01.Forms
{
    partial class CustomerUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUI));
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            this.btnColor = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColor)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(3, 3);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(163, 20);
            this.radTextBox1.TabIndex = 0;
            // 
            // radColorDialog1
            // 
            this.radColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("radColorDialog1.Icon")));
            this.radColorDialog1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radColorDialog1.SelectedColor = System.Drawing.Color.Red;
            this.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0D, 1D, 1D);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(338, 317);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(110, 24);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Select a Color";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.radTextBox1);
            this.Name = "CustomerUI";
            this.Size = new System.Drawing.Size(488, 364);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
        public Telerik.WinControls.UI.RadButton btnColor;
    }
}
