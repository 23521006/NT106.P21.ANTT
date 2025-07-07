using System;
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
using System.Collections.Concurrent;

namespace GameNT106
{
    public partial class Server : Form
    {
        private TcpListener listener;
        private bool isRunning = false;
        public static bool IsServerOpen = false;

        // Hàng đợi chờ ghép cặp
        private ConcurrentQueue<TcpClient> waitingClients = new ConcurrentQueue<TcpClient>();

        public Server()
        {
            InitializeComponent();
            IsServerOpen = true;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            IsServerOpen = false; // Đánh dấu đã đóng Server
        }

        private async void Server_Load(object sender, EventArgs e)
        {
            int port = 9000; // Chọn port bất kỳ, ví dụ 9000
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            isRunning = true;
            labelStatus.Text = $"Server đang chạy trên {GetLocalIPAddress()}:{port}";

            while (isRunning)
            {
                try
                {
                    var client = await listener.AcceptTcpClientAsync();
                    // Đưa vào hàng đợi
                    waitingClients.Enqueue(client);
                    TryMatchPlayers();
                }
                catch (ObjectDisposedException)
                {
                    // Listener đã bị đóng, thoát vòng lặp
                    break;
                }
                catch (SocketException)
                {
                    // Listener đã bị đóng hoặc có lỗi socket, thoát vòng lặp
                    break;
                }
            }
        }

        // Hàm ghép cặp 2 client
        private void TryMatchPlayers()
        {
            if (waitingClients.Count >= 2)
            {
                if (waitingClients.TryDequeue(out TcpClient client1) && waitingClients.TryDequeue(out TcpClient client2))
                {
                    // Tạo trận đấu giữa 2 client
                    _ = StartMatchAsync(client1, client2);
                }
            }
        }

        // Gửi thông báo cho 2 client đã được ghép cặp
        private async Task StartMatchAsync(TcpClient client1, TcpClient client2)
        {
            try
            {
                using (var stream1 = client1.GetStream())
                using (var stream2 = client2.GetStream())
                {
                    byte[] msg1 = Encoding.UTF8.GetBytes("MATCH_FOUND|1");
                    byte[] msg2 = Encoding.UTF8.GetBytes("MATCH_FOUND|2");
                    await stream1.WriteAsync(msg1, 0, msg1.Length);
                    await stream2.WriteAsync(msg2, 0, msg2.Length);
                }
            }
            catch { }
            finally
            {
                client1.Close();
                client2.Close();
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            listener?.Stop();
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Không tìm thấy IP";
        }
    }
}
