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
    public partial class AssignmentForm : Form
    {
        Database.SubjectClass subc = new Database.SubjectClass();
        public AssignmentForm()
        {
            InitializeComponent();
            cmbASubjectName.DataSource = subc.getAllSubUsers();
            cmbASubjectName.DisplayMember = "SubjectName";
            cmbASubjectName.ValueMember = "SubjectID";
            cmbASubjectName.SelectedIndex = -1;
            dgvAssignmentDetails.DataSource = ac.getAllAUsers();
        }

        Database.ProgramClass pc = new Database.ProgramClass();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbAProgram.DataSource = pc.getAllPUsers();
            cmbAProgram.DisplayMember = "ProgramName";
            cmbAProgram.ValueMember = "ProgamId";
            cmbAProgram.SelectedIndex = -1;
        }

        Database.AssignmentClass ac = new Database.AssignmentClass();
        int AssignmentID = 0;
        private void btnACreate_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = ac.manageassignment(0, cmbAProgram.Text, cmbASubjectName.Text, txtAssignmentTitle.Text, dtpRealeaseDate.Text, dtpSubmittedDate.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("Assignment Sucessfully Added");
                    dgvAssignmentDetails.DataSource = ac.getAllAUsers();
                }
                else
                {
                    MessageBox.Show("Error in Adding Assignment");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAssignmentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignmentID = int.Parse(dgvAssignmentDetails.SelectedRows[0].Cells["AssignmentID"].Value.ToString());
            cmbAProgram.Text = dgvAssignmentDetails.SelectedRows[0].Cells["Program"].Value.ToString();
            cmbASubjectName.Text = dgvAssignmentDetails.SelectedRows[0].Cells["SubjectName"].Value.ToString();
            txtAssignmentTitle.Text = dgvAssignmentDetails.SelectedRows[0].Cells["AssignmentTitle"].Value.ToString();
            dtpRealeaseDate.Text = dgvAssignmentDetails.SelectedRows[0].Cells["ReleaseDate"].Value.ToString();
            dtpSubmittedDate.Text = dgvAssignmentDetails.SelectedRows[0].Cells["SubmittedDate"].Value.ToString();
        }

        private void btnAEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = ac.manageassignment(AssignmentID, cmbAProgram.Text, cmbASubjectName.Text, txtAssignmentTitle.Text, dtpRealeaseDate.Text, dtpSubmittedDate.Text, 2);
                if (r == true)
                {
                    MessageBox.Show("Assignment Sucessfully Edited");
                    dgvAssignmentDetails.DataSource = ac.getAllAUsers();
                }
                else
                {
                    MessageBox.Show("Error in editing Assignment");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnADelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = ac.manageassignment(AssignmentID, cmbAProgram.Text, cmbASubjectName.Text, txtAssignmentTitle.Text, dtpRealeaseDate.Text, dtpSubmittedDate.Text, 3);
                if (r == true)
                {
                    MessageBox.Show("Assignment Sucessfully Deleted");
                    dgvAssignmentDetails.DataSource = ac.getAllAUsers();
                }
                else
                {
                    MessageBox.Show("Error in deleting Assignment");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
