﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.Xml;
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
                TcpClient client = new TcpClient();
                await client.ConnectAsync("26.122.162.80", 9000);
                var stream = client.GetStream();

                string email = SessionManager.CurrentUser.Email;
                byte[] emailData = Encoding.UTF8.GetBytes("EMAIL|" + email);
                await stream.WriteAsync(emailData, 0, emailData.Length);

                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                if (response.StartsWith("MATCH_FOUND"))
                {
                    // Đã ghép cặp, mở form InMatch
                    var parts = response.Split('|');
                    string myEmail = parts[2];
                    string opponentEmail = parts[3];

                    var inMatchForm = new InMatch(client, myEmail, opponentEmail);
                    inMatchForm.FormClosed += (s, args) =>
                    {
                        this.Show();
                        labelMatching.Text = "";
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
            catch (Exception ex)
            {
                labelMatching.Text = "Lỗi kết nối server!";
                MessageBox.Show("Không thể kết nối server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonMatching.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SessionManager.CurrentUser = null;
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
        }

        private void buttonRank_Click(object sender, EventArgs e)
        {
            var rankForm = new Ranking();
            rankForm.ShowDialog();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryGame();
            historyForm.ShowDialog();
        }
    }
}
