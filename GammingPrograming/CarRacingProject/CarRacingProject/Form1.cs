using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gameSpeed = 150;
        Random r =new Random();
        int x, y;
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveRoads(gameSpeed);
            moveEnemies(gameSpeed);
            moveCoins(gameSpeed);
        }

        public void moveRoads(int speed)
        {
            if (pbRoad1.Top + pbRoad1.Height > 0) { pbRoad1.Top -= speed; } else { pbRoad1.Top = 650; }
            if (pbRoad2.Top + pbRoad1.Height > 0) { pbRoad2.Top -= speed; } else { pbRoad2.Top = 650; }
            if (pbRoad3.Top + pbRoad1.Height > 0) { pbRoad3.Top -= speed; } else { pbRoad3.Top = 650; }
        }

        public void moveEnemies(int speed)
        {
            if (pbE1.Top + pbE1.Height < 650) { pbE1.Top += speed; } else { pbE1.Top = 0; x = r.Next(100, 65); pbE1.Location = new Point(x, 0); }
            if (pbE2.Top + pbE2.Height < 650) { pbE2.Top += speed; } else { pbE2.Top = 0; x = r.Next(200, 175); pbE2.Location = new Point(x, 0); }
            if (pbE3.Top + pbE3.Height < 650) { pbE3.Top += speed; } else { pbE3.Top = 0; x = r.Next(300, 369); pbE3.Location = new Point(x, 0); }
            if (pbE4.Top + pbE4.Height < 650) { pbE4.Top += speed; } else { pbE4.Top = 0; x = r.Next(450, 490); pbE4.Location = new Point(x, 0); }
            if (pbE5.Top + pbE5.Height < 650) { pbE5.Top += speed; } else { pbE5.Top = 0; x = r.Next(650, 130); pbE5.Location = new Point(x, 0); }
            if (pbE6.Top + pbE6.Height < 650) { pbE6.Top += speed; } else { pbE6.Top = 0; x = r.Next(775, 260); pbE6.Location = new Point(x, 0); }
            if (pbE7.Top + pbE1.Height < 650) { pbE7.Top += speed; } else { pbE7.Top = 0; x = r.Next(800, 350); pbE7.Location = new Point(x, 0); }
            if (pbE8.Top + pbE8.Height < 650) { pbE8.Top += speed; } else { pbE8.Top = 0; x = r.Next(1000, 450); pbE8.Location = new Point(x, 0); }
            if (pbE9.Top + pbE9.Height < 650) { pbE9.Top += speed; } else { pbE9.Top = 0; x = r.Next(1200, 550); pbE9.Location = new Point(x, 0); }
        }

        public void moveCoins(int speed)
        {
            if (pbK1.Top + pbK1.Height <650 ) { pbK1.Top += speed; } else { pbK1.Top = 0; }
            if (pbK2.Top + pbK2.Height < 650) { pbK2.Top += speed; } else { pbK2.Top = 0; }
            if (pbK3.Top + pbK3.Height < 650) { pbK3.Top += speed; } else { pbK3.Top = 0; }
            if (pbK4.Top + pbK4.Height < 650) { pbK4.Top += speed; } else { pbK4.Top = 0; }
            if (pbK5.Top + pbK5.Height < 650) { pbK5.Top += speed; } else { pbK5.Top = 0; }
            if (pbK6.Top + pbK6.Height < 650) { pbK6.Top += speed; } else { pbK6.Top = 0; }
            if (pbK7.Top + pbK7.Height < 650) { pbK7.Top += speed; } else { pbK7.Top = 0; }
            if (pbK8.Top + pbK8.Height < 650) { pbK8.Top += speed; } else { pbK8.Top = 0; }
            if (pbK9.Top + pbK9.Height < 650) { pbK9.Top += speed; } else { pbK9.Top = 0; }
            if (pbK10.Top + pbK10.Height < 650) { pbK10.Top += speed; } else { pbK10.Top = 0; }
            if (pbK11.Top + pbK11.Height < 650) { pbK11.Top += speed; } else { pbK11.Top = 0; }
            if (pbK12.Top + pbK12.Height < 650) { pbK12.Top += speed; } else { pbK12.Top = 0; }
            if (pbK13.Top + pbK13.Height < 650) { pbK13.Top += speed; } else { pbK13.Top = 0; }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
