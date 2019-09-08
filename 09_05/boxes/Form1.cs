using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boxes
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void draw()
        {
            Graphics g = pb.CreateGraphics();

            float size = Math.Min(pb.Width, pb.Height) / 5;

            SizeF box = new SizeF(size, size);

            PointF center = new PointF((pb.Width - size) / 2, (pb.Height - size) / 2);

            float top = center.Y - size;
            float bottom = center.Y + size;
            float left = center.X - size;
            float right = center.X + size;

            PointF tl = new PointF(left, top);
            PointF tr = new PointF(right, top);
            PointF bl = new PointF(left, bottom);
            PointF br = new PointF(right, bottom);

            RectangleF c = new RectangleF(center, box);
            RectangleF tlr = new RectangleF(tl, box);
            RectangleF trr = new RectangleF(tr, box);
            RectangleF blr = new RectangleF(bl, box);
            RectangleF brr = new RectangleF(br, box);


            RectangleF[] rects = { c, tlr, trr, blr, brr };

            g.Clear(Color.White);

            g.FillRectangles(Brushes.Black, rects);
        }

        private void draw(object sender, EventArgs e) => draw();

        private void draw(object sender, AsyncCompletedEventArgs e) => draw();
    }
}
