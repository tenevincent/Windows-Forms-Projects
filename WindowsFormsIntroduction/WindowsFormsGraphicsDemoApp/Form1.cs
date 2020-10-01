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

namespace WindowsFormsGraphicsDemoApp
{
    public partial class Form1 : Form
    {
        [Serializable()]
        class Line
        {
            public Point From, To;
        }


        public Form1()
        {
            InitializeComponent();
        }

        List<Line> lstLines = new List<Line>();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Line ln in lstLines)
                g.DrawLine(Pens.Blue, ln.From, ln.To);


            // DranwCanvas(e);

        }

        private void DranwCanvas(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int w, h;
            w = this.ClientSize.Width;
            h = this.ClientSize.Height;
            Pen p = new Pen(Color.Red);
            g.DrawArc(p, w / 2 - 50, h / 2 - 40, 100, 80, 0, 45);
            p.Dispose();
            p = new Pen(Color.Green);
            g.DrawRectangle(p, w / 2 - 50, h / 2 - 40, 100, 80);
            g.DrawLine(p, 0, 0, w, h);
            g.DrawLine(p, 0, h, w, 0);
            Point[] pts = new Point[3];
            pts[0].X = w / 2;
            pts[0].Y = h / 2 - 50;
            pts[1].X = w / 2 + 50;
            pts[1].Y = h / 2 + 50;
            pts[2].X = w / 2 - 50;
            pts[2].Y = h / 2 + 50;
            g.DrawPolygon(p, pts);



            Brush br; //Brush is an abstract class.
            Color col = Color.FromArgb(50, 255, 127, 12);
            col = Color.FromName("brown");//.FromKnownColor(KnownColor.InactiveCaption);
            br = new SolidBrush(col);
            g.FillEllipse(br, 10, 10, 100, 100);
            br = new HatchBrush(HatchStyle.DashedHorizontal, Color.Yellow, Color.Red);
            g.FillEllipse(br, 30, 30, 50, 50);
            Image img = new Bitmap(@"E:\DevGit\WinformsProjects\WindowsFormsIntroduction\WindowsFormsFromUdemy\Resources\\user-512.png");
            g.DrawImage(img, 200, 0);
            br = new TextureBrush(img);
            g.FillEllipse(br, 80, 80, 200, 240);
            g.TranslateTransform(w / 2, h / 2); //To shift the origin
            g.RotateTransform(-30);
            g.ScaleTransform(2, 2); //Zooming
            Point p1 = new Point();
            Point p2 = new Point();
            p1.X = 20; p1.Y = 30; p2.X = 100; p2.Y = 100;
            br = new LinearGradientBrush(p1, p2, Color.Red, Color.Blue); ;
            g.FillRectangle(br, 20, 30, 70, 70);
            g.ResetTransform();

            Font f = new Font("Arial", 24, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Hello", f, br, 200, 10);
            g.PageUnit = GraphicsUnit.Inch;
            p = new Pen(Color.Red, 0.2F);
            g.ResetTransform();
            g.DrawRectangle(p, 0.5F, 0.5F, 1, 2);
        }
    }
}
