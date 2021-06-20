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
    public partial class SubjectForm : Form
    {
        Database.ProgramClass pc = new Database.ProgramClass();
        public SubjectForm()
        {
            InitializeComponent();
            cmbSubProgram.DataSource = pc.getAllPUsers();
            cmbSubProgram.DisplayMember = "PRogramName";
            cmbSubProgram.ValueMember = "ProgamId";
            cmbSubProgram.SelectedIndex = -1;
            dgvSubjectDetails.DataSource = subc.getAllSubUsers();
        }

        private void btnSClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Database.SubjectClass subc = new Database.SubjectClass();
        int SubjectID = 0;
        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = subc.managesubject(0, txtSubjectName.Text, txtSubjectCode.Text, txtCredit.Text, cmbSubProgram.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("Subject Sucessfully Added");
                    dgvSubjectDetails.DataSource = subc.getAllSubUsers();
                }
                else
                {
                    MessageBox.Show("Error in Adding subject");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSubjectDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SubjectID = int.Parse(dgvSubjectDetails.SelectedRows[0].Cells["SubjectID"].Value.ToString());
            txtSubjectName.Text = dgvSubjectDetails.SelectedRows[0].Cells["SubjectName"].Value.ToString();
            txtSubjectCode.Text = dgvSubjectDetails.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
            txtCredit.Text = dgvSubjectDetails.SelectedRows[0].Cells["Credit"].Value.ToString();
            cmbSubProgram.Text = dgvSubjectDetails.SelectedRows[0].Cells["Program"].Value.ToString();
        }

        private void btnSubEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = subc.managesubject(SubjectID, txtSubjectName.Text, txtSubjectCode.Text, txtCredit.Text, cmbSubProgram.Text, 2);
                if (r == true)
                {
                    MessageBox.Show("Subject Sucessfully Edited");
                    dgvSubjectDetails.DataSource = subc.getAllSubUsers();
                }
                else
                {
                    MessageBox.Show("Error in editing subject");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = subc.managesubject(SubjectID, txtSubjectName.Text, txtSubjectCode.Text, txtCredit.Text, cmbSubProgram.Text, 3);
                if (r == true)
                {
                    MessageBox.Show("Subject Sucessfully Deleted");
                    dgvSubjectDetails.DataSource = subc.getAllSubUsers();
                }
                else
                {
                    MessageBox.Show("Error in deleting subject");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
