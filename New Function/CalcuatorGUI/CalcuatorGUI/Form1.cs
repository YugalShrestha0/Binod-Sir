using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcuatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double first, second;

        void getvalue()
        {
            first = double.Parse(txtFirst.Text);
            second = double.Parse(txtSecond.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getvalue();
            double sum = first + second;
            lblResult.Text = sum.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            getvalue();
            double diff = first - second;
            lblResult.Text = diff.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            getvalue();
            double multiply = first * second;
            lblResult.Text = multiply.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtSecond.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            getvalue();
            double divide = first / second;
            lblResult.Text = divide.ToString();
        }
    }
}
