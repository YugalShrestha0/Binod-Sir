using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMoveOnKeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        int score = 0;
        int x, y;
        Random r = new Random();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            r.Next(100);

            if (e.KeyCode == Keys.Up) {pbImage.Top -= 5;}

            if (e.KeyCode == Keys.Down) {pbImage.Top += 5;}

            if (e.KeyCode == Keys.Left) {pbImage.Left -= 5;}

            if (e.KeyCode == Keys.Right) {pbImage.Left += 5;}

            if (pbImage.Bounds.IntersectsWith(pbImageSecond.Bounds))
            {
                x = r.Next(this.Width);
                y = r.Next(this.Width);

                pbImageSecond.Location = new Point(x, y);

                score++;
                lblScore.Text = score.ToString();
            }
        }

        

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
    }
}
