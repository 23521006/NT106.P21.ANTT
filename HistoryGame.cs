using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNT106
{
    public partial class HistoryGame : Form
    {
        public HistoryGame()
        {
            InitializeComponent();
        }

        private async void HistoryGame_Load(object sender, EventArgs e)
        {
            string supabaseUrl = "https://dluikakxqyiihammxgjh.supabase.co";
            string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImRsdWlrYWt4cXlpaWhhbW14Z2poIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTEzNDU1NDAsImV4cCI6MjA2NjkyMTU0MH0.IsiXrH5pRunsIk823f-JZnJsVvBMqoo_eZURYXjacvE";
            var client = new Supabase.Client(supabaseUrl, supabaseKey);
            await client.InitializeAsync();

            string myEmail = SessionManager.CurrentUser.Email;

            // Lấy lịch sử đấu có mình là người thắng hoặc thua, sắp xếp mới nhất trước
            var histories = await client
                .From<History>()
                .Where(h => h.Winner == myEmail || h.Loser == myEmail)
                .Order(h => h.Date, Supabase.Postgrest.Constants.Ordering.Descending)
                .Get();

            dataGridView1.Rows.Clear();

            foreach (var h in histories.Models)
            {
                string result = h.Winner == myEmail ? "Win" : "Lose";
                string opponent = h.Winner == myEmail ? h.Loser : h.Winner;
                dataGridView1.Rows.Add(opponent, result);
            }
        }
    }
}
