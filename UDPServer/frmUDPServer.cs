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

namespace UDPServer
{
    public partial class frmUDPServer : Form
    {
        private UdpClient udpServer;
        private IPEndPoint endPoint;

        public frmUDPServer()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                udpServer = new UdpClient(9000);
                endPoint = new IPEndPoint(IPAddress.Any, 9000);
                lstData.Items.Add("Server đang chạy...");

                // Lắng nghe tin nhắn từ Client
                udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi động server: {ex.Message}");
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                byte[] receivedData = udpServer.EndReceive(ar, ref endPoint);
                string receivedMessage = Encoding.UTF8.GetString(receivedData);
                this.Invoke((MethodInvoker)delegate
                {
                    lstData.Items.Add($"Client: {receivedMessage}");
                });

                // Phản hồi lại Client
                string responseMessage = receivedMessage.ToUpper();
                byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
                udpServer.Send(responseData, responseData.Length, endPoint);

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
    }
}
