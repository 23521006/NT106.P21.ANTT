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
            buttonMatching.Enabled = false;
            labelMatching.Text = "Đang tìm đối thủ...";

            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync("26.122.162.80", 9000);
                    using (var stream = client.GetStream())
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        if (response.StartsWith("MATCH_FOUND"))
                        {
                            // Đã ghép cặp, mở form InMatch
                            var inMatchForm = new InMatch(client);
                            inMatchForm.FormClosed += (s, args) =>
                            {
                                this.Show();
                                buttonMatching.Enabled = true;
                            };
                            inMatchForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            labelMatching.Text = "Không tìm thấy đối thủ!";
                            buttonMatching.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                labelMatching.Text = "Lỗi kết nối server!";
                MessageBox.Show("Không thể kết nối server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonMatching.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.CurrentUser = null;
        }
    }
}
