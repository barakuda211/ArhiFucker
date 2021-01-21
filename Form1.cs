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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_cache_Click(object sender, EventArgs e)
        {
            var f = new CacheForm();
            f.Show();
        }

        private void button_littlebig_Click(object sender, EventArgs e)
        {
            var f = new FormLittle();
            f.Show();
        }

        private void button_toreal_Click(object sender, EventArgs e)
        {
            var f = new RealBinForm();
            f.Show();
        }

        private void button_hdd_Click(object sender, EventArgs e)
        {
            var f = new HardDiskForm();
            f.Show();
        }

        private void button_tasks_Click(object sender, EventArgs e)
        {
            var f = new TasksForm();
            f.Show();
        }
    }
}
