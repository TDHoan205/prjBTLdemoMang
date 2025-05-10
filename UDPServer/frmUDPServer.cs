using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDPServer
{
    public partial class frmUDPServer : Form
    {
        private UdpClient udpServer;
        private IPEndPoint clientEndPoint;

        public frmUDPServer()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                udpServer = new UdpClient(9000); // Khởi động Server trên cổng 9000
                clientEndPoint = new IPEndPoint(IPAddress.Any, 0); // Lắng nghe từ bất kỳ địa chỉ nào
                lstData.Items.Add("Server đang chạy và lắng nghe...");

                // Lắng nghe tin nhắn từ Client
                udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi động Server: {ex.Message}");
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                byte[] receivedData = udpServer.EndReceive(ar, ref clientEndPoint);
                string receivedMessage = Encoding.UTF8.GetString(receivedData);

                // Hiển thị tin nhắn nhận được từ Client
                this.Invoke((MethodInvoker)delegate
                {
                    lstData.Items.Add($"Client ({clientEndPoint.Address}): {receivedMessage}");
                });

                // Kiểm tra tin nhắn từ Client để xác nhận kết nối
                if (receivedMessage == "Client đã kết nối!")
                {
                    string connectionMessage = "Client đã kết nối thành công!";
                    byte[] data = Encoding.UTF8.GetBytes(connectionMessage);
                    udpServer.Send(data, data.Length, clientEndPoint); // Gửi phản hồi xác nhận đến Client
                }

                // Tiếp tục lắng nghe
                udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lstData.Items.Add($"Lỗi: {ex.Message}");
                });
            }
        }

        private void btnSendToClient_Click(object sender, EventArgs e)
        {
            if (clientEndPoint == null)
            {
                MessageBox.Show("Chưa có Client kết nối!");
                return;
            }

            try
            {
                string messageToSend = txtDataToSend.Text.Trim();
                byte[] data = Encoding.UTF8.GetBytes(messageToSend);
                udpServer.Send(data, data.Length, clientEndPoint);

                lstData.Items.Add($"Server: {messageToSend}");
                txtDataToSend.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi tin nhắn: {ex.Message}");
            }
        }
    }
}