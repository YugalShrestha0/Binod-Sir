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
    public partial class StudentForm : Form
    {
        Database.ProgramClass pc = new Database.ProgramClass();
        public StudentForm()
        {
            InitializeComponent();
            cmbSProgram.DataSource = pc.getAllPUsers();
            cmbSProgram.DisplayMember = "ProgramName";
            cmbSProgram.ValueMember = "ProgamId";
            cmbSProgram.SelectedIndex = -1;
            dgvStudentDetails.DataSource = stc.getAllStUsers();
        }

        private void btnSClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Database.StudentClass stc = new Database.StudentClass();
        int StudentID = 0;
        private void btnSAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = stc.managestudent(0, txtStudentName.Text, txtClass.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, cmbSProgram.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("Student Sucessfully Added");
                    dgvStudentDetails.DataSource = stc.getAllStUsers();
                }
                else
                {
                    MessageBox.Show("Error in Adding Student");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvStudentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = int.Parse(dgvStudentDetails.SelectedRows[0].Cells["StudentID"].Value.ToString());
            txtStudentName.Text = dgvStudentDetails.SelectedRows[0].Cells["StudentName"].Value.ToString();
            txtClass.Text = dgvStudentDetails.SelectedRows[0].Cells["Class"].Value.ToString();
            txtAddress.Text = dgvStudentDetails.SelectedRows[0].Cells["Address"].Value.ToString();
            txtContact.Text = dgvStudentDetails.SelectedRows[0].Cells["Contact"].Value.ToString();
            txtEmail.Text = dgvStudentDetails.SelectedRows[0].Cells["Email"].Value.ToString();
            cmbSProgram.Text = dgvStudentDetails.SelectedRows[0].Cells["Program"].Value.ToString();
        }

        private void btnSEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = stc.managestudent(StudentID, txtStudentName.Text, txtClass.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, cmbSProgram.Text, 2);
                if (r == true)
                {
                    MessageBox.Show("Student Sucessfully Edited");
                    dgvStudentDetails.DataSource = stc.getAllStUsers();
                }
                else
                {
                    MessageBox.Show("Error in Editing Student");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = stc.managestudent(StudentID, txtStudentName.Text, txtClass.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, cmbSProgram.Text, 3);
                if (r == true)
                {
                    MessageBox.Show("Student Sucessfully Deleted");
                    dgvStudentDetails.DataSource = stc.getAllStUsers();
                }
                else
                {
                    MessageBox.Show("Error in Deleting Student");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
