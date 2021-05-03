using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentPractice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=YUGAL\MSSQLSERVER01;Initial Catalog=Test;Integrated Security=True");

        public bool manageProgram(int ProgramID, String ProgramTitle, String ProgramCode, String Duration, String Description, int mode)
        {
            bool result = false;
            return result;

            try
            {
                string sql = "";

                switch (mode)
                {
                    case 1:
                        sql = @"insert into Program(ProgramTitle, ProgramCode, Duration, Description) values
                                                    (@ProgramTitle, @ProgramCode, @Duration, @Description)";
                        break;

                    case 2:
                        sql = @"update Program set ProgramTitle = @ProgramTitle, ProgramCode = @ProgramCode, 
                                                   Duration = @Duration, Description = @Description Where 
                                                   ProgramID = @ProgramID";
                        break;

                    case 3:
                        sql = "Delete from Program Where ProgramID = @ProgramID";
                        break;
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProgramID", ProgramID);
                cmd.Parameters.AddWithValue("@ProgramTitle", ProgramTitle);
                cmd.Parameters.AddWithValue("@ProgramCode", ProgramCode);
                cmd.Parameters.AddWithValue("@Duration", Duration);
                cmd.Parameters.AddWithValue("@Description", Description);

                conn.Open();
                int rs = cmd.ExecuteNonQuery();
                conn.Close();

                if (rs > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally{ conn.Close(); }
            return result;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            bool r = manageProgram(0, txtProgramTitle.Text, txtProgramCode.Text, cmbDuration.Text, txtDescription.Text, 1);
            if (r == true)
            {
                MessageBox.Show("Program Successfully Added");
            }
            else
            {
                MessageBox.Show("Error in Adding Program");
            }
        }
    }

}
