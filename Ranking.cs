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
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private async void Ranking_Load(object sender, EventArgs e)
        {
            string supabaseUrl = "https://dluikakxqyiihammxgjh.supabase.co";
            string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImRsdWlrYWt4cXlpaWhhbW14Z2poIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTEzNDU1NDAsImV4cCI6MjA2NjkyMTU0MH0.IsiXrH5pRunsIk823f-JZnJsVvBMqoo_eZURYXjacvE";
            var client = new Supabase.Client(supabaseUrl, supabaseKey);
            await client.InitializeAsync();

            var players = await client
                .From<Player>()
                .Order(x => x.Win, Supabase.Postgrest.Constants.Ordering.Descending)
                .Get();

            dataGridView1.Rows.Clear();

            int myRank = -1;
            string myEmail = SessionManager.CurrentUser.Email;
            for (int i = 0; i < players.Models.Count; i++)
            {
                var p = players.Models[i];
                dataGridView1.Rows.Add(i + 1, p.Email, p.Win, p.Lose);
                if (p.Email == myEmail)
                    myRank = i + 1;
            }

            labelRanking.Text = $"Thứ hạng của bạn: {myRank}";
        }
    }
}
