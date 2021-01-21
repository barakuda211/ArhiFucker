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
    public partial class TasksForm : Form
    {
        public TextBox[] tbs = new TextBox[10];

        public TasksForm()
        {
            InitializeComponent();
        }

        private void InitTablePanel()
        {
            for (int i = 0; i < 10; i++)
            {
                tbs[i] = new TextBox();
                tbs[i].Text = "";
                tbs[i].Dock = DockStyle.Fill;
                tbs[i].Parent = tableLayoutPanel;
                tableLayoutPanel.Controls.Add(tbs[i], i, 0);
                tbs[i].Show();
            }
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            InitTablePanel();
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            List<double> lst = new List<double>(10);
            for (int i =0; i<10; i++)
            {
                double x;
                if (tbs[i].Text == "")
                    continue;
                if (!double.TryParse(tbs[i].Text, out x))
                {
                    textBox_res.Text = "error";
                    return;
                }
                lst.Add(x);
            }
            lst.Sort();
            lst.Reverse();

            double res = 0;
            for (int i = 1; i <= lst.Count; i++)
            {
                res += lst[i - 1] * i;
            }

            res /= lst.Count;

            textBox_res.Text = res.ToString();
        }
    }
}
