
namespace WindowsBook.Chapter3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnPrintPreviewDialog = new Telerik.WinControls.UI.RadButton();
            this.btnPrintDialog = new Telerik.WinControls.UI.RadButton();
            this.btnPageSetupDialog = new Telerik.WinControls.UI.RadButton();
            this.btnFontDialog = new Telerik.WinControls.UI.RadButton();
            this.btnColorDialog = new Telerik.WinControls.UI.RadButton();
            this.btnSaveDialog = new Telerik.WinControls.UI.RadButton();
            this.btnOpenDialog = new Telerik.WinControls.UI.RadButton();
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintPreviewDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPageSetupDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFontDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenDialog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.radPanel1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dialogs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(152, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(632, 124);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radPanel1.Controls.Add(this.btnPrintPreviewDialog);
            this.radPanel1.Controls.Add(this.btnPrintDialog);
            this.radPanel1.Controls.Add(this.btnPageSetupDialog);
            this.radPanel1.Controls.Add(this.btnFontDialog);
            this.radPanel1.Controls.Add(this.btnColorDialog);
            this.radPanel1.Controls.Add(this.btnSaveDialog);
            this.radPanel1.Controls.Add(this.btnOpenDialog);
            this.radPanel1.Location = new System.Drawing.Point(3, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(143, 413);
            this.radPanel1.TabIndex = 8;
            // 
            // btnPrintPreviewDialog
            // 
            this.btnPrintPreviewDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPreviewDialog.Location = new System.Drawing.Point(11, 309);
            this.btnPrintPreviewDialog.Name = "btnPrintPreviewDialog";
            this.btnPrintPreviewDialog.Size = new System.Drawing.Size(118, 32);
            this.btnPrintPreviewDialog.TabIndex = 14;
            this.btnPrintPreviewDialog.Text = "Print Preview Dialog";
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDialog.Location = new System.Drawing.Point(11, 268);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(118, 32);
            this.btnPrintDialog.TabIndex = 13;
            this.btnPrintDialog.Text = "Print Dialog";
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnPageSetupDialog
            // 
            this.btnPageSetupDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageSetupDialog.Location = new System.Drawing.Point(11, 218);
            this.btnPageSetupDialog.Name = "btnPageSetupDialog";
            this.btnPageSetupDialog.Size = new System.Drawing.Size(118, 32);
            this.btnPageSetupDialog.TabIndex = 12;
            this.btnPageSetupDialog.Text = "Page Setup Dialog";
            this.btnPageSetupDialog.Click += new System.EventHandler(this.btnPageSetupDialog_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontDialog.Location = new System.Drawing.Point(11, 168);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(118, 32);
            this.btnFontDialog.TabIndex = 11;
            this.btnFontDialog.Text = "Font Dialog";
            this.btnFontDialog.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorDialog.Location = new System.Drawing.Point(11, 118);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(118, 32);
            this.btnColorDialog.TabIndex = 10;
            this.btnColorDialog.Text = "Color Dialog";
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnSaveDialog
            // 
            this.btnSaveDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDialog.Location = new System.Drawing.Point(11, 68);
            this.btnSaveDialog.Name = "btnSaveDialog";
            this.btnSaveDialog.Size = new System.Drawing.Size(118, 32);
            this.btnSaveDialog.TabIndex = 9;
            this.btnSaveDialog.Text = "Save Dialog";
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDialog.Location = new System.Drawing.Point(11, 18);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(118, 32);
            this.btnOpenDialog.TabIndex = 8;
            this.btnOpenDialog.Text = "Open Dialog";
            // 
            // radColorDialog1
            // 
            this.radColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("radColorDialog1.Icon")));
            this.radColorDialog1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radColorDialog1.SelectedColor = System.Drawing.Color.Red;
            this.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0D, 1D, 1D);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(153, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(631, 277);
            this.listBox1.TabIndex = 9;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintPreviewDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPageSetupDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFontDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenDialog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnPrintPreviewDialog;
        private Telerik.WinControls.UI.RadButton btnPrintDialog;
        private Telerik.WinControls.UI.RadButton btnPageSetupDialog;
        private Telerik.WinControls.UI.RadButton btnFontDialog;
        private Telerik.WinControls.UI.RadButton btnColorDialog;
        private Telerik.WinControls.UI.RadButton btnSaveDialog;
        private Telerik.WinControls.UI.RadButton btnOpenDialog;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

