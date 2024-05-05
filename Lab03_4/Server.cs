using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text.Json;
using System.Security.Claims;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Lab03_4
{
    //Thực hiện
    public partial class Server : Form
    {
        private Socket socketClient;
        private List<ViTriGheDat> VeDaDat;
        private List<cDanhGiaPhim> danhgia;
        private List<cPhim> phims;
        public Server()
        {
            InitializeComponent();
            
            listView1.Scrollable = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Message", 1000);
            

            phims = new List<cPhim>();
            danhgia = new List<cDanhGiaPhim>();
            VeDaDat = new List<ViTriGheDat>();
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Đọc dữ liệu từ file Input5.JSON
            string jsonPhim = System.IO.File.ReadAllText("Input5.JSON");

            //Đọc dữ liệu từ file cDanhDanhGia.JSON
            string jsonDanhGia = System.IO.File.ReadAllText("Output5.JSON");

            //Đọc dữ liệu từ file KiemTraVe.JSON
            string jsonVeDaDat = System.IO.File.ReadAllText("KiemTraVe.JSON");
        }
        //Hàm thực lắng nghe kết nối từ client
        private NetworkStream ns;
        public void StartUnsafeThread()
        {
            int byteReceived = 0;
            // Khởi tạo mảng byte để nhận dữ liệu
            byte[] received = new byte[1024];

            //Tạo socket bên gởi
            Socket ClientSocket;

            //Tạo socket lắng nghe
            Socket ListenerSocket = new Socket(
                //Trả  về họ địa chỉ của địa chỉ hiện hành
                //ở đây là địa chỉ IPv4 nên chọn AddressFamily.InterNetwork
                AddressFamily.InterNetwork,

                //Kiểu socket là stream,để nhận dữ liệu liên tục
                SocketType.Stream,

                //Giao thức truyền dữ liệu là TCP
                ProtocolType.Tcp);

            //Gán socket với địa chỉ IP và cổng
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            //Gán Socket địa chỉ và port phải lắng nghe vào máy chủ
            ListenerSocket.Bind(ipServer);

            //Bắt đầu lắng nghe
            ListenerSocket.Listen(-1);

            //Chấp nhận kết nối từ client
            ClientSocket = ListenerSocket.Accept();


            //Nhận dữ liệu từ client
            
            listView1.Items.Add("Server is running on 127.0.0.1:8080");
            listView1.Items.Add("Server is listening...");
            while (ClientSocket.Connected)
            {
                string text = "";
                do
                {
                    byteReceived = ClientSocket.Receive(received);
                    text += Encoding.UTF8.GetString(received);
                } while (socketClient.Available >0 );
                text = "From client: " + text;

                
                        
                //Gửi dữ liệu phim cho client
                Byte[] data2 = Encoding.UTF8.GetBytes("Nhận yêu cầu");
                ns.Write(data2, 0, data2.Length);
                ns.Flush();


                listView1.Items.Add(new ListViewItem(text));
                /*
                if (text=="Gửi dữ liệu phim\n")
                {
                    GuiDuLieuPhim(null, null);
                }
                else if(text=="Gửi dữ liệu đánh giá phim\n")
                {
                    GuiDuLieuDanhGiaPhim(null, null);
                }
                else if(text=="Gửi dữ liệu vị trí ghế ngồi\n")
                {
                    GuiDuLieuViTriGheNgoi(null, null);
                }
                //Nhận dữ liệu từ client đến dấu xuống hàng*/
            }
        }
        
        private void Server_Load(object sender, EventArgs e)
        {

            //Kết nối đến client
            CheckForIllegalCrossThreadCalls = false;
            Thread TCPServer = new Thread(new ThreadStart(StartUnsafeThread));
            TCPServer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Thoát chương trình
            System.Environment.Exit(0);
        }






        //Hàm thực hiện nhận yêu cầu lấy dữ liệu phim tầy file Input5.JSON và trả về cho client
        private void GuiDuLieuPhim(object sender, EventArgs e)
        {
            //Gửi dữ liệu phim cho client
            string jsonPhim = JsonSerializer.Serialize(phims);
            byte[] data = Encoding.UTF8.GetBytes(jsonPhim);
            ns.Write(data, 0, data.Length);
        }
        //Hàm thực hiện nhận yêu cầu lấy dữ liệu đánh giá phim từ file Output5.JSON và trả về cho client
        private void GuiDuLieuDanhGiaPhim(object sender, EventArgs e)
        {
            //Gửi dữ liệu đánh giá phim cho client
            string jsonDanhGia = JsonSerializer.Serialize(danhgia);
            byte[] data = Encoding.UTF8.GetBytes(jsonDanhGia);
            ns.Write(data, 0, data.Length);
        }
        //Hàm thực hiện nhận yêu cầu lấy dữ liệu vị trí ghế ngồi từ file KiemTraVe.JSON và trả về cho client
        private void GuiDuLieuViTriGheNgoi(object sender, EventArgs e)
        {
            //Gửi dữ liệu vị trí ghế ngồi cho client
            string jsonVeDaDat = JsonSerializer.Serialize(VeDaDat);
            byte[] data = Encoding.UTF8.GetBytes(jsonVeDaDat);
            ns.Write(data, 0, data.Length);
        }
    }
}
