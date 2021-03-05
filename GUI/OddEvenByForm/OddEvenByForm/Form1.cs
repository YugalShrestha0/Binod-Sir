using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddEvenByForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNumber.Text);

            if (x % 2 == 0)
            {
                lblOddOrEven.Text = "Even Number";
                lblOddOrEven.ForeColor = Color.Green;
            }
            else
            {
                lblOddOrEven.Text = "Odd Number";
                lblOddOrEven.ForeColor = Color.Red;
            }

            Console.ReadLine();
        }
    }
}
