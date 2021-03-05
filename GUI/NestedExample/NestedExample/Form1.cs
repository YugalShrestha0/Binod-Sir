using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Double percentage = Double.Parse(txtPercentage.Text);
            string grade = "";
            if(percentage>=80)
            {
                grade = "Distinction";
            }
            
            else if(percentage>=60 && percentage<80)
            {
                grade = "First Division";
            }

            else if(percentage>=45 && percentage<60)
            {
                grade = "Secon Division";
            }

            else if(percentage>=32 && percentage<45)
            {
                grade = "Third Division";
            }

            else
            {
                grade = "N/A";
            }

            lblGrade.Text = grade;
        }
    }
}
