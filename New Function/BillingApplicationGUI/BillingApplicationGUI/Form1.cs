using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApplicationGUI
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

        int serial = 0;
        public void addtopurchaselist()
        {
            serial++;
            string PName = txtPName.Text;
            Double rate = double.Parse(txtRate.Text);
            double quantity = double.Parse(txtQuantity.Text);
            double amount = rate * quantity;
            dgvDetails.Rows.Add(serial, PName, rate, quantity, amount);
        }

        public double total()
        {
            double gt = 0;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                gt = gt + double.Parse(dgvDetails.Rows[i].Cells["Amount"].Value.ToString());
            }
            return gt;
        }

        public void NetAmount()
        {
            double dis = double.Parse(txtDiscount.Text);

        }

        private void btnAddtoPurchaseList_Click(object sender, EventArgs e)
        {
            addtopurchaselist();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            lblGrossTotal.Text = total().ToString();
        }
    }
}
