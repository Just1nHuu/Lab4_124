using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Authentication;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using System.Net;

namespace Lab03_4
{
    public partial class Client : Form
    {

        //Thực hiện chọn các checbox của ghế ngồi ứng với tên phim và phòng chiếu
        //chưa các lựa chọn đó trong một dãy ghế ngồi với tên phim và phòng chiếu
        //gửi dãy ghế ngồi đó lên server
        //client không được phép đọc file gì cả
        //client không được phép gửi dữ liệu lên server bằng cách gửi file  
        //client không được phép gửi dữ liệu lên server bằng cách gửi dữ liệu dạng JSO
        //Cần thông tin gì thì client phải gửi yêu cầu lên server để server trả về

        private List<ViTriGheDat> VeDaDat;
        private List<ViTriGheDat> phongchieus;
        private List<cDanhGiaPhim> destination;
        private List<cPhim> phims;
        private NetworkStream ns;
        private TcpClient client;
        public Client()
        {
            InitializeComponent();
            client = new TcpClient();
            //1.Lấy danh sách phim ngay khi đã kết nối đến server
            //Danh sách dữ liệu phim nhận từ server
            List<cPhim> phims = new List<cPhim>();

            //Danh sách dữ liệu vị trí đã được đặt nhận từ client
            List<ViTriGheDat> listVeDaDat = new List<ViTriGheDat>();

            //Danh sách dữ liệu đánh giá phim nhận từ client
            List<cDanhGiaPhim> listDanhGia = new List<cDanhGiaPhim>();

            //Danh sách dữ liệu tất cả phòng chiếu nhận được chọn từ checkbox của client
            List<ViTriGheDat> listDaChon = new List<ViTriGheDat>();
        }

        //Hàm thực hiện kết nối đến server
        //Thực hiện gửi yêu cầu lên server để lấy dữ liệu phim được server đọc từ file Input5.json
        //Thực hiện gửi yêu cầu lên server để lấy dữ liệu đánh giá phim được server đọc từ file Output5.json
        //Thực hiện gửi yêu cầu lên server để lấy dữ liệu vị trí ghế ngồi đã được đọc từ file KiemTraVe.json
        private void Client_Load(object sender, EventArgs e)
        {

        }

        //Thay đổi lựa chọn tên phim
        private void ChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Thay đổi lựa chọn phong chiếu
        private void ChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LayDanhSach_Click(object sender, EventArgs e)
        {
            this.ns = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes("Gửi dữ liệu phim\n");
            ns.Write(data, 0, data.Length);

            data = new Byte[1024];
            String responseData = String.Empty;
            Int32 bytes = ns.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes);
            textBox1.Text = responseData;
        }

        //Yêu cầu lấy danh sách phim từ server
        private void button2_Click(object sender, EventArgs e)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client.Connect(iPEndPoint);


        }
        //Gửi danh sách vị trí ghế ngồi đã chọn lên server
        //Gửi thông báo ghế ngồi hợp lệ vâ không hợp lệ - không hợp  lệ tức là ghế ngồi đã được chọn
        //Thông tin danh sách ghế ngồi đã được chọn sẽ được cập nhật liên tục và đưa vào MessageBox
        //Danh sách thông tin ghế ngồi đã chọn được yêu cầu lúc thay đôi thông tin phòng chiếu
        //và đánh giá phim sẽ được yêu cầu và nhận lúc thay đổi thông tin chọn phim 
        //1.Danh sách tất cả phim của rạp được yêu cầu và nhận lúc load form
        private void DatVe_Click(object sender, EventArgs e)
        {
            //Thông báo xác nhận gửi danh sách ghế ngồi đã chọn lên server
            MessageBox.Show("Danh sách ghế ngồi đã chọn được gưi cho server", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

    }
}