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

namespace Kafka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen p = new Pen(Color.Black, 4);
        Pen z = new Pen(Color.Green, 4);
        Pen b = new Pen(Color.Brown, 4);
        SolidBrush az = new SolidBrush(Color.GreenYellow);
        SolidBrush ab = new SolidBrush(Color.SandyBrown);
        SolidBrush gr = new SolidBrush(Color.Gray);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point[] points = new Point [50];
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(200.0F, 50.0F);
            PointF point3 = new PointF(250.0F, 200.0F);
            PointF point4 = new PointF(50.0F, 150.0F);
            PointF[] points2 = { point1, point2, point3, point4 };
            FillMode newFillMode = FillMode.Winding;
            g.FillClosedCurve(gr, points2, newFillMode, 1.0F);
            g.DrawLine(z, 50, 50, 200, 50);
            g.DrawLine(z, 200, 50, 200, 100);
            g.DrawLine(z, 50, 50, 50, 100);
            g.DrawLine(z, 50, 100, 200, 100);
            g.DrawLine(b, 50, 100, 50, 200);
            g.DrawLine(b, 50, 200, 200, 200);
            g.DrawLine(b, 200, 200, 200, 100);
            g.FillRectangle(az, 55, 55, 140, 40);
            g.FillRectangle(ab, 55, 105, 140, 90);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
