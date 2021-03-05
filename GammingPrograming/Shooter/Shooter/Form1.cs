using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Shooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        Random r = new Random();
        int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = r.Next(120, 1200);
            y = r.Next(120, 700);

            picAlien.Location = new Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = score.ToString();

            if(score == 10)
            {
                MessageBox.Show("You won the game");
            }
        }
    }
}
