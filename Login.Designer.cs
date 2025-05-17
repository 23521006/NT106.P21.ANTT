namespace GameNT106
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(384, 117);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(384, 216);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Location = new Point(384, 152);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(241, 39);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(384, 251);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(241, 39);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.AutoSize = true;
            buttonLogin.Location = new Point(384, 328);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(241, 42);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "ĐĂNG NHẬP";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.None;
            buttonRegister.AutoSize = true;
            buttonRegister.Location = new Point(384, 376);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(241, 42);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "ĐĂNG KÝ";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1040, 576);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Kéo Búa Bao GAME";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonRegister;
    }
}