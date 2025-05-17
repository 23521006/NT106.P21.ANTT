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

namespace GameNT106
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            switch (UserManager.Login(username, password))
            {
                case 0:
                    MessageBox.Show("Tên đăng nhập không tồn tại!");
                    break;
                case 1:
                    MessageBox.Show("Mật khẩu không đúng!");
                    break;
                case 2:
                    new Menu().ShowDialog();
                    break;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (UserManager.Register(username, password))
                MessageBox.Show("Đăng ký thành công!");
            else
                MessageBox.Show("Tên người dùng đã tồn tại!");
        }
    }

    public static class UserManager
    {
        private static readonly string dataFile = "users.json";
        private static Dictionary<string, string> users;

        // Static constructor: tự động chạy khi lần đầu truy cập vào UserManager
        static UserManager()
        {
            Load();
        }

        // Đăng ký tài khoản mới
        public static bool Register(string username, string password)
        {
            if (users.ContainsKey(username)) return false;
            users[username] = password;
            Save();   // Lưu file ngay khi có thay đổi
            return true;
        }

        // Đăng nhập
        public static int Login(string username, string password)
        {
            if (!users.ContainsKey(username))
                return 0; // Tên đăng nhập không tồn tại
            else if (users[username] != password)
                return 1; // Mật khẩu không đúng
            else
                return 2; // Đăng nhập thành công
        }

        // Ghi Dictionary ra file JSON
        private static void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(dataFile, json);
        }

        // Đọc Dictionary từ file JSON (nếu có), nếu không thì tạo mới
        private static void Load()
        {
            if (File.Exists(dataFile))
            {
                string json = File.ReadAllText(dataFile);
                users = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            }
            else
            {
                users = new Dictionary<string, string>();
            }
        }
    }
}
