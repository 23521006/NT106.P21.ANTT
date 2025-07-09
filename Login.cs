using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using Supabase;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace GameNT106
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string supabaseUrl = "https://dluikakxqyiihammxgjh.supabase.co";
            string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImRsdWlrYWt4cXlpaWhhbW14Z2poIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTEzNDU1NDAsImV4cCI6MjA2NjkyMTU0MH0.IsiXrH5pRunsIk823f-JZnJsVvBMqoo_eZURYXjacvE";

            var client = new Supabase.Client(supabaseUrl, supabaseKey);
            await client.InitializeAsync();

            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Đăng nhập bằng Supabase Auth
                var response = await client.Auth.SignInWithPassword(email, password);

                // Kiểm tra lỗi xác thực
                if (response == null || response.User == null)
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin player từ bảng player
                var players = await client
                    .From<Player>()
                    .Where(p => p.Email == email)
                    .Get();

                if (players.Models.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng trong bảng player.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var player = players.Models.First();

                // Đăng nhập thành công, lưu session
                SessionManager.CurrentUser = player;

                Menu menuForm = new Menu();
                menuForm.FormClosed += (s, args) => this.Show();
                menuForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chi tiết
                if (ex.Message.Contains("Invalid login credentials", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Email chưa được đăng ký hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Email not confirmed", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Tài khoản chưa xác nhận email. Vui lòng kiểm tra email để xác nhận tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            // Thay thế bằng thông tin dự án Supabase của bạn
            string supabaseUrl = "https://dluikakxqyiihammxgjh.supabase.co";
            string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImRsdWlrYWt4cXlpaWhhbW14Z2poIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTEzNDU1NDAsImV4cCI6MjA2NjkyMTU0MH0.IsiXrH5pRunsIk823f-JZnJsVvBMqoo_eZURYXjacvE";

            var client = new Supabase.Client(supabaseUrl, supabaseKey);
            await client.InitializeAsync();

            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra email đã tồn tại trong bảng player chưa
            var existingPlayers = await client
                .From<Player>()
                .Where(p => p.Email == email)
                .Get();

            if (existingPlayers.Models.Count > 0)
            {
                MessageBox.Show("Email này đã được đăng ký. Vui lòng sử dụng email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var response = await client.Auth.SignUp(email, password);

                if (response.User != null)
                {
                    // Mã hóa mật khẩu
                    string hashedPassword = HashPassword(password);

                    // Tạo player mới
                    var player = new Player
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTime.UtcNow,
                        Email = email,
                        Password = hashedPassword
                    };

                    // Lưu vào bảng player
                    var insertResponse = await client.From<Player>().Insert(player);

                    MessageBox.Show("Đăng ký thành công! Vui lòng kiểm tra email để xác nhận tài khoản.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            if (Server.IsServerOpen)
            {
                MessageBox.Show("Server đã được mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var serverForm = new Server();
            serverForm.Show();
            serverForm.Hide();
        }

        private void buttonPassForgot_Click(object sender, EventArgs e)
        {

        }
    }
}
