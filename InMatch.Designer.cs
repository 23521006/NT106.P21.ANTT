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
            labelPlayerScore = new Label();
            labelOpponentScore = new Label();
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
            // labelPlayerScore
            // 
            labelPlayerScore.Anchor = AnchorStyles.None;
            labelPlayerScore.AutoSize = true;
            labelPlayerScore.ForeColor = SystemColors.ButtonHighlight;
            labelPlayerScore.Location = new Point(140, 299);
            labelPlayerScore.Name = "labelPlayerScore";
            labelPlayerScore.Size = new Size(152, 32);
            labelPlayerScore.TabIndex = 5;
            labelPlayerScore.Text = "Your Score: 0";
            // 
            // labelOpponentScore
            // 
            labelOpponentScore.Anchor = AnchorStyles.None;
            labelOpponentScore.AutoSize = true;
            labelOpponentScore.ForeColor = SystemColors.ButtonHighlight;
            labelOpponentScore.Location = new Point(706, 70);
            labelOpponentScore.Name = "labelOpponentScore";
            labelOpponentScore.Size = new Size(230, 32);
            labelOpponentScore.TabIndex = 7;
            labelOpponentScore.Text = "Opponent's Score: 0";
            // 
            // InMatch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1040, 576);
            Controls.Add(labelOpponentScore);
            Controls.Add(labelPlayerScore);
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
        private Label labelPlayerScore;
        private Label labelOpponentScore;
    }
}
