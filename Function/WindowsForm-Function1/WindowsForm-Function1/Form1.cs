using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Function1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        double totalamount = 0;
        int serial = 0;
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            serial++;
            string pname = txtProductName.Text;
            double rate = double.Parse(txtRate.Text);
            double quantity = double.Parse(txtQuantity.Text);
            double amount = rate * quantity;
            dgvData.Rows.Add(serial, pname, rate, quantity, amount);
            totalamount += amount;
            lblTotalBillingAmount.Text = totalamount.ToString();
        }

        public void clear()
        {
            txtProductName.Clear();
            txtRate.Clear();
            txtQuantity.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            dgvData.Rows.Clear();
            lblTotalBillingAmount.Text = "0";
        }
    }
}
