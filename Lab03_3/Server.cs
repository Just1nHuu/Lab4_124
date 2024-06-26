﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            listViewCommnad.Scrollable = true;
            listViewCommnad.View = View.Details;
            listViewCommnad.Columns.Add("Received message", 1000);

        }
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

            listViewCommnad.Items.Add("Server is running on 127.0.0.1:8080");
            listViewCommnad.Items.Add("Server is listening...");

            //Chấp nhận kết nối từ client
            ClientSocket = ListenerSocket.Accept();
            
            NetworkStream ns = new NetworkStream(ClientSocket);           

            //Nhận dữ liệu từ client
            while (ClientSocket.Connected)
            {
                string text = "";
                do
                { 
                byteReceived = ClientSocket.Receive(received);
                text = Encoding.UTF8.GetString(received,0,byteReceived);
                text = "From client: " + text;
                } while (ClientSocket.Available > 0);
                Byte[] data = Encoding.UTF8.GetBytes("Nhận yêu cầu");
                ns.Write(data, 0, data.Length);
                ns.Flush();
                listViewCommnad.Items.Add(new ListViewItem(text));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread TCPServer = new Thread(new ThreadStart(StartUnsafeThread));
            TCPServer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Thoát chương trình
            System.Environment.Exit(0);
        }
    }
}
