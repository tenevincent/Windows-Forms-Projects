namespace ListItemsControlsApp
{
    partial class MainFormUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormUI));
            this.tvCountries = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvCountries
            // 
            this.tvCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCountries.Location = new System.Drawing.Point(0, 0);
            this.tvCountries.Name = "tvCountries";
            this.tvCountries.Size = new System.Drawing.Size(266, 450);
            this.tvCountries.TabIndex = 0;
            this.tvCountries.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvCountries_BeforeSelect);
            this.tvCountries.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCountries_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvCountries);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbItems);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetAll);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 15;
            this.lbItems.Location = new System.Drawing.Point(3, 7);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(515, 379);
            this.lbItems.TabIndex = 4;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 386);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(309, 23);
            this.txtName.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(324, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(443, 415);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "about.bmp");
            this.imageList.Images.SetKeyName(1, "App.ico");
            this.imageList.Images.SetKeyName(2, "CollapseTree.bmp");
            this.imageList.Images.SetKeyName(3, "colors.ico");
            this.imageList.Images.SetKeyName(4, "DfIcon.ico");
            this.imageList.Images.SetKeyName(5, "ELEMENT.ICO");
            this.imageList.Images.SetKeyName(6, "EQUAL.ico");
            this.imageList.Images.SetKeyName(7, "exit.bmp");
            this.imageList.Images.SetKeyName(8, "ExpandTree.bmp");
            this.imageList.Images.SetKeyName(9, "favicon.ico");
            this.imageList.Images.SetKeyName(10, "FileOpen.bmp");
            this.imageList.Images.SetKeyName(11, "icon1.ico");
            this.imageList.Images.SetKeyName(12, "icon2-n[3].png");
            this.imageList.Images.SetKeyName(13, "ROOT.ICO");
            this.imageList.Images.SetKeyName(14, "Stop.bmp");
            // 
            // MainFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainFormUI";
            this.Text = "image";
            this.Load += new System.EventHandler(this.MainFormUI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tvCountries;
        private SplitContainer splitContainer1;
        private ImageList imageList;
        private Button btnGetAll;
        private Button btnClear;
        private TextBox txtName;
        private ListBox lbItems;
    }
}