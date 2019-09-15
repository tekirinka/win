using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lines1
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

            Pen[] pens = {
                (Pen)Pens.Red.Clone(),
                (Pen)Pens.Orange.Clone(),
                (Pen)Pens.Yellow.Clone(),
                (Pen)Pens.Green.Clone(),
                (Pen)Pens.Blue.Clone(),
                (Pen)Pens.DarkBlue.Clone(),
                (Pen)Pens.Purple.Clone()
            };

            for (int i = 0; i < pens.Length; i++)
            {
                pens[i].Width = 5;
            }

            int count;
            if (!int.TryParse(tb.Text, out count)) count = 7;
            if (count <= 0) count = 7;

            Size s = new Size(pb.Width / count, pb.Height / count);

            Graphics g = pb.CreateGraphics();
            g.Clear(Color.White);

            for (int i = 1; i <= count; i++)
            {
                g.DrawLine(pens[(i - 1) % pens.Length], s.Width * i, 0, 0, s.Height * i);
            }
        }
        private void draw(object o, EventArgs e) => draw();
        private void draw(object o, LayoutEventArgs e) => draw();

        private void draw(object sender, AsyncCompletedEventArgs e) => draw();
    }
}
