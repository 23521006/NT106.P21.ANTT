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
            labelMyWin = new Label();
            labelOpponentWin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOpponent
            // 
            pictureBoxOpponent.Anchor = AnchorStyles.None;
            pictureBoxOpponent.Location = new Point(445, 28);
            pictureBoxOpponent.Name = "pictureBoxOpponent";
            pictureBoxOpponent.Size = new Size(157, 160);
            pictureBoxOpponent.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxOpponent.TabIndex = 0;
            pictureBoxOpponent.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Anchor = AnchorStyles.None;
            pictureBoxPlayer.Location = new Point(445, 251);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(157, 160);
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxPlayer.TabIndex = 1;
            pictureBoxPlayer.TabStop = false;
            // 
            // buttonKeo
            // 
            buttonKeo.Anchor = AnchorStyles.None;
            buttonKeo.AutoSize = true;
            buttonKeo.Location = new Point(140, 450);
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
            buttonBua.Location = new Point(445, 450);
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
            buttonBao.Location = new Point(750, 450);
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
            labelMyEmail.Anchor = AnchorStyles.None;
            labelMyEmail.AutoSize = true;
            labelMyEmail.ForeColor = SystemColors.ButtonHighlight;
            labelMyEmail.Location = new Point(140, 299);
            labelMyEmail.Name = "labelMyEmail";
            labelMyEmail.Size = new Size(52, 32);
            labelMyEmail.TabIndex = 5;
            labelMyEmail.Text = "Tên";
            // 
            // labelOpponentEmail
            // 
            labelOpponentEmail.Anchor = AnchorStyles.None;
            labelOpponentEmail.AutoSize = true;
            labelOpponentEmail.ForeColor = SystemColors.ButtonHighlight;
            labelOpponentEmail.Location = new Point(706, 70);
            labelOpponentEmail.Name = "labelOpponentEmail";
            labelOpponentEmail.Size = new Size(52, 32);
            labelOpponentEmail.TabIndex = 7;
            labelOpponentEmail.Text = "Tên";
            // 
            // labelMyWin
            // 
            labelMyWin.Anchor = AnchorStyles.None;
            labelMyWin.AutoSize = true;
            labelMyWin.ForeColor = SystemColors.ButtonHighlight;
            labelMyWin.Location = new Point(140, 331);
            labelMyWin.Name = "labelMyWin";
            labelMyWin.Size = new Size(81, 32);
            labelMyWin.TabIndex = 8;
            labelMyWin.Text = "Win: 0";
            // 
            // labelOpponentWin
            // 
            labelOpponentWin.Anchor = AnchorStyles.None;
            labelOpponentWin.AutoSize = true;
            labelOpponentWin.ForeColor = SystemColors.ButtonHighlight;
            labelOpponentWin.Location = new Point(706, 102);
            labelOpponentWin.Name = "labelOpponentWin";
            labelOpponentWin.Size = new Size(81, 32);
            labelOpponentWin.TabIndex = 9;
            labelOpponentWin.Text = "Win: 0";
            // 
            // InMatch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1040, 576);
            Controls.Add(labelOpponentWin);
            Controls.Add(labelMyWin);
            Controls.Add(labelOpponentEmail);
            Controls.Add(labelMyEmail);
            Controls.Add(buttonBao);
            Controls.Add(buttonBua);
            Controls.Add(buttonKeo);
            Controls.Add(pictureBoxPlayer);
            Controls.Add(pictureBoxOpponent);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
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
        private Label labelMyWin;
        private Label labelOpponentWin;
    }
}
