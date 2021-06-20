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
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();
            dgvProgramDetails.DataSource = pc.getAllPUsers();
        }

        private void btnPClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Database.ProgramClass pc = new Database.ProgramClass();
        int ProgramID = 0;
        private void btnPAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = pc.manageprogram(0, txtProgramName.Text, txtProgramCode.Text, txtDuration.Text, txtDescription.Text, 1);
                if (r == true)
                {
                    MessageBox.Show("Program Sucessfully Added");
                    dgvProgramDetails.DataSource = pc.getAllPUsers();
                }
                else
                {
                    MessageBox.Show("Error in Adding Program");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvProgramDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgramID = int.Parse(dgvProgramDetails.SelectedRows[0].Cells["ProgamId"].Value.ToString());
            txtProgramName.Text = dgvProgramDetails.SelectedRows[0].Cells["ProgramName"].Value.ToString();
            txtProgramCode.Text = dgvProgramDetails.SelectedRows[0].Cells["ProgramCode"].Value.ToString();
            txtDuration.Text = dgvProgramDetails.SelectedRows[0].Cells["Duration"].Value.ToString();
            txtDescription.Text = dgvProgramDetails.SelectedRows[0].Cells["Description"].Value.ToString();
        }

        private void btnPEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = pc.manageprogram(ProgramID, txtProgramName.Text, txtProgramCode.Text, txtDuration.Text, txtDescription.Text, 2);
                if (r == true)
                {
                    MessageBox.Show("Program Sucessfully Edited");
                    dgvProgramDetails.DataSource = pc.getAllPUsers();
                }
                else
                {
                    MessageBox.Show("Error in Editing Program");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool r = pc.manageprogram(ProgramID, txtProgramName.Text, txtProgramCode.Text, txtDuration.Text, txtDescription.Text, 3);
                if (r == true)
                {
                    MessageBox.Show("Program Sucessfully Deleted");
                    dgvProgramDetails.DataSource = pc.getAllPUsers();
                }
                else
                {
                    MessageBox.Show("Error in Deleting Program");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
