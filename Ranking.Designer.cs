namespace GameNT106
{
    partial class Ranking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            labelRanking = new Label();
            Top = new DataGridViewTextBoxColumn();
            Player = new DataGridViewTextBoxColumn();
            Wins = new DataGridViewTextBoxColumn();
            Loses = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Top, Player, Wins, Loses });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(975, 594);
            dataGridView1.TabIndex = 0;
            // 
            // labelRanking
            // 
            labelRanking.Anchor = AnchorStyles.None;
            labelRanking.AutoSize = true;
            labelRanking.Location = new Point(0, 599);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(160, 32);
            labelRanking.TabIndex = 1;
            labelRanking.Text = "Your ranking: ";
            // 
            // Top
            // 
            Top.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Top.HeaderText = "Top";
            Top.MinimumWidth = 8;
            Top.Name = "Top";
            Top.ReadOnly = true;
            // 
            // Player
            // 
            Player.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Player.HeaderText = "Player";
            Player.MinimumWidth = 8;
            Player.Name = "Player";
            Player.ReadOnly = true;
            // 
            // Wins
            // 
            Wins.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Wins.HeaderText = "Wins";
            Wins.MinimumWidth = 8;
            Wins.Name = "Wins";
            Wins.ReadOnly = true;
            // 
            // Loses
            // 
            Loses.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Loses.HeaderText = "Loses";
            Loses.MinimumWidth = 8;
            Loses.Name = "Loses";
            Loses.ReadOnly = true;
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(975, 640);
            Controls.Add(labelRanking);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Ranking";
            Text = "Bảng xếp hạng";
            Load += Ranking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label labelRanking;
        private DataGridViewTextBoxColumn Top;
        private DataGridViewTextBoxColumn Player;
        private DataGridViewTextBoxColumn Wins;
        private DataGridViewTextBoxColumn Loses;
    }
}