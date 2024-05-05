using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab04_4.TrangChu;

namespace Lab04_4
{
    public partial class MyControl : UserControl
    {
        public TrangChu trangChu;
        public string tenphim
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string hinhanh
        {
            get { return pictureBox1.Text; }
            set { pictureBox1.Text = value; }
        }

        public string chitiet
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public MyControl()
        {
            InitializeComponent();
            

        }

        private ChiTiet chiTiet;

        private void MyControl_Load(object sender, EventArgs e)
        {
            label1.Text = tenphim;
            label2.Text = chitiet;
            pictureBox1.ImageLocation = hinhanh;

            chiTiet= new ChiTiet();
            chiTiet.Trang = chitiet;
            
        }
        
        private void Mouse_Click (object sender, MouseEventArgs e)
        {
            
            chiTiet.Show();
        }
    }
}
