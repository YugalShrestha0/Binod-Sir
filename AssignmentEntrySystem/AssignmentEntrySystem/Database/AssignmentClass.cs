using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentEntrySystem.Database
{
    class AssignmentClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public bool manageassignment(int AssignmentID,
            String Program,
            String SubjectName,
            String AssignmentTitle,
            String ReleaseDate,
            String SubmittedDate, int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageAssignment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AssignmentID", AssignmentID);
                cmd.Parameters.AddWithValue("@Program", Program);
                cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
                cmd.Parameters.AddWithValue("@AssignmentTitle", AssignmentTitle);
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                cmd.Parameters.AddWithValue("@SubmittedDate", SubmittedDate);
                cmd.Parameters.AddWithValue("@mode", mode);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable getAllAUsers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from AssignmentTable", conn);
                DataTable dt = new DataTable();

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
