using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace @new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string url = txt_Url.Text;
            string path = txt_Path.Text;
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.Absolute);

            if (string.IsNullOrWhiteSpace(url) || !isUri)
            {
                txt_Url.Focus();
                MessageBox.Show("Url không đúng định dạng");
                return;
            }

            if (Directory.Exists(path))
            {
                txt_Path.Focus();
                MessageBox.Show("Đường dẫn không đúng định dạng");
                return;
            }

            WebClient myClient = new WebClient();
            Stream dataStream = myClient.OpenRead(url);
            StreamReader reader = new StreamReader(dataStream);

            rtxt_HTML.Text = reader.ReadToEnd();
            myClient.DownloadFile(url, path);
        }

        private void Bai03_Load(object sender, EventArgs e)
        {
            txt_Path.Text = Directory.GetCurrentDirectory() + "\\index.html";
        }
    }
}
