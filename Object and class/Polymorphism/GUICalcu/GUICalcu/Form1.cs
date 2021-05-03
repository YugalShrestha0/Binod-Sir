using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Arthemetic a = new Arthemetic();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double sum = a.calculator(double.Parse(txtFirst.Text), double.Parse(txtSecond.Text), 1);
            lblResult.Text = sum.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            double subtract = a.calculator(double.Parse(txtFirst.Text), double.Parse(txtSecond.Text), 2);
            lblResult.Text = subtract.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double multiply = a.calculator(double.Parse(txtFirst.Text), double.Parse(txtSecond.Text), 3);
            lblResult.Text = multiply.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double divide = a.calculator(double.Parse(txtFirst.Text), double.Parse(txtSecond.Text), 4);
            lblResult.Text = divide.ToString();
        }
    }
}
