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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            dgvUserDetails.DataSource = uc.getAllUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Database.UserClass uc = new Database.UserClass();
        int UserID = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = uc.manageUsers(0, txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, cmbRole.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("User Sucessfully Added");
                    dgvUserDetails.DataSource = uc.getAllUsers();
                }
                else
                {
                    MessageBox.Show("Error in Adding User");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUserDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = int.Parse(dgvUserDetails.SelectedRows[0].Cells["UserID"].Value.ToString());
            txtFirstName.Text = dgvUserDetails.SelectedRows[0].Cells["FirstName"].Value.ToString();
            txtLastName.Text = dgvUserDetails.SelectedRows[0].Cells["LastName"].Value.ToString();
            txtUserName.Text = dgvUserDetails.SelectedRows[0].Cells["UserName"].Value.ToString();
            txtPassword.Text = dgvUserDetails.SelectedRows[0].Cells["Password"].Value.ToString();
            txtConfirmPassword.Text = txtPassword.Text;
            cmbRole.Text = dgvUserDetails.SelectedRows[0].Cells["Role"].Value.ToString();
        }

        private void btnUEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = uc.manageUsers(UserID, txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, cmbRole.Text, 2);
                if (r == true)
                {
                    MessageBox.Show("User Sucessfully Edited");
                    dgvUserDetails.DataSource = uc.getAllUsers();
                }
                else
                {
                    MessageBox.Show("Error in Editing User");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = uc.manageUsers(UserID, txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, cmbRole.Text, 3);
                if (r == true)
                {
                    MessageBox.Show("User Sucessfully Deleted");
                    dgvUserDetails.DataSource = uc.getAllUsers();
                }
                else
                {
                    MessageBox.Show("Error in Deleting User");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
