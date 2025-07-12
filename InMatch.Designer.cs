namespace GameNT106
{
    partial class InMatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxOpponent = new PictureBox();
            pictureBoxPlayer = new PictureBox();
            buttonKeo = new Button();
            buttonBua = new Button();
            buttonBao = new Button();
            labelMyEmail = new Label();
            labelOpponentEmail = new Label();
            labelMyScore = new Label();
            labelOpponentScore = new Label();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOpponent
            // 
            pictureBoxOpponent.Anchor = AnchorStyles.None;
            pictureBoxOpponent.Location = new Point(520, 28);
            pictureBoxOpponent.Name = "pictureBoxOpponent";
            pictureBoxOpponent.Size = new Size(157, 160);
            pictureBoxOpponent.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOpponent.TabIndex = 0;
            pictureBoxOpponent.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Anchor = AnchorStyles.None;
            pictureBoxPlayer.Location = new Point(520, 251);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(157, 160);
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer.TabIndex = 1;
            pictureBoxPlayer.TabStop = false;
            // 
            // buttonKeo
            // 
            buttonKeo.Anchor = AnchorStyles.None;
            buttonKeo.AutoSize = true;
            buttonKeo.Location = new Point(215, 450);
            buttonKeo.Name = "buttonKeo";
            buttonKeo.Size = new Size(155, 81);
            buttonKeo.TabIndex = 2;
            buttonKeo.Tag = "S";
            buttonKeo.Text = "KÉO";
            buttonKeo.UseVisualStyleBackColor = true;
            buttonKeo.Click += MakeChoice;
            // 
            // buttonBua
            // 
            buttonBua.Anchor = AnchorStyles.None;
            buttonBua.AutoSize = true;
            buttonBua.Location = new Point(520, 450);
            buttonBua.Name = "buttonBua";
            buttonBua.Size = new Size(155, 81);
            buttonBua.TabIndex = 3;
            buttonBua.Tag = "R";
            buttonBua.Text = "BÚA";
            buttonBua.UseVisualStyleBackColor = true;
            buttonBua.Click += MakeChoice;
            // 
            // buttonBao
            // 
            buttonBao.Anchor = AnchorStyles.None;
            buttonBao.AutoSize = true;
            buttonBao.Location = new Point(825, 450);
            buttonBao.Name = "buttonBao";
            buttonBao.Size = new Size(155, 81);
            buttonBao.TabIndex = 4;
            buttonBao.Tag = "P";
            buttonBao.Text = "BAO";
            buttonBao.UseVisualStyleBackColor = true;
            buttonBao.Click += MakeChoice;
            // 
            // labelMyEmail
            // 
            labelMyEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelMyEmail.AutoSize = true;
            labelMyEmail.ForeColor = SystemColors.ButtonHighlight;
            labelMyEmail.Location = new Point(140, 299);
            labelMyEmail.Name = "labelMyEmail";
            labelMyEmail.Size = new Size(33, 21);
            labelMyEmail.TabIndex = 5;
            labelMyEmail.Text = "Tên";
            // 
            // labelOpponentEmail
            // 
            labelOpponentEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelOpponentEmail.AutoSize = true;
            labelOpponentEmail.ForeColor = SystemColors.ButtonHighlight;
            labelOpponentEmail.Location = new Point(857, 70);
            labelOpponentEmail.Name = "labelOpponentEmail";
            labelOpponentEmail.Size = new Size(33, 21);
            labelOpponentEmail.TabIndex = 7;
            labelOpponentEmail.Text = "Tên";
            // 
            // labelMyScore
            // 
            labelMyScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelMyScore.AutoSize = true;
            labelMyScore.ForeColor = SystemColors.ButtonHighlight;
            labelMyScore.Location = new Point(140, 331);
            labelMyScore.Name = "labelMyScore";
            labelMyScore.Size = new Size(72, 21);
            labelMyScore.TabIndex = 8;
            labelMyScore.Text = "Scores: 0";
            // 
            // labelOpponentScore
            // 
            labelOpponentScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelOpponentScore.AutoSize = true;
            labelOpponentScore.ForeColor = SystemColors.ButtonHighlight;
            labelOpponentScore.Location = new Point(857, 102);
            labelOpponentScore.Name = "labelOpponentScore";
            labelOpponentScore.Size = new Size(59, 21);
            labelOpponentScore.TabIndex = 9;
            labelOpponentScore.Text = "Scores:";
            // 
            // labelStatus
            // 
            labelStatus.Anchor = AnchorStyles.None;
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = SystemColors.ButtonHighlight;
            labelStatus.Location = new Point(781, 379);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 21);
            labelStatus.TabIndex = 10;
            // 
            // InMatch
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1191, 576);
            Controls.Add(labelStatus);
            Controls.Add(labelOpponentScore);
            Controls.Add(labelMyScore);
            Controls.Add(labelOpponentEmail);
            Controls.Add(labelMyEmail);
            Controls.Add(buttonBao);
            Controls.Add(buttonBua);
            Controls.Add(buttonKeo);
            Controls.Add(pictureBoxPlayer);
            Controls.Add(pictureBoxOpponent);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(1207, 615);
            MinimumSize = new Size(1207, 615);
            Name = "InMatch";
            Text = "Kéo Búa Bao GAME";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxOpponent;
        private PictureBox pictureBoxPlayer;
        private Button buttonKeo;
        private Button buttonBua;
        private Button buttonBao;
        private Label labelMyEmail;
        private Label labelOpponentEmail;
        private Label labelMyScore;
        private Label labelOpponentScore;
        private Label labelStatus;
    }
}
