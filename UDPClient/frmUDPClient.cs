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
                serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000); // Địa chỉ IP của Server
                lstData.Items.Add("Đang kết nối với Server (UDP)...");

                // Gửi thông báo kết nối đến Server
                string connectionMessage = "Client đã kết nối!";
                byte[] data = Encoding.UTF8.GetBytes(connectionMessage);
                udpClient.Send(data, data.Length, serverEndPoint);

                // Bắt đầu lắng nghe phản hồi từ Server
                udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối đến Server: {ex.Message}");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serverEndPoint == null)
                {
                    MessageBox.Show("Vui lòng kết nối đến Server trước.");
                    return;
                }

                // Gửi tin nhắn đến Server
                string messageToSend = txtDataSending.Text.Trim();
                byte[] data = Encoding.UTF8.GetBytes(messageToSend);
                udpClient.Send(data, data.Length, serverEndPoint);

                lstData.Items.Add("Bạn: " + messageToSend); // Hiển thị tin nhắn gửi đi
                txtDataSending.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi tin nhắn: {ex.Message}");
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                byte[] receivedData = udpClient.EndReceive(ar, ref serverEndPoint);
                string receivedMessage = Encoding.UTF8.GetString(receivedData);

                // Hiển thị tin nhắn từ Server
                this.Invoke((MethodInvoker)delegate
                {
                    if (receivedMessage.Contains("Client đã kết nối thành công!"))
                    {
                        lstData.Items.Add("Server: " + receivedMessage);
                        lstData.Items.Add("Kết nối thành công đến Server!");
                    }
                    else
                    {
                        lstData.Items.Add("Server: " + receivedMessage);
                    }
                });

                // Tiếp tục lắng nghe tin nhắn khác
                udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lstData.Items.Add($"Lỗi: {ex.Message}");
                });
            }
        }
    }
}