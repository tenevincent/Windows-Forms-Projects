namespace WindowsFormsUdemyBasicControl01
{
    partial class EmailValidationTextBoxView
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
            this.components = new System.ComponentModel.Container();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyPress = new System.Windows.Forms.TextBox();
            this.labelKeyDown = new System.Windows.Forms.Label();
            this.textBoxDown = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(25, 39);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(101, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-mail address:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(155, 39);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(302, 20);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key presss Demo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxKeyPress
            // 
            this.textBoxKeyPress.Location = new System.Drawing.Point(159, 86);
            this.textBoxKeyPress.Name = "textBoxKeyPress";
            this.textBoxKeyPress.Size = new System.Drawing.Size(302, 20);
            this.textBoxKeyPress.TabIndex = 4;
            this.textBoxKeyPress.TextChanged += new System.EventHandler(this.textBoxKeyPress_TextChanged);
            this.textBoxKeyPress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress_KeyPress);
            // 
            // labelKeyDown
            // 
            this.labelKeyDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelKeyDown.Location = new System.Drawing.Point(29, 125);
            this.labelKeyDown.Name = "labelKeyDown";
            this.labelKeyDown.Size = new System.Drawing.Size(101, 20);
            this.labelKeyDown.TabIndex = 7;
            this.labelKeyDown.Text = "Key Down Demo";
            // 
            // textBoxDown
            // 
            this.textBoxDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxDown.Location = new System.Drawing.Point(159, 125);
            this.textBoxDown.Name = "textBoxDown";
            this.textBoxDown.Size = new System.Drawing.Size(302, 20);
            this.textBoxDown.TabIndex = 6;
            this.textBoxDown.TextChanged += new System.EventHandler(this.textBoxDown_TextChanged);
            this.textBoxDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDown_KeyDown);
            // 
            // EmailValidationTextBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelKeyDown);
            this.Controls.Add(this.textBoxDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKeyPress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "EmailValidationTextBoxView";
            this.Size = new System.Drawing.Size(520, 223);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailValidationTextBoxView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyPress;
        private System.Windows.Forms.Label labelKeyDown;
        private System.Windows.Forms.TextBox textBoxDown;
    }
}
