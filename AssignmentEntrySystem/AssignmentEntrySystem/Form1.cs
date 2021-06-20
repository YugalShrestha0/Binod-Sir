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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramForm pf = new ProgramForm();
            pf.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm tf = new TeacherForm();
            tf.ShowDialog();
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectForm subf = new SubjectForm();
            subf.ShowDialog();
        }

        private void manageAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignmentForm af = new AssignmentForm();
            af.ShowDialog();
        }
    }
}
