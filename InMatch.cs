using System;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNT106
{
    public partial class InMatch : Form
    {
        string playerChoice;
        string opponentChoice;
        int opponentScore;
        int playerScore;
        string resultPlayer, resultOpponent;

        private TcpClient client;
        private NetworkStream stream;
        private string playerEmail, opponentEmail;
        private bool isWaiting = false;

        public InMatch(TcpClient tcpClient, string playerEmail, string opponentEmail)
        {
            InitializeComponent();
            client = tcpClient;
            stream = client.GetStream();
            this.playerEmail = playerEmail;
            this.opponentEmail = opponentEmail;
            labelMyEmail.Text = playerEmail;
            labelOpponentEmail.Text = opponentEmail;
        }

        private async void MakeChoice(object sender, EventArgs e)
        {
            if (isWaiting) return;

            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;

            // Disable các nút chọn
            buttonBua.Enabled = false;
            buttonBao.Enabled = false;
            buttonKeo.Enabled = false;
            isWaiting = true;

            labelStatus.Text = "Bạn đã đưa ra lựa chọn, đợi đối thủ...";

            // Gửi lựa chọn lên server
            string msg = $"CHOICE|{playerChoice}";
            byte[] data = Encoding.UTF8.GetBytes(msg);
            await stream.WriteAsync(data, 0, data.Length);

            // Nhận kết quả từ server
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            if (response == "END_MATCH")
            {
                MessageBox.Show("Trận đấu đã kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            // Server trả về: RESULT|<yourChoice>|<opponentChoice>|<yourScore>|<opponentScore>|<result>
            // Ví dụ: RESULT|R|S|1|0|Win!
            if (response.StartsWith("RESULT"))
            {
                var parts = response.Split('|');
                if (parts.Length >= 6)
                {
                    playerChoice = parts[1];
                    opponentChoice = parts[2];
                    int.TryParse(parts[3], out playerScore);
                    int.TryParse(parts[4], out opponentScore);
                    resultPlayer = parts[5];
                    resultOpponent = resultPlayer == "Win!" ? "Lose!" : resultPlayer == "Lose!" ? "Win!" : "Draw!";

                    UpdateTextandImage(playerChoice, pictureBoxPlayer);
                    UpdateTextandImage(opponentChoice, pictureBoxOpponent);

                    labelMyEmail.Text = "Your Score: " + playerScore + Environment.NewLine + resultPlayer;
                    labelOpponentEmail.Text = "Opponent's Score: " + opponentScore + Environment.NewLine + resultOpponent;
                }

                // Cho phép chọn lại cho lượt tiếp theo
                buttonBua.Enabled = true;
                buttonBao.Enabled = true;
                buttonKeo.Enabled = true;
                isWaiting = false;
                labelStatus.Text = "";
            }
            else if (response.StartsWith("WAIT"))
            {
                labelStatus.Text = "Đối thủ đã đưa ra lựa chọn";
            }
        }

        private void UpdateTextandImage(string text, PictureBox pic)
        {
            switch (text)
            {
                case "R":
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            stream?.Close();
            client?.Close();
        }
    }
}
