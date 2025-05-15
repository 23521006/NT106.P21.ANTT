namespace GiaoDienIngame
{
    public partial class Form1 : Form
    {
        int Chosen = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                if (textBox1.Text == "")
                {
                    if (Chosen == 0) MessageBox.Show("Anonymous không chọn!");
                    else if (Chosen == 1)
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Keo (P2).png");
                        MessageBox.Show("Anonymous chọn Kéo!");
                    }
                    else if (Chosen == 2)
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Bua (P2).png");
                        MessageBox.Show("Anonymous chọn Búa!");
                    }
                    else if (Chosen == 3)
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Bao (P2).png");
                        MessageBox.Show("Anonymous chọn Bao!");
                    }
                }
                else
                {
                    if (Chosen == 0) MessageBox.Show(textBox1.Text + " không chọn!");
                    else if (Chosen == 1)
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Keo (P2).png");
                        MessageBox.Show(textBox1.Text + " chọn Kéo!");
                    }
                    else if (Chosen == 2)
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Bua (P2).png");
                        MessageBox.Show(textBox1.Text + " chọn Búa!");
                    }
                    else if (Chosen == 3)
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Bao (P2).png");
                        MessageBox.Show(textBox1.Text + " chọn Bao!");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
            Chosen = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chosen = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chosen = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chosen = 3;
        }
    }
}
