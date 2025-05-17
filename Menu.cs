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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonMatching_Click(object sender, EventArgs e)
        {
            labelMatching.Text = "Đang tìm đối thủ...";
            new InMatch().ShowDialog();
        }
    }
}
