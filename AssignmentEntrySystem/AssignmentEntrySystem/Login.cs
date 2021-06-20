using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentEntrySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        Database.UserClass uc = new Database.UserClass();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = uc.login(txtLUserName.Text, txtLPassword.Text);
                if (r == true)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
