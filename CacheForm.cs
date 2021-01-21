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
    public partial class CacheForm : Form
    {
        public CacheForm()
        {
            InitializeComponent();
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            double c,m,h_m=0,h_h=0, h;
            if (!double.TryParse(textBox_cache_time.Text, out c))
            {
                textBox_res.Clear();
                return;
            }
            if (!double.TryParse(textBox_time.Text, out m))
            {
                textBox_res.Clear();
                return;
            }
            if (!double.TryParse(textBox_miss.Text, out h_m))
                if (!double.TryParse(textBox_hit.Text, out h_h))
                {
                    textBox_res.Clear();
                    return;
                }

            if (h_m > 0)
                h = h_m;
            else
                h = 1 - h_h;
            double res = c + h * m;
            textBox_res.Text = res.ToString();
        }
    }
}
