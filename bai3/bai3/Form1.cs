using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetHTML()
        {
            if (webBrowser1.Document == null || splitContainer1.Panel2Collapsed) return;
            rtxt_HTML.Text = webBrowser1.DocumentText;
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            string address = txt_Url.Text;

            if (string.IsNullOrEmpty(address) ||
                address.Equals("about:blank"))
                return;

            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
                address = "http://" + address;

            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (UriFormatException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void btn_Source_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            GetHTML();
        }

        private void txt_Url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Go_Click(this, new EventArgs());
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            btn_Go_Click(this, new EventArgs());
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txt_Url.Text = webBrowser1.Url.ToString();
            GetHTML();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
