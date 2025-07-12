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
using Supabase;
using System.Threading;

namespace GameNT106
{
    class WaitingClient
    {
        public TcpClient Client { get; }
        public string Email { get; set; }
        public bool IsConnected => Client.Connected;
        public WaitingClient(TcpClient client) => Client = client;
    }

    public partial class Server : Form
    {
        private TcpListener listener;
        private bool isRunning = false;
        public static bool IsServerOpen = false;

        // Hàng đợi chờ ghép cặp
        private ConcurrentQueue<WaitingClient> waitingClients = new ConcurrentQueue<WaitingClient>();

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
            int port = 9000;
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            isRunning = true;
            labelStatus.Text = $"Server đang chạy trên {GetLocalIPAddress()}:{port}";

            while (isRunning)
            {
                try
                {
                    var client = await listener.AcceptTcpClientAsync();
                    var waitingClient = new WaitingClient(client);

                    // Đọc email từ client
                    var stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (msg.StartsWith("EMAIL|"))
                    {
                        waitingClient.Email = msg.Substring(6);
                    }
                    else
                    {
                        waitingClient.Email = "Unknown";
                    }
                    waitingClients.Enqueue(waitingClient);

                    // Tạo task kiểm tra disconnect
                    _ = Task.Run(() => MonitorWaitingClient(waitingClient));

                    TryMatchPlayers();
                }
                catch (ObjectDisposedException) { break; }
                catch (SocketException) { break; }
            }
        }

        // Kiểm tra client còn kết nối không, nếu không thì loại khỏi hàng đợi
        private async Task MonitorWaitingClient(WaitingClient waitingClient)
        {
            try
            {
                var client = waitingClient.Client;
                var stream = client.GetStream();
                var buffer = new byte[1];
                while (client.Connected)
                {
                    // Nếu client disconnect, ReadAsync sẽ trả về 0
                    var task = stream.ReadAsync(buffer, 0, 0);
                    var completed = await Task.WhenAny(task, Task.Delay(1000));
                    if (completed == task && task.Result == 0)
                    {
                        break;
                    }
                }
            }
            catch { }
            finally
            {
                // Khi client disconnect, loại khỏi hàng đợi bằng cách bỏ qua khi ghép cặp
                // Không cần xóa trực tiếp vì ConcurrentQueue không hỗ trợ, sẽ xử lý ở TryMatchPlayers
            }
        }

        // Hàm ghép cặp 2 client
        private void TryMatchPlayers()
        {
            List<WaitingClient> tempList = new List<WaitingClient>();
            WaitingClient client1 = null, client2 = null;

            while (waitingClients.TryDequeue(out var waitingClient))
            {
                if (waitingClient.Client.Connected)
                {
                    if (client1 == null) client1 = waitingClient;
                    else if (client2 == null) { client2 = waitingClient; break; }
                }
                else
                {
                    // Đã disconnect, bỏ qua
                    waitingClient.Client.Close();
                }
            }

            // Đưa lại các client chưa ghép vào hàng đợi
            if (client1 != null && client2 == null)
                waitingClients.Enqueue(client1);

            // Nếu đủ 2 client còn sống thì ghép cặp
            if (client1 != null && client2 != null)
            {
                _ = StartMatchAsync(client1, client2);
            }
        }

