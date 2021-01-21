using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArhiFucker
{
    public partial class RealBinForm : Form
    {
        public RealBinForm()
        {
            InitializeComponent();
        }

        private string ReverseString(string input) => new string(input.ToCharArray().Reverse().ToArray());

        private string ToBin(int n)
        {
            string res = "";
            while (n > 0)
            {
                res += (n % 2).ToString();
                n = n / 2;
            }
            return ReverseString(res);
        }

        private string MantToBin(double n, int length)
        {
            string res = "";
            for(int i=0; i < length; i++)
            {
                n = n * 2;
                if (n >= 1)
                {
                    res += "1";
                    n = n - 1;
                }
                else
                    res += "0";
            }
            return res;
        }

        private (int, int) SplitDouble(double w)
        {
            string s = w.ToString();
            var parts = s.Split(new char[] { '.', ',' });
            if (parts.Length == 1)
                return (int.Parse(parts[0]), 0);
            return (int.Parse(parts[0]), int.Parse(parts[1]));
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            int a, b;
            double w;
            if (!int.TryParse(textBox_int.Text, out a))
            {
                textBox_res.Clear();
                return;
            }
            if (!int.TryParse(textBox_real.Text, out b))
            {
                textBox_res.Clear();
                return;
            }
            if (!double.TryParse(textBox_word.Text, out w))
            {
                textBox_res.Clear();
                return;
            }

            (int wa, int wb) = SplitDouble(w);

            string sa = ToBin(wa);
            if (sa.Length > a)
            {
                textBox_res.Clear();
                return;
            }
            sa = ReverseString(sa);
            for (int i = sa.Length; i < a; i++)
                sa += "0";
            sa = ReverseString(sa);

            string sw = MantToBin(w - wa,b);
            textBox_res.Text = sa + sw;
        }
    }
}
