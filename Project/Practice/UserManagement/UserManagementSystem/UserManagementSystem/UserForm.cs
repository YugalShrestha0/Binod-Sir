using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystem
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            dgvUserDetails.DataSource = u.getAllUsers();
        }
        User u = new User();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool rs = u.manageUser(0, txtUserName.Text, txtPassword.Text, cmbRole.Text, 1);
                if (rs == true)
                {
                    MessageBox.Show("User Successfully Added");
                    dgvUserDetails.DataSource = u.getAllUsers();
                }
                else
                {
                    MessageBox.Show("Error in adding User");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
