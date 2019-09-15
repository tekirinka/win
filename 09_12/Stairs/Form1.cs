using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_12
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void draw()
        {
            canvas.Height = flp.Top - 8;
            Graphics g = canvas.CreateGraphics();
            Brush[] brushes = {
                Brushes.Red,
                Brushes.Orange,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Blue,
                Brushes.DarkBlue,
                Brushes.DarkViolet
            };
            Pen[] pens =
            {
                Pens.Red,
                Pens.Orange,
                Pens.Yellow,
                Pens.Green,
                Pens.Blue,
                Pens.DarkBlue,
                Pens.DarkViolet
            };

            int steps;
            if (!int.TryParse(tbRect.Text, out steps)) steps = 7;
            if (steps == 0) steps = 7;
            float w = canvas.Width / steps, h = canvas.Height / steps;
            g.Clear(Color.White);
            for (int i = 0; i < steps; i++)
            {
                g.FillRectangle(brushes[i % brushes.Length], w * i, h * i, w, h);
                g.DrawRectangle(pens[i % brushes.Length], canvas.Width - w * (i + 1), h * i, w, h);
            }
        }
        private void draw(object sender, EventArgs e) => draw();

        private void draw(object sender, LayoutEventArgs e) => draw();
    }
}
