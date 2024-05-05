using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Web.WebView2.WinForms;
namespace Lab04_4
{
    public partial class ChiTiet : Form
    {
        public ChiTiet()
        {
            InitializeComponent();
        }
        public string Trang { get; set; }

        private void ChiTiet_Load(object sender, EventArgs e)
        {
            UrlChiTiet(sender, e);
            webView21.Source = new Uri(Trang);
        }

        private void UrlChiTiet(object sender, EventArgs e)
        {
            Text = Trang;
        }
    }
}
