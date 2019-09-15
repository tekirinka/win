using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galka
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void draw()
        {
            pb.Height = flp.Top - 8;

            Graphics g = pb.CreateGraphics();

            int steps;
            if (!int.TryParse(textBox1.Text, out steps) || steps == 0) steps = 7;
            if (steps == 0) steps = 7;

            float w = pb.Width / steps, h = pb.Height / steps;

            g.Clear(Color.White);
            for (int i = 0; i < steps / 2; i++) g.FillRectangle(Brushes.Black, w * i, h * i, w, h);
            for (int j = steps / 2; j < steps; j++) g.FillRectangle(Brushes.Black, w * j, h * steps - h * j - h, w, h);
        }
        private void draw(object o, EventArgs e) => draw();
        private void draw(object o, LayoutEventArgs e) => draw();
    }
}
