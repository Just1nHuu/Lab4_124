using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace bai6
{
    public partial class Form1 : Form
    {
        private string accessToken = ""; // Lưu trữ access token từ bài 5

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/api/v1/user/me";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        // Xử lý dữ liệu JSON ở đây và hiển thị thông tin lên giao diện Form
                        // Ví dụ: hiển thị tên người dùng và username
                        dynamic userData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);
                        string name = userData.name;
                        string username = userData.username;
                        MessageBox.Show($"Tên người dùng: {name}\nUsername: {username}", "Thông tin người dùng");
                    }
                    else
                    {
                        txt_response.Text = "Error! Please try again";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
