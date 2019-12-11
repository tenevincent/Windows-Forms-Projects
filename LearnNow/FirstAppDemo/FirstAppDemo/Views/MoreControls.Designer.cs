namespace FirstAppDemo.Views
{
    partial class MoreControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreControls));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(34, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to save the file";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.linkLabel2.Location = new System.Drawing.Point(34, 92);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(194, 24);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Click here to save the file!";
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FirstAppDemo.Properties.Resources.report_2_48_48;
            this.pictureBox1.Location = new System.Drawing.Point(466, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(466, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(213, 33);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bestellung_artikel.jpg");
            this.imageList1.Images.SetKeyName(1, "billing_status.gif");
            this.imageList1.Images.SetKeyName(2, "Croatian-Flag-icon-64.png");
            this.imageList1.Images.SetKeyName(3, "edit-12-48.gif");
            this.imageList1.Images.SetKeyName(4, "edit-blue-48.png");
            this.imageList1.Images.SetKeyName(5, "edit-blue-48we.png");
            this.imageList1.Images.SetKeyName(6, "edit-blue-48xx.png");
            this.imageList1.Images.SetKeyName(7, "french-big.png");
            this.imageList1.Images.SetKeyName(8, "help-orange-48.png");
            this.imageList1.Images.SetKeyName(9, "help-orange-48_old.png");
            this.imageList1.Images.SetKeyName(10, "italian-big.jpg");
            this.imageList1.Images.SetKeyName(11, "letter-r-24 (1).png");
            this.imageList1.Images.SetKeyName(12, "letter-r-24.png");
            this.imageList1.Images.SetKeyName(13, "letter-r-blue-16.png");
            this.imageList1.Images.SetKeyName(14, "list-32x32.png");
            this.imageList1.Images.SetKeyName(15, "remove-image-24.png");
            this.imageList1.Images.SetKeyName(16, "remove-image-24__.png");
            this.imageList1.Images.SetKeyName(17, "report-2-48-48.png");
            this.imageList1.Images.SetKeyName(18, "report-2-64-64.png");
            this.imageList1.Images.SetKeyName(19, "report-3-16.png");
            this.imageList1.Images.SetKeyName(20, "report-48x48,,,.png");
            this.imageList1.Images.SetKeyName(21, "report-48x48.png");
            this.imageList1.Images.SetKeyName(22, "report-48x48xx.png");
            this.imageList1.Images.SetKeyName(23, "report-48x4822.jpg");
            this.imageList1.Images.SetKeyName(24, "report-64x64.png");
            this.imageList1.Images.SetKeyName(25, "report-64x64xx.png");
            this.imageList1.Images.SetKeyName(26, "stones.png");
            this.imageList1.Images.SetKeyName(27, "Terrain_Yaounde.jpg");
            this.imageList1.Images.SetKeyName(28, "zahlung_artikel.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MoreControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "MoreControls";
            this.Size = new System.Drawing.Size(703, 425);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}
