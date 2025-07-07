using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNT106
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void buttonMatching_Click(object sender, EventArgs e)
        {
            labelMatching.Text = "Đang tìm đối thủ...";

            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync("127.0.0.1", 9000); // Đổi IP nếu server chạy trên máy khác
                    using (var stream = client.GetStream())
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        if (response.StartsWith("MATCH_FOUND"))
                        {
                            // Đã ghép cặp, mở form InMatch
                            var inMatchForm = new InMatch();
                            inMatchForm.FormClosed += (s, args) => this.Show();
                            inMatchForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            labelMatching.Text = "Không tìm thấy đối thủ!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                labelMatching.Text = "Lỗi kết nối server!";
                MessageBox.Show("Không thể kết nối server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SessionManager.CurrentUser = null;

            this.Close();
        }
    }
}
