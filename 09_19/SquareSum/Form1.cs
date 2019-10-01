using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareSum
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(tbA.Text, out a)) a = 1;
            if (!int.TryParse(tbB.Text, out b)) b = 10;
            int sum = 0;
            for (int i = a; i < b; i++)
                sum += i * i;
            lOut.Text = "Sum: " + sum;
        }
    }
}
