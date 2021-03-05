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
    public partial class KeyPressDirectFromKeyboard : Form
    {
        public KeyPressDirectFromKeyboard()
        {
            InitializeComponent();
        }

        private void pbAlien_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void KeyPressDirectFromKeyboard_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                MessageBox.Show("You pressed theup keys!!!");
            }
            if(e.KeyCode == Keys.Down)
            {
                pbAlien.Top += 10;
            }
            if(e.KeyCode == Keys.Left)
            {
                pbAlien.Left -= 10;
            }
            if(e.KeyCode == Keys.Right)
            {
                pbAlien.Left += 10;
            }
        }
    }
}
