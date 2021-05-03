using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            dgvUserDetails.DataSource = u.getAllUsers();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
        User u = new User();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = u.manageUser(0, txtUserName.Text, txtPassword.Text, cmbRole.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("User Successfully Added");
                    dgvUserDetails.DataSource = u.getAllUsers();
                }
                else
                {
                    MessageBox.Show("Error in adding user");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
