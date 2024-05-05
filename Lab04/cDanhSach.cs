using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class cDanhSach : Form
    {
        public cDanhSach()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cBai1 bai1 = new cBai1();
            bai1.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cBai2 bai2 = new cBai2();
            bai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
