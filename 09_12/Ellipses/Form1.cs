using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lines
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

            int steps = 0;
            if (!int.TryParse(tb.Text, out steps)) steps = 7;
            if (steps == 0) steps = 7;

            float w = pb.Width / steps, h = pb.Height / 3;

            Brush[] brushes =
            {

            };

            Graphics g = pb.CreateGraphics();
            g.Clear(Color.White);

            for (int i = 0; i < steps; i++) g.FillEllipse(Brushes.Black, w * i, (pb.Height - h) / 2, w, h);
        }
        private void draw(object o, EventArgs e) => draw();
        private void draw(object o, LayoutEventArgs e) => draw();
    }
}
