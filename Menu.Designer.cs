namespace GameNT106
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonMatching = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonRank = new Button();
            buttonHistory = new Button();
            labelMatching = new Label();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonMatching
            // 
            buttonMatching.Anchor = AnchorStyles.Bottom;
            buttonMatching.AutoSize = true;
            buttonMatching.Location = new Point(442, 449);
            buttonMatching.Name = "buttonMatching";
            buttonMatching.Size = new Size(157, 42);
            buttonMatching.TabIndex = 1;
            buttonMatching.Text = "Tìm Đối Thủ";
            buttonMatching.UseVisualStyleBackColor = true;
            buttonMatching.Click += buttonMatching_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.PAPER;
            pictureBox1.Location = new Point(657, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.ROCK;
            pictureBox2.Location = new Point(442, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.SCISSORS;
            pictureBox3.Location = new Point(235, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(157, 160);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // buttonRank
            // 
            buttonRank.AutoSize = true;
            buttonRank.Location = new Point(55, 47);
            buttonRank.Name = "buttonRank";
            buttonRank.Size = new Size(184, 42);
            buttonRank.TabIndex = 5;
            buttonRank.Text = "Bảng xếp hạng";
            buttonRank.UseVisualStyleBackColor = true;
            buttonRank.Click += buttonRank_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.AutoSize = true;
            buttonHistory.Location = new Point(55, 119);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(184, 42);
            buttonHistory.TabIndex = 6;
            buttonHistory.Text = "Lịch sử đấu";
            buttonHistory.UseVisualStyleBackColor = true;
            // 
            // labelMatching
            // 
            labelMatching.Anchor = AnchorStyles.None;
            labelMatching.AutoSize = true;
            labelMatching.ForeColor = SystemColors.ButtonHighlight;
            labelMatching.Location = new Point(417, 494);
            labelMatching.Name = "labelMatching";
            labelMatching.Size = new Size(0, 32);
            labelMatching.TabIndex = 7;
            labelMatching.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLogout.AutoSize = true;
            buttonLogout.Location = new Point(844, 12);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(184, 42);
            buttonLogout.TabIndex = 8;
            buttonLogout.Text = "LOG OUT";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1040, 576);
            Controls.Add(buttonLogout);
            Controls.Add(labelMatching);
            Controls.Add(buttonHistory);
            Controls.Add(buttonRank);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonMatching);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1056, 615);
            Name = "Menu";
            Text = "Kéo Búa Bao GAME";
            FormClosing += Menu_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonMatching;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonRank;
        private Button buttonHistory;
        private Label labelMatching;
        private Button buttonLogout;
    }
}