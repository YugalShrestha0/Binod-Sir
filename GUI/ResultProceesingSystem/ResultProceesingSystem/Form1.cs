using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultProceesingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            bool ValidGrade = true;
            if(int.Parse(txtOProgramming.Text) > 100 || int.Parse(txtONetwork.Text) > 100 || int.Parse(txtOWD.Text) > 100 || int.Parse(txtOPP.Text) > 100)
            {
                MessageBox.Show("The obtained mark of any subject is invalid");
            }

            double programmingOmark = double.Parse(txtOProgramming.Text);
            double networkOmark = double.Parse(txtONetwork.Text);
            double ppOmark = double.Parse(txtOWD.Text);
            double wdOmark = double.Parse(txtOPP.Text);

            if(programmingOmark < 45 || networkOmark < 45 || ppOmark < 45 || wdOmark < 45)
            {
                ValidGrade = false;
            }

            double totalobtained = programmingOmark + networkOmark + ppOmark + wdOmark;
            double percent = totalobtained / 4;

            lblPercent.Text = percent.ToString();

            String grade = "N/A";
            if(percent >= 80 && ValidGrade == true)
            {
                grade = "Distinction";
            }
            else if(percent >=60 && percent < 80 && ValidGrade == true)
            {
                grade = "Merit";
            }
            else if(percent >= 45 && percent < 60 && ValidGrade == true)
            {
                grade = "Pass";
            }
            else
            {
                grade = "Failed";
            }

            lblGrade.Text = grade.ToString();
        }
    }
}
