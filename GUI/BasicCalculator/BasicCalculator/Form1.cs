using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Double first = double.Parse(txtFirstNumber.Text);
            Double second = double.Parse(txtSecondNumber.Text);
            Double sum = first + second;
            lblResult.Text = sum.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Double first = double.Parse(txtFirstNumber.Text);
            Double second = double.Parse(txtSecondNumber.Text);
            Double Subtract = first - second;
            lblResult.Text = Subtract.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Double first = double.Parse(txtFirstNumber.Text);
            Double second = double.Parse(txtSecondNumber.Text);
            Double Multiply = first * second;
            lblResult.Text = Multiply.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Double first = double.Parse(txtFirstNumber.Text);
            Double second = double.Parse(txtSecondNumber.Text);
            Double Divide = first - second;
            lblResult.Text = Divide.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
