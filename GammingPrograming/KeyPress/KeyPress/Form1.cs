using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            pbAlien.Top -= 10;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            pbAlien.Top += 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pbAlien.Left -= 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            pbAlien.Left += 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
