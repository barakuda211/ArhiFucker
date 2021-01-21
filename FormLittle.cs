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
    public partial class FormLittle : Form
    {
        public FormLittle()
        {
            InitializeComponent();
        }

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

        private string ReverseString(string input) => new string(input.ToCharArray().Reverse().ToArray());


        private void button_solve_Click(object sender, EventArgs e)
        {
            int bit, size, word;
            if (!int.TryParse(textBox_sizebit.Text, out bit))
            {
                textBox_res.Clear();
                return;
            }
            if (!int.TryParse(textBox_size.Text, out size))
            {
                textBox_res.Clear();
                return;
            }
            if (!int.TryParse(textBox_word.Text, out word))
            {
                textBox_res.Clear();
                return;
            }

            string bin = ToBin(word);

            if (bin.Length > bit*size)
            {
                textBox_res.Clear();
                return;
            }
            bin = ReverseString(bin);
            for (int i = bin.Length; i < bit * size; i++)
                bin += "0";
            bin = ReverseString(bin);

            if (!checkBox.Checked)
            {
                textBox_res.Text = bin;
                return;
            }

            int k = 0;
            List<string> lst = new List<string>(3);
            for (int i = 0; i < size; i++)
            {
                lst.Add(bin.Substring(k, bit));
                k += bit;
            }
            lst.Reverse();

            string res = "";
            foreach (var x in lst)
                res += x;

            textBox_res.Text = res;
        }
    }
}
