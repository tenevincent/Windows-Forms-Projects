
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.btnPrintPreviewDialog = new Telerik.WinControls.UI.RadButton();
            this.btnPrintDialog = new Telerik.WinControls.UI.RadButton();
            this.btnPageSetupDialog = new Telerik.WinControls.UI.RadButton();
            this.btnFontDialog = new Telerik.WinControls.UI.RadButton();
            this.btnColorDialog = new Telerik.WinControls.UI.RadButton();
            this.btnSaveDialog = new Telerik.WinControls.UI.RadButton();
            this.btnOpenDialog = new Telerik.WinControls.UI.RadButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintPreviewDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPageSetupDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFontDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Winforms Dialogs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.splitContainer1.Panel1.Controls.Add(this.radPanel1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(786, 418);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.btnPrintPreviewDialog);
            this.radPanel1.Controls.Add(this.btnPrintDialog);
            this.radPanel1.Controls.Add(this.btnPageSetupDialog);
            this.radPanel1.Controls.Add(this.btnFontDialog);
            this.radPanel1.Controls.Add(this.btnColorDialog);
            this.radPanel1.Controls.Add(this.btnSaveDialog);
            this.radPanel1.Controls.Add(this.btnOpenDialog);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(262, 418);
            this.radPanel1.TabIndex = 9;
            // 
            // btnPrintPreviewDialog
            // 
            this.btnPrintPreviewDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintPreviewDialog.Location = new System.Drawing.Point(11, 312);
            this.btnPrintPreviewDialog.Name = "btnPrintPreviewDialog";
            this.btnPrintPreviewDialog.Size = new System.Drawing.Size(237, 32);
            this.btnPrintPreviewDialog.TabIndex = 14;
            this.btnPrintPreviewDialog.Text = "Print Preview Dialog";
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDialog.Location = new System.Drawing.Point(11, 271);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(237, 32);
            this.btnPrintDialog.TabIndex = 13;
            this.btnPrintDialog.Text = "Print Dialog";
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnPageSetupDialog
            // 
            this.btnPageSetupDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageSetupDialog.Location = new System.Drawing.Point(11, 221);
            this.btnPageSetupDialog.Name = "btnPageSetupDialog";
            this.btnPageSetupDialog.Size = new System.Drawing.Size(237, 32);
            this.btnPageSetupDialog.TabIndex = 12;
            this.btnPageSetupDialog.Text = "Page Setup Dialog";
            this.btnPageSetupDialog.Click += new System.EventHandler(this.btnPageSetupDialog_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontDialog.Location = new System.Drawing.Point(11, 171);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(237, 32);
            this.btnFontDialog.TabIndex = 11;
            this.btnFontDialog.Text = "Font Dialog";
            this.btnFontDialog.Click += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorDialog.Location = new System.Drawing.Point(11, 121);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(237, 32);
            this.btnColorDialog.TabIndex = 10;
            this.btnColorDialog.Text = "Color Dialog";
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnSaveDialog
            // 
            this.btnSaveDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDialog.Location = new System.Drawing.Point(11, 71);
            this.btnSaveDialog.Name = "btnSaveDialog";
            this.btnSaveDialog.Size = new System.Drawing.Size(237, 32);
            this.btnSaveDialog.TabIndex = 9;
            this.btnSaveDialog.Text = "Save Dialog";
            this.btnSaveDialog.Click += new System.EventHandler(this.btnSaveDialog_Click);
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDialog.Location = new System.Drawing.Point(11, 21);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(237, 32);
            this.btnOpenDialog.TabIndex = 8;
            this.btnOpenDialog.Text = "Open Dialog";
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Size = new System.Drawing.Size(520, 418);
            this.splitContainer2.SplitterDistance = 173;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(520, 173);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 241);
            this.listBox1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dialogs";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintPreviewDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPageSetupDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFontDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnColorDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenDialog)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton btnPrintPreviewDialog;
        private Telerik.WinControls.UI.RadButton btnPrintDialog;
        private Telerik.WinControls.UI.RadButton btnPageSetupDialog;
        private Telerik.WinControls.UI.RadButton btnFontDialog;
        private Telerik.WinControls.UI.RadButton btnColorDialog;
        private Telerik.WinControls.UI.RadButton btnSaveDialog;
        private Telerik.WinControls.UI.RadButton btnOpenDialog;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

