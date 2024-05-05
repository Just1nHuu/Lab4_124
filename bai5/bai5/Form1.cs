using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class info
        {
            public string name { get; set; }
            public string password { get; set; }
            public info(string name, string pass)
            {
                this.name = name;
                this.password = pass;
            }
        }
        private async void btnPost_Click(object sender, EventArgs e)
        {
            string url = txt_url.Text;

            using (HttpClient httpclient = new HttpClient())
            {
                try
                {
                    //Nhập password để trích xuất id và token từ 2 đối tượng trên
                    HttpResponseMessage response = await httpclient.PostAsJsonAsync(url,
                        new info(name: txt_email.Text, pass: txt_pass.Text));
                    //Kiểm tra đường link nhập vào có trả về 200 OK hay không ?
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        dynamic json_response = JsonConvert.DeserializeObject<dynamic>(responseContent); // Thực hiện lấy data từ API trong đường link nhập vào
                    
                        string token = json_response.token;
                        int id = json_response.id;

                        txt_response.Text += "ID: " + id + "\n";
                        txt_response.Text += "Token: " + token;
                    }
                    else
                    {
                        txt_response.Text = "Method Not Allowed";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
