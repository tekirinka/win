using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HW
{
    public partial class Form : System.Windows.Forms.Form
    {
        Graphics g;
        Pen pen = (Pen)Pens.Black.Clone();
        Pen pen1 = (Pen)Pens.Green.Clone();
        float size = 0;
        public Form()
        {
            InitializeComponent();
            pen.Width = pen1.Width = 5;
        }

        private void circleWithSquare()
        {
            visible(false, false, false, true);

            float p = pen.Width;
            SizeF s = new SizeF(size, size);
            PointF tl = new PointF(p, p);
            PointF t = new PointF(size / 2, p);
            PointF b = new PointF(size / 2, size);
            PointF l = new PointF(p, size / 2);
            PointF r = new PointF(size, size / 2);
            PointF[] points = { t, r, b, l, t };

            RectangleF circle = new RectangleF(tl, s);

            clear();

            g.DrawEllipse(pen, circle);
            g.DrawLines(pen, points);
        }

        private void squareWithCircle()
        {
            visible(true, false, false, true);

            float size;
            if (!float.TryParse(tb1.Text, out size)) size = Math.Min(pb.Width, pb.Height);
            if (size == 0) size = Math.Min(pb.Width, pb.Height);

            float innerSize = size / (float)Math.Sqrt(2);

            PointF tl = new PointF(1, 1);
            PointF itl = new PointF((size - innerSize) / 2, (size - innerSize) / 2);
            SizeF inner = new SizeF(innerSize, innerSize);
            SizeF outer = new SizeF(size, size);

            RectangleF innerRect = new RectangleF(itl, inner);
            RectangleF outaRect = new RectangleF(tl, outer);
            RectangleF[] rects = { innerRect, outaRect };

            clear();
            g.DrawRectangles(pen, rects);
            g.DrawEllipse(pen, outaRect);
        }
        private void circles1()
        {
            visible(false, false, false, true);

            int c = 5;
            float s = pb.Width / c;

            clear();
            for (int i = 0; i < c; i++)
                g.DrawEllipse(pen, s * i, (pb.Height - s) / 2, s, s);
        }
        private void star()
        {
            visible(false, false, false, true);

            PointF[] points = new PointF[5];
            float center = size / 2;
            for (int i = 0; i < points.Length; i++)
            {
                float x = center * (float)Math.Cos(2 * Math.PI / points.Length * (i - 0.25)) + center;
                float y = center * (float)Math.Sin(2 * Math.PI / points.Length * (i - 0.25)) + center;
                points[i] = new PointF(x, y);
            }

            PointF[] points1 = new PointF[points.Length + 1];
            for (int i = 0; i < points.Length; i++)
            {
                points1[i] = points[(i * 2) % points.Length];
            }

            points1[points.Length] = points[0];

            clear();

            g.DrawLines(pen, points1);
        }
        private void lines()
        {
            visible(true, false, false, true);

            int c;
            if (!int.TryParse(tb1.Text, out c)) c = 5;
            if (c <= 0) c = 5;

            clear();

            for (int i = 1; i <= c; i++)
                g.DrawLine(pen, new PointF(0, pb.Height / c * i), new PointF(pb.Width / c * i, 0));
        }
        private void rects()
        {
            visible(false, false, false, true);

            int c;
            if (!int.TryParse(tb1.Text, out c)) c = 5;
            if (c <= 0) c = 5;

            float w = pb.Width / c;
            float h = pb.Height / c;

            clear();

            for (int i = 0; i < c; i++)
                g.DrawRectangle(pen, w * i, h * i, w, h);
        }

        private void grid()
        {
            visible(true, true, false, true);

            int n, m;
            if (!int.TryParse(tb1.Text, out n)) n = 5;
            if (n <= 0) n = 5;
            if (!int.TryParse(tb2.Text, out m)) m = 5;
            if (m <= 0) m = 5;

            float w = pb.Width / (m + 1);
            float h = pb.Height / (n + 1);

            clear();

            for (int i = 1; i <= m; i++)
                g.DrawLine(pen, w * i, 0, w * i, pb.Height);
            for (int i = 1; i <= n; i++)
                g.DrawLine(pen, 0, h * i, pb.Width, h * i);
        }
        private void circles2()
        {
            visible(true, false, false, true);

            int c;
            if (!int.TryParse(tb1.Text, out c)) c = 5;
            if (c <= 0) c = 5;
            float s = pb.Width / c;

            clear();
            for (int i = 0; i < c; i++)
                g.DrawEllipse(pen, s * i, (pb.Height - s) / 2, s, s);
            for (int i = 1; i < c; i++)
                g.DrawEllipse(pen1, s * i - s / 2, (pb.Height - s) / 2, s, s);
        }
        private void numbers()
        {
            visible(true, true, true, false);

            int k, n;
            if (!int.TryParse(tb1.Text, out k)) k = 0;
            if (k <= 0) k = 0;
            if (!int.TryParse(tb2.Text, out n)) n = 5;
            if (n <= 0) n = 5;

            lb.Items.Clear();
            for (int i = k; i <= n; i++)
                lb.Items.Add(i);
        }
        private void squareSum()
        {
            visible(true, true, true, false);

            int a, b;
            if (!int.TryParse(tb1.Text, out a)) a = 0;
            if (a <= 0) a = 0;
            if (!int.TryParse(tb2.Text, out b)) b = 5;
            if (b <= 0) b = 5;

            int sum = 0;
            for (int i = a; i <= b; i++)
                sum += i * i;
            lb.Items.Clear();
            lb.Items.Add(sum);
        }
        private void sum1()
        {
            visible(true, false, true, false);

            int n;
            if (!int.TryParse(tb1.Text, out n)) n = 0;
            if (n <= 0) n = 0;

            float sum = 0;
            for (float i = 1; i <= n; i++)
                sum += 1 / i;
            sum = (float)Math.Round(sum, 2);
            lb.Items.Clear();
            lb.Items.Add(sum);
        }
        private void sum2()
        {
            visible(true, false, true, false);

            int n;
            if (!int.TryParse(tb1.Text, out n)) n = 0;
            if (n <= 0) n = 0;

            float sum = 0;
            for (float i = 1; i <= n * 2; i++)
                if (i % 2 == 0)
                    sum -= 1 / i;
                else
                    sum += 1 / i;
            sum = (float)Math.Round(sum, 2);
            lb.Items.Clear();
            lb.Items.Add(sum);
        }
        private void sum3()
        {
            visible(true, true, true, false);

            int n, b;
            if (!int.TryParse(tb1.Text, out n)) n = 0;
            if (n <= 0) n = 0;
            if (!int.TryParse(tb2.Text, out b)) b = 5;
            if (b <= 0) b = 5;

            float sum = 0;
            for (float i = 1; i < n * 2 + 1; i += 2)
                sum += (float)Math.Pow(b, i) / i;
            sum = (float)Math.Round(sum, 2);
            lb.Items.Clear();
            lb.Items.Add(sum);
        }
        private void sum4()
        {
            visible(true, false, true, false);

            int n;
            if (!int.TryParse(tb1.Text, out n)) n = 0;
            if (n <= 0) n = 0;

            float sum = 0;
            for (float i = 0; i < n; i++)
                if (i % 2 == 0)
                    sum -= (float)Math.Pow(2, i);
                else
                    sum += (float)Math.Pow(2, i);
            sum = (float)Math.Round(sum, 2);
            lb.Items.Clear();
            lb.Items.Add(sum);
        }
        private void factorial()
        {
            visible(true, false, true, false);

            int n;
            if (!int.TryParse(tb1.Text, out n)) n = 5;
            if (n <= 0) n = 5;


            float pow = 1;
            for (float i = 1; i <= n; i++)
                pow *= i;
            lb.Items.Clear();
            lb.Items.Add(pow);
        }
        private void cosinus()
        {
            visible(true, true, true, false);

            int x, n;
            if (!int.TryParse(tb1.Text, out x)) x = 0;
            if (x <= 0) x = 0;
            if (!int.TryParse(tb2.Text, out n)) n = 5;
            if (n <= 0) n = 5;

            float sum = x;
            for (float i = 1; i <= n; i++)
                sum = (float)Math.Cos(sum);
            sum = (float)Math.Round(sum, 2);
            lb.Items.Clear();
            lb.Items.Add(sum);
        }

        private void line()
        {
            visible(true, false, false, true);

            float alfa;
            if (!float.TryParse(tb1.Text, out alfa)) alfa = 90;
            alfa = alfa * (float)Math.PI / (float)180.0;

            float center = size / 2;

            clear();
            g.DrawEllipse(pen, 0, 0, size, size);
            g.DrawLine(pen, center, center, center * (float)Math.Cos(alfa) + center, -1 * center * (float)Math.Sin(alfa) + center);
        }

        private void draw()
        {
            switch (cb.SelectedIndex)
            {
                case 0:
                    circleWithSquare();
                    break;
                case 1:
                    squareWithCircle();
                    break;
                case 2:
                    circles1();
                    break;
                case 3:
                    star();
                    break;
                case 4:
                    lines();
                    break;
                case 5:
                    rects();
                    break;
                case 6:
                    grid();
                    break;
                case 7:
                    circles2();
                    break;
                case 8:
                    numbers();
                    break;
                case 9:
                    squareSum();
                    break;
                case 10:
                    sum1();
                    break;
                case 11:
                    sum2();
                    break;
                case 12:
                    sum3();
                    break;
                case 13:
                    sum4();
                    break;
                case 14:
                    factorial();
                    break;
                case 15:
                    cosinus();
                    break;
                case 16:
                    line();
                    break;
                default:
                    MessageBox.Show("Select item please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void resize()
        {
            g = pb.CreateGraphics();
            pb.Left = lb.Left = 0;
            pb.Top = lb.Top = 0;
            pb.Width = lb.Width = flp.Left - 8;
            pb.Height = lb.Height = Height - 16;
            size = Math.Min(pb.Width, pb.Height) - 5;
            draw();
        }

        private void clear() => g.Clear(Color.White);
        private void visible(bool t1, bool t2, bool l, bool p)
        {
            tb1.Visible = t1;
            tb2.Visible = t2;
            lb.Visible = l;
            pb.Visible = p;
        }

        private void resize(object sender, EventArgs e) => resize();
        private void resize(object o, LayoutEventArgs e) => resize();
        private void draw(object o, EventArgs e) => draw();
        private void draw(object o, LayoutEventArgs e) => draw();
    }
}
