using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            pbPicture.Top -= 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pbPicture.Left -= 5;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            pbPicture.Top += 5;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            pbPicture.Left += 5;
        }
    }
}
