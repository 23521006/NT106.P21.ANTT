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

            var data = players.Models
                .OrderByDescending(p => p.Win)
                .ThenBy(p => p.Lose)
                .Select((p, idx) => new
                {
                    Top = idx + 1,
                    Player = p.Email,
                    Wins = p.Win,
                    Loses = p.Lose
                })
                .ToList();

            dataGridView1.DataSource = data;
        }
    }
}
