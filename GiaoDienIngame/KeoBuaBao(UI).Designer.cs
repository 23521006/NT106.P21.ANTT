namespace GiaoDienIngame
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            panel3 = new Panel();
            button4 = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 421);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(319, 225);
            label2.Name = "label2";
            label2.Size = new Size(163, 37);
            label2.TabIndex = 8;
            label2.Text = "OPPONENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 225);
            label1.Name = "label1";
            label1.Size = new Size(72, 37);
            label1.TabIndex = 7;
            label1.Text = "YOU";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(274, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(224, 206);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 206);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(353, 290);
            button3.Name = "button3";
            button3.Size = new Size(129, 102);
            button3.TabIndex = 2;
            button3.Text = "Bao";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(185, 290);
            button2.Name = "button2";
            button2.Size = new Size(129, 102);
            button2.TabIndex = 1;
            button2.Text = "Búa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(21, 290);
            button1.Name = "button1";
            button1.Size = new Size(129, 102);
            button1.TabIndex = 0;
            button1.Text = "Kéo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(516, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 206);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.default_avatar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 117);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(272, 92);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(progressBar1);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(516, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 209);
            panel3.TabIndex = 4;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(0, 47);
            button4.Name = "button4";
            button4.Size = new Size(272, 23);
            button4.TabIndex = 10;
            button4.Text = "START";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Nhập tên:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Keo Bua Bao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
    }
}
