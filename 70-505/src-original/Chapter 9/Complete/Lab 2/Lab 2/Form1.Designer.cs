namespace WindowsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtChapterName = new System.Windows.Forms.TextBox();
            this.txtChapterText = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnViewXml = new System.Windows.Forms.Button();
            this.btnAddChapter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chapter Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chapter Text";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(94, 21);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(196, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(94, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(196, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 107);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtChapterName
            // 
            this.txtChapterName.Location = new System.Drawing.Point(94, 146);
            this.txtChapterName.Name = "txtChapterName";
            this.txtChapterName.Size = new System.Drawing.Size(196, 20);
            this.txtChapterName.TabIndex = 8;
            // 
            // txtChapterText
            // 
            this.txtChapterText.Location = new System.Drawing.Point(94, 182);
            this.txtChapterText.Multiline = true;
            this.txtChapterText.Name = "txtChapterText";
            this.txtChapterText.Size = new System.Drawing.Size(196, 93);
            this.txtChapterText.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(16, 281);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(274, 119);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chapter #";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chapter Title";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chapter Text";
            this.columnHeader3.Width = 95;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(318, 19);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 11;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(318, 63);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(75, 23);
            this.btnLoadXml.TabIndex = 12;
            this.btnLoadXml.Text = "Load Xml";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // btnViewXml
            // 
            this.btnViewXml.Location = new System.Drawing.Point(318, 105);
            this.btnViewXml.Name = "btnViewXml";
            this.btnViewXml.Size = new System.Drawing.Size(75, 23);
            this.btnViewXml.TabIndex = 13;
            this.btnViewXml.Text = "View Xml";
            this.btnViewXml.UseVisualStyleBackColor = true;
            this.btnViewXml.Click += new System.EventHandler(this.btnViewXml_Click);
            // 
            // btnAddChapter
            // 
            this.btnAddChapter.Location = new System.Drawing.Point(318, 180);
            this.btnAddChapter.Name = "btnAddChapter";
            this.btnAddChapter.Size = new System.Drawing.Size(75, 23);
            this.btnAddChapter.TabIndex = 14;
            this.btnAddChapter.Text = "Add Chapter";
            this.btnAddChapter.UseVisualStyleBackColor = true;
            this.btnAddChapter.Click += new System.EventHandler(this.btnAddChapter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bookstore.xml | BookStore.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 424);
            this.Controls.Add(this.btnAddChapter);
            this.Controls.Add(this.btnViewXml);
            this.Controls.Add(this.btnLoadXml);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtChapterText);
            this.Controls.Add(this.txtChapterName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "New Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtChapterName;
        private System.Windows.Forms.TextBox txtChapterText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Button btnViewXml;
        private System.Windows.Forms.Button btnAddChapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