        // Gửi thông báo cho 2 client đã được ghép cặp
        private async Task StartMatchAsync(WaitingClient client1, WaitingClient client2)
        {
            var match = new MatchHandler(client1.Client, client2.Client, client1.Email, client2.Email);
            await match.RunAsync();
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

    class MatchHandler
    {
        private TcpClient client1, client2;
        private NetworkStream stream1, stream2;
        private string email1, email2;
        private string choice1 = null, choice2 = null;
        private int score1 = 0, score2 = 0;
        private Supabase.Client supabaseClient;
        private volatile bool isMatchEnded = false;

        public MatchHandler(TcpClient c1, TcpClient c2, string e1, string e2)
        {
            client1 = c1;
            client2 = c2;
            email1 = e1;
            email2 = e2;
            stream1 = client1.GetStream();
            stream2 = client2.GetStream();

            supabaseClient = new Supabase.Client("https://dluikakxqyiihammxgjh.supabase.co", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImRsdWlrYWt4cXlpaWhhbW14Z2poIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTEzNDU1NDAsImV4cCI6MjA2NjkyMTU0MH0.IsiXrH5pRunsIk823f-JZnJsVvBMqoo_eZURYXjacvE");
            supabaseClient.InitializeAsync().Wait();
        }

        public async Task RunAsync()
        {
            // Gửi thông báo ghép cặp
            await stream1.WriteAsync(Encoding.UTF8.GetBytes($"MATCH_FOUND|1|{email1}|{email2}"));
            await stream2.WriteAsync(Encoding.UTF8.GetBytes($"MATCH_FOUND|2|{email2}|{email1}"));

            var t1 = ListenClientAsync(client1, stream1, 1);
            var t2 = ListenClientAsync(client2, stream2, 2);

            await Task.WhenAll(t1, t2); // Theo dõi trận đấu

            // Cập nhật kết quả khi kết thúc trận
            await UpdatePlayerResult();

            client1.Close();
            client2.Close();
        }

        private async Task UpdatePlayerResult()
        {
            if (Math.Abs(score1 - score2) < 3) return; // Không đủ điều kiện kết thúc

            string winnerEmail = score1 > score2 ? email1 : email2;
            string loserEmail = score1 > score2 ? email2 : email1;

            // Lấy player
            var winner = (await supabaseClient.From<Player>().Where(p => p.Email == winnerEmail).Get()).Models.FirstOrDefault();
            var loser = (await supabaseClient.From<Player>().Where(p => p.Email == loserEmail).Get()).Models.FirstOrDefault();

            if (winner != null)
            {
                winner.Win += 1;
                await supabaseClient.From<Player>().Update(winner);
            }
            if (loser != null)
            {
                loser.Lose += 1;
                await supabaseClient.From<Player>().Update(loser);
            }
        }

        private async Task ListenClientAsync(TcpClient client, NetworkStream stream, int player)
        {
            var buffer = new byte[1024];
            try
            {
                while (true)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        await EndMatch(player == 1 ? 2 : 1); // Gửi cho đối thủ nếu chưa kết thúc
                        break;
                    }

                    string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (msg.StartsWith("CHOICE|"))
                    {
                        string choice = msg.Split('|')[1];
                        if (player == 1) choice1 = choice;
                        else choice2 = choice;

                        // Gửi trạng thái cho đối thủ nếu chỉ 1 người đã chọn
                        if ((choice1 != null && choice2 == null) || (choice2 != null && choice1 == null))
                        {
                            try
                            {
                                if (player == 1 && stream2.CanWrite)
                                    await stream2.WriteAsync(Encoding.UTF8.GetBytes("WAIT"));
                                else if (player == 2 && stream1.CanWrite)
                                    await stream1.WriteAsync(Encoding.UTF8.GetBytes("WAIT"));
                            }
                            catch (ObjectDisposedException) { break; }
                            catch (IOException) { break; }
                        }

                        // Khi cả 2 đã chọn
                        if (choice1 != null && choice2 != null)
                        {
                            string result1, result2;
                            GetResult(choice1, choice2, out result1, out result2);

                            if (result1 == "Win!") score1++;
                            if (result2 == "Win!") score2++;

                            // Gửi kết quả cho client
                            string res1 = $"RESULT|{choice1}|{choice2}|{score1}|{score2}|{result1}";
                            string res2 = $"RESULT|{choice2}|{choice1}|{score2}|{score1}|{result2}";
                            try
                            {
                                if (stream1.CanWrite)
                                    await stream1.WriteAsync(Encoding.UTF8.GetBytes(res1));
                                if (stream2.CanWrite)
                                    await stream2.WriteAsync(Encoding.UTF8.GetBytes(res2));
                            }
                            catch (ObjectDisposedException) { break; }
                            catch (IOException) { break; }

                            // Reset cho lượt tiếp theo
                            choice1 = null;
                            choice2 = null;
                        }
                    }

                    if (Math.Abs(score1 - score2) >= 3)
                    {
                        await EndMatch(0); // Gửi cho cả hai
                        break;
                    }
                }
            }
            catch (ObjectDisposedException) { }
            catch (IOException) { }
        }

        private async Task EndMatch(int target)
        {
            if (isMatchEnded) return;
            isMatchEnded = true;
            try
            {
                if (target == 1 && stream1.CanWrite)
                    await stream1.WriteAsync(Encoding.UTF8.GetBytes("END_MATCH"));
                else if (target == 2 && stream2.CanWrite)
                    await stream2.WriteAsync(Encoding.UTF8.GetBytes("END_MATCH"));
                else if (target == 0)
                {
                    if (stream1.CanWrite)
                        await stream1.WriteAsync(Encoding.UTF8.GetBytes("END_MATCH"));
                    if (stream2.CanWrite)
                        await stream2.WriteAsync(Encoding.UTF8.GetBytes("END_MATCH"));
                }
            }
            catch { }
        }

        private void GetResult(string c1, string c2, out string r1, out string r2)
        {
            if (c1 == c2)
            {
                r1 = r2 = "Draw!";
            }
            else if ((c1 == "R" && c2 == "S") || (c1 == "S" && c2 == "P") || (c1 == "P" && c2 == "R"))
            {
                r1 = "Win!";
                r2 = "Lose!";
            }
            else
            {
                r1 = "Lose!";
                r2 = "Win!";
            }
        }
    }
}
