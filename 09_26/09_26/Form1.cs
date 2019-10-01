using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_26
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            cb.Items.AddRange(new object[]{
                "Банк",
                "Банк 2",
                "Банк 3",
                "Город",
                "Бактерии",
                "Рабочий",
                "Таблица умножения",
                "Делители числа",
                "Сумма цифр",
                "Квадрат числа",
                "Танцы"
            });
            cb.SelectedIndex = 0;
        }
        private void bank()
        {
            visible("S", "r", "N");
            double S, r, n, Sinit;
            if (!double.TryParse(tb1.Text, out S) || S <= 0) S = 100;
            if (!double.TryParse(tb2.Text, out r) || r <= 0) r = 5;
            if (!double.TryParse(tb3.Text, out n) || n <= 0) n = 5;
            Sinit = S;
            lb.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                lb.Items.Add("Year " + (i + 1) + ": " + S);
                S += Math.Round(S * r / 100, 2);
            }
            lb.Items.Add("Year " + n + ": " + S);

            lb.Items.Add("Total: " + S);
            lb.Items.Add("Added: " + (S - Sinit));
        }
        private void bank2()
        {
            visible("S", "r", "N");
            double S, r, n, Sinit;
            if (!double.TryParse(tb1.Text, out S) || S <= 0) S = 100;
            if (!double.TryParse(tb2.Text, out r) || r <= 0) r = 5;
            if (!double.TryParse(tb3.Text, out n) || n <= 0) n = 5;
            Sinit = S;
            lb.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                lb.Items.Add("Year " + i + ": " + S);
                S *= r;
            }
            lb.Items.Add("Year " + n + ": " + S);
            lb.Items.Add("Total: " + S);
            lb.Items.Add("Added: " + (S - Sinit));
        }
        private void bank3()
        {
            visible("S", "r", "");
            double S, r, n = 12, Sinit;
            if (!double.TryParse(tb1.Text, out S) || S <= 0) S = 100;
            if (!double.TryParse(tb2.Text, out r) || r <= 0) r = 5;
            //if (!double.TryParse(tb3.Text, out n) || n <= 0) n = 5;
            Sinit = S;
            lb.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                lb.Items.Add("Month " + i + ": " + S);
                S += Math.Round(S * r / 100, 2);
            }
            lb.Items.Add("Month " + n + ": " + S);

            lb.Items.Add("Total: " + S);
            lb.Items.Add("Added: " + (S - Sinit));
        }
        private void city()
        {
            visible("N", "k", "");
            double S, r, n = 16, Sinit;
            if (!double.TryParse(tb1.Text, out S) || S <= 0) S = 100;
            if (!double.TryParse(tb2.Text, out r) || r <= 0) r = 5;
            //if (!double.TryParse(tb3.Text, out n) || n <= 0) n = 5;
            Sinit = S;
            lb.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                lb.Items.Add("Year " + (i + 2000) + ": " + (S * 1000));
                S += Math.Round(S * r / 100, 2);
            }
            lb.Items.Add("Year " + (n + 2000) + ": " + (S * 1000));

            lb.Items.Add("Total: " + (S * 1000));
            lb.Items.Add("Added: " + ((S - Sinit) * 1000));
        }
        private void bacteries()
        {
            visible("k", "t", "n");
            int k, t, n;
            if (!int.TryParse(tb1.Text, out k) || k <= 0) k = 10;
            if (!int.TryParse(tb2.Text, out t) || t <= 0) t = 5;
            if (!int.TryParse(tb3.Text, out n) || n <= 0) n = 5;

            lb.Items.Clear();

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += k * sum;
                lb.Items.Add(sum);
                sum -= t;
            }
        }
        private void worker()
        {
            visible("A", "d", "k");

            int A, d, k;
            if (!int.TryParse(tb1.Text, out A) || A <= 0) A = 10;
            if (!int.TryParse(tb2.Text, out d) || d <= 0) d = 5;
            if (!int.TryParse(tb3.Text, out k) || k <= 0) k = 5;

            int work = 0;

            lb.Items.Clear();

            for (int i = 0; i < k; i++)
            {
                lb.Items.Add("Hour " + i + ": " + work);
                work += A + d * i;
            }
            lb.Items.Add("Hour " + k + ": " + work);
        }
        private void multable()
        {
            visible("N", "", "");

            if (!int.TryParse(tb1.Text, out int n) || n < 0 || n > 10) n = 5;

            lb.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                lb.Items.Add(n + " * " + i + " = " + n * i);
            }
        }
        private void divisors()
        {
            visible("n", "", "");
            if (!int.TryParse(tb1.Text, out int n) || n < 0 || n > 10) n = 12;

            int count = 0, ecount = 0;

            lb.Items.Clear();

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    count++;
                    if (i % 2 == 0) ecount++;
                    lb.Items.Add(i);
                }
            }
            lb.Items.Add("Total divisors: " + count);
            lb.Items.Add("Even divisors: " + ecount);
        }
        private void sumofnums()
        {
            visible("n", "", "");
            if (!int.TryParse(tb1.Text, out int n) || n < 0 || n > 10) n = -1;
            lb.Items.Clear();

            for (int i = 1; i <= 9; i++)
                for (int j = 1; j <= 9; j++)
                {
                    if (i + j == n) lb.Items.Add(i * 10 + j);
                }
        }
        private void sqr()
        {
            visible("n", "", "");
            if (!int.TryParse(tb1.Text, out int n) || n < 0 || n > 10) n = -1;
            lb.Items.Clear();

            for (int i = 0; i <= n; i++)
            {
                if (i * i == n)
                {
                    lb.Items.Add(i);
                }
            }
        }
        private void dance()
        {
            visible("n", "", "");
            if (!int.TryParse(tb1.Text, out int n) || n < 0 || n > 10) n = -1;
            lb.Items.Clear();

            if (n % 2 == 1)
                lb.Items.Add("ERROR");
            else
            {
                int s = 0;
                while ((n /= 2) >= 1) s++;
                lb.Items.Add(s);
            }
        }
        private void draw()
        {
            switch (cb.SelectedIndex)
            {
                case 0:
                    bank();
                    break;
                case 1:
                    bank2();
                    break;
                case 2:
                    bank3();
                    break;
                case 3:
                    city();
                    break;
                case 4:
                    bacteries();
                    break;
                case 5:
                    worker();
                    break;
                case 6:
                    multable();
                    break;
                case 7:
                    divisors();
                    break;
                case 8:
                    sumofnums();
                    break;
                case 9:
                    sqr();
                    break;
                case 10:
                    dance();
                    break;
                default:
                    break;
            }
        }
        private void resize()
        {
            lb.Width = flp.Left - 8;
            draw();
        }
        private void visible(string a, string b, string c)
        {
            label1.Text = a;
            label2.Text = b;
            label3.Text = c;
            label1.Visible = tb1.Visible = a.Length > 0;
            label2.Visible = tb2.Visible = b.Length > 0;
            label3.Visible = tb3.Visible = c.Length > 0;
        }
        private void draw(object o, EventArgs e) => draw();
        private void draw(object o, LayoutEventArgs e) => draw();
        private void resize(object o, EventArgs e) => resize();
        private void resize(object o, LayoutEventArgs e) => resize();
    }
}
