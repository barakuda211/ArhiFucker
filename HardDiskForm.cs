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
    public partial class HardDiskForm : Form
    {
        public HardDiskForm()
        {
            InitializeComponent();
        }

        private int Less2n(int n)
        {
            int res = 1;
            while (res < n)
                res *= 2;
            return res;
        }

        private int Less2n_n(int n)
        {
            int res = 1;
            int k = 0;
            while (res < n)
            {
                res *= 2;
                k++;
            }
            return k;
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            int a, b, c;
            if (!int.TryParse(textBox_a.Text, out a))
            {
                textBox_res1.Clear();
                textBox_res2.Clear();
                return;
            }
            if (!int.TryParse(textBox_b.Text, out b))
            {
                textBox_res1.Clear();
                textBox_res2.Clear();
                return;
            }
            if (!int.TryParse(textBox_c.Text, out c))
            {
                textBox_res1.Clear();
                textBox_res2.Clear();
                return;
            }

            var sz = a * b * c * 512;
            textBox_res2.Text = sz.ToString();

            a = Less2n(a);
            b = Less2n(b);
            c = Less2n(c);

            sz = a * b * c;

            int k = Less2n_n(sz);
            textBox_res1.Text = k.ToString();
        }
    }
}
