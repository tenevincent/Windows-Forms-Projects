using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithGraphicsApp
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int w, h;
            w = this.ClientSize.Width;
            h = this.ClientSize.Height;
            Pen pen = new Pen(Color.Red);
            graphics.DrawArc(pen, w / 2 - 50, h / 2 - 40, 100, 80, 0, 45);
            pen.Dispose();
            pen = new Pen(Color.Green);

            graphics.DrawRectangle(pen, w / 2 - 50, h / 2 - 40, 100, 80);
            graphics.DrawLine(pen, 0, 0, w, h);
            graphics.DrawLine(pen, 0, h, w, 0);
            Point[] pts = new Point[3];
            pts[0].X = w / 2;
            pts[0].Y = h / 2 - 50;
            pts[1].X = w / 2 + 50;
            pts[1].Y = h / 2 + 50;
            pts[2].X = w / 2 - 50;
            pts[2].Y = h / 2 + 50;
            graphics.DrawPolygon(pen, pts);

            var rectangle = new Rectangle(w-120,040,100,200);
            graphics.DrawRectangle(pen,rectangle);
 



            Brush br; //Brush is an abstract class.
           // Color col = Color.FromArgb(50, 255, 127, 12);
            var col = Color.FromName("brown");//.FromKnownColor(KnownColor.InactiveCaption);
            br = new SolidBrush(col);
            graphics.FillEllipse(br, 10, 10, 100, 100);
            br = new HatchBrush(HatchStyle.DashedHorizontal, Color.Yellow, Color.Red);
            graphics.FillEllipse(br, 30, 30, 50, 50);
            Image img = new Bitmap(WorkingWithGraphicsApp.Resources.edit_32);
            graphics.DrawImage(img, 200, 0);
            br = new TextureBrush(img);
            graphics.FillEllipse(br, 80, 80, 200, 240);
            graphics.TranslateTransform(w / 2, h / 2); //To shift the origin
            graphics.RotateTransform(-30);
            graphics.ScaleTransform(2, 2); //Zooming
            Point p1 = new Point();
            Point p2 = new Point();
            p1.X = 20; p1.Y = 30; p2.X = 100; p2.Y = 100;
            br = new LinearGradientBrush(p1, p2, Color.Red, Color.Blue); ;
            graphics.FillRectangle(br, 20, 30, 70, 70);
            graphics.ResetTransform();
            Font f = new Font("Arial", 24, FontStyle.Bold | FontStyle.Italic);
            graphics.DrawString("Hello", f, br, 200, 10);
            graphics.PageUnit = GraphicsUnit.Inch;
            pen = new Pen(Color.Red, 0.2F);
            graphics.ResetTransform();
            graphics.DrawRectangle(pen, 0.5F, 0.5F, 1, 2);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
