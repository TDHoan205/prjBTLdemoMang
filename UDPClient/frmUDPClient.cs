using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDPClient
{
    public partial class frmUDPClient : Form
    {
        private UdpClient udpClient;
        private IPEndPoint serverEndPoint;

        public frmUDPClient()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
                lstData.Items.Add("Đã kết nối đến Server (UDP).");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối đến server: {ex.Message}");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serverEndPoint == null)
                {
                    MessageBox.Show("Vui lòng kết nối đến server trước.");
                    return;
                }

                // Gửi dữ liệu đến server
                string messageToSend = txtDataSending.Text.Trim();
                byte[] data = Encoding.UTF8.GetBytes(messageToSend);
                udpClient.Send(data, data.Length, serverEndPoint);

                // Hiển thị tin nhắn đã gửi
                lstData.Items.Add("Bạn: " + messageToSend);
                txtDataSending.Clear();

                // Nhận phản hồi từ server
                var serverResponse = udpClient.Receive(ref serverEndPoint);
                string responseMessage = Encoding.UTF8.GetString(serverResponse);
                lstData.Items.Add("Server: " + responseMessage);

                if (messageToSend.Equals("Thoát", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Kết nối đã đóng.");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi tin nhắn: {ex.Message}");
            }
        }
    }
}
