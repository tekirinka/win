using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_19
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private ListWithSumAndAvg sequence(int min, int max, int step)
        {
            List<object> c = new List<object>();
            if (min < max)
            {
                for (int i = min; i <= max; i += step)
                    c.Add(i);
            }
            else
            {
                for (int i = min; i >= max; i -= step)
                    c.Add(i);
            }
            return new ListWithSumAndAvg(c);
        }

        private void fill()
        {
            layout();
            int min = 6, max = 20, step = 1;
            if (!int.TryParse(tbK.Text, out min)) min = 6;
            if (!int.TryParse(tbN.Text, out max)) max = 20;
            if (!int.TryParse(tbStep.Text, out step)) step = 1;
            if (step == 0) step = 1;
            if (step < 0) step = -step;
            ListWithSumAndAvg c = sequence(min, max, step);
            lb.Items.Clear();
            lb.Items.AddRange(c.list.ToArray());
            lb.Items.Add("Summ: " + c.Sum);
            lb.Items.Add("Avg: " + c.Avg);
        }

        private void layout()
        {
            lb.Height = flp.Top - 8;
        }

        private void layout(object sender, EventArgs e) => layout();
        private void layout(object sender, LayoutEventArgs e) => layout();
        private void fill(object sender, EventArgs e) => fill();
    }
    public class ListWithSumAndAvg
    {
        public ListWithSumAndAvg(List<object> newList) => list = newList;
        public List<object> list;
        public double Avg
        {
            get
            {
                if (list.Count == 0) return -1;
                return Math.Round((double)Sum / list.Count, 2);
            }
        }

        public int Sum
        {
            get
            {
                if (list.Count == 0) return 0;
                int sum = 0;
                for (int i = 0; i < list.Count; i++) sum += (int)list[i];
                return sum;
            }
        }
    }
}
