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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            dgvTeacherDetails.DataSource = tc.getAllTUsers();
        }

        private void btnTClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Database.TeacherClass tc = new Database.TeacherClass();
        int ID = 0;
        private void btnTAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = tc.manageteacher(0, txtTeacherID.Text, txtTeacherName.Text, txtDepartment.Text, txtPost.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("Teacher Sucessfully Added");
                    dgvTeacherDetails.DataSource = tc.getAllTUsers();
                }
                else
                {
                    MessageBox.Show("Error in Adding Teacher");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTeacherDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvTeacherDetails.SelectedRows[0].Cells["ID"].Value.ToString());
            txtTeacherID.Text = dgvTeacherDetails.SelectedRows[0].Cells["TeacherID"].Value.ToString();
            txtTeacherName.Text = dgvTeacherDetails.SelectedRows[0].Cells["TeacherName"].Value.ToString();
            txtDepartment.Text = dgvTeacherDetails.SelectedRows[0].Cells["Department"].Value.ToString();
            txtPost.Text = dgvTeacherDetails.SelectedRows[0].Cells["Post"].Value.ToString();
        }

        private void btnTEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = tc.manageteacher(ID, txtTeacherID.Text, txtTeacherName.Text, txtDepartment.Text, txtPost.Text, 2);
                if (r == true)
                {
                    MessageBox.Show("Teacher Sucessfully Edited");
                    dgvTeacherDetails.DataSource = tc.getAllTUsers();
                }
                else
                {
                    MessageBox.Show("Error in Editing Teacher");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnTDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = tc.manageteacher(ID, txtTeacherID.Text, txtTeacherName.Text, txtDepartment.Text, txtPost.Text, 3);
                if (r == true)
                {
                    MessageBox.Show("Teacher Sucessfully Deleted");
                    dgvTeacherDetails.DataSource = tc.getAllTUsers();
                }
                else
                {
                    MessageBox.Show("Error in Deleting Teacher");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
