using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gameSpeed = 10;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;

            if (e.KeyCode == Keys.Up) { pbLogo.Top -= 10; }

            if (e.KeyCode == Keys.Down) { pbLogo.Top += 10; }

            if (e.KeyCode == Keys.Left) { pbLogo.Left -= 10; }

            if (e.KeyCode == Keys.Right) { pbLogo.Left += 10; }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveup(gameSpeed);
        }

        void moveup(int speed)
        {
            if (pbLogo.Top + pbLogo.Height > 0) { pbLogo.Top -= speed; } else { pbLogo.Top = 650; }
            if (pbLogo.Top + pbLogo.Height > 0) { pbLogo.Top -= speed; } else { pbLogo.Top = 650; }
            if (pbLogo.Top + pbLogo.Height > 0) { pbLogo.Top -= speed; } else { pbLogo.Top = 650; }
        }

        void moveUp(int Up)
        {

        }
    }
}
