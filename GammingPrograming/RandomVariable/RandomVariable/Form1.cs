using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomVariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblInterval.Text = timer1.Interval.ToString();
        }
        Random r = new Random();
        private void btnRandomVariable_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 5;
            lblInterval.Text = timer1.Interval.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = r.Next(0, 1000);
            int y = r.Next(0, 1400);
            lblRandomVariableX.Text = x.ToString();
            lblRandomVariableY.Text = y.ToString();
            pbAlien.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval += 5;
            lblDecreaseSpeed.Text = timer1.Interval.ToString();
        }
    }
}
