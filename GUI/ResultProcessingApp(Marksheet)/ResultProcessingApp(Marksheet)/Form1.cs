using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultProcessingApp_Marksheet_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;
        double fullMark = 0, totalObtained=0;
        bool x = true;
        private void btnAddToMarksheet_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtObtainedMark.Text) > 100)
            {
                MessageBox.Show("This is invalid marks");
            }
            n++;
            fullMark += 100;
            double obtainedMark = double.Parse(txtObtainedMark.Text);
            string status = "";

            totalObtained += obtainedMark;

            if(obtainedMark >= 45)
            {
                status = "Pass";
            }
            else
            {
                status = "Fail"; 
                x = false; 
            }

            string subjectName = txtSubjectName.Text;
            dgvMarksheet.Rows.Add(n, subjectName, 100, 45, obtainedMark,status);
        }

        private void btnCalculatePercentageAndGrade_Click(object sender, EventArgs e)
        {
            double percentage = totalObtained / fullMark * 100;
            lblPercentage.Text = percentage.ToString();
            string grade = "";

            if(percentage >=80 && x==true)
            {
                grade = "Distinction";
            }
            else if(percentage >=60 && percentage<80 && x==true)
            {
                grade = "Merit";
            }
            else if (percentage >= 45 && percentage < 60 && x == true)
            {
                grade = "Pass";
            }
            else
            {
                grade = "Failed";
            }
            lblGrade.Text = grade;
        }
    }
}
