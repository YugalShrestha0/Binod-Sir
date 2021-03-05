using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FD_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        int counter = 0;
        int score = 0;
        ArrayList old = new ArrayList();
        ArrayList newData = new ArrayList();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbContent.Items.Add(txtValue.Text);
            old.Add(txtValue.Text);
            txtValue.Clear();
            txtValue.Focus();
            btnReAdd.Enabled = false;
            count++;

            if (count == 10)
            {
                btnAdd.Enabled = false;
                timer1.Enabled = true;
                count = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();

            if (counter == 10)
            {
                lbContent.Items.Clear();
                timer1.Enabled = false;
                btnReAdd.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnReAdd_Click(object sender, EventArgs e)
        {
            lbContent.Items.Add(txtValue.Text);
            newData.Add(txtValue.Text);
            txtValue.Clear();
            txtValue.Focus();

            count++;
            if (count == 10)
            {
                btnReAdd.Enabled = false;
            }
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
           
        }
       
        private void btnScore_Click(object sender, EventArgs e)
        {
            if (newData[count] == old[count])
            {
                lblScore.Text = score.ToString();
            }
        }
    }
}
