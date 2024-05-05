using System.Net;
using System.Security.Policy;
using static System.Net.WebRequestMethods;
using HtmlAgilityPack;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Web;
using System.Text.Json;
using System.IO;
using static Lab04_4.TrangChu;
using System.Text.Json.Serialization;
namespace Lab04_4
{
    public partial class TrangChu : Form
    {
        public class ChiTietPhim
        {

            [JsonPropertyName("TenPhim")]
            public required string TenPhim { get; set; }
            [JsonPropertyName("HinhAnh")]
            public string HinhAnh { get; set; }
            [JsonPropertyName("UrlChiTietPhim")]
            public string Scipt { get; set; }
        }

        public List<ChiTietPhim> chiTietPhims;
        public int currentloadpBar = 10;
        public TrangChu()
        {
            InitializeComponent();
            pBar.Minimum = 0;
            pBar.Maximum = 100;
            flowLayoutPanel1.AutoScroll = true;

            chiTietPhims = new List<ChiTietPhim>();

        }

        private void LoadHinhAnh(string hinhanh, string chitietphim, string tenphim)
        {
            if (string.IsNullOrEmpty(hinhanh) || string.IsNullOrEmpty(chitietphim) || string.IsNullOrEmpty(tenphim))
            {
                // One or more of the parameters are null or empty.
                // Handle this case as needed.
                MessageBox.Show("One or more of the parameters are null or empty.");
                return;
            }
            MyControl myControl = new MyControl();
            myControl.tenphim = tenphim;
            myControl.hinhanh = hinhanh;
            myControl.chitiet = chitietphim;
            flowLayoutPanel1.Controls.Add(myControl);
            //nhập các dữ liệu vào list
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            string url = "https://betacinemas.vn/phim.htm";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            //Lấy tất cả các thẻ div có class là "product-item no-padding"
            var nodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='col-lg-4 col-md-4 col-sm-8 col-xs-16 padding-right-30 padding-left-30 padding-bottom-30']");

            foreach (var node in nodes)
            {
                var ImgNode = node.SelectSingleNode(".//img[@class='img-responsive border-radius-20']");
                var ChiTietNode = node.SelectSingleNode(".//h3[@class='text-center text-sm-left text-xs-left bold margin-top-5 font-sm-18 font-xs-14']//a");
                var TenPhimNode = node.SelectSingleNode(".//h3[@class='text-center text-sm-left text-xs-left bold margin-top-5 font-sm-18 font-xs-14']//a");

                if (ImgNode != null && ChiTietNode != null && TenPhimNode != null)
                {

                    string hinhAnh = ImgNode.GetAttributeValue("src", "");
                    string chitietphim = ChiTietNode.GetAttributeValue("href", "");
                    string tenPhim = TenPhimNode.InnerText;
                    chitietphim = "https://betacinemas.vn/" + chitietphim;
                    
                    chiTietPhims.Add(new ChiTietPhim { HinhAnh = hinhAnh, Scipt = chitietphim, TenPhim = tenPhim });
                    LoadHinhAnh(hinhAnh, chitietphim, tenPhim);
                    

                }
                currentloadpBar += 10;
                pBar.Value = currentloadpBar;
            }
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            string luuChiTietPhim = JsonSerializer.Serialize(chiTietPhims, options);
            System.IO.File.WriteAllText("LuuTruTomTatPhim.json", luuChiTietPhim);
            pBar.Value = 100;
        }

    }
}
