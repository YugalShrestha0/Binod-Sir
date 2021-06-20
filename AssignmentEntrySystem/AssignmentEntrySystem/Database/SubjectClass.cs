using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentEntrySystem.Database
{
    class SubjectClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public bool managesubject(int SubjectID,
            string SubjectName,
            String SubjectCode,
            string Credit,
            String Program, int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageSubject", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
                cmd.Parameters.AddWithValue("@SubjectName", SubjectName);
                cmd.Parameters.AddWithValue("@SubjectCode", SubjectCode);
                cmd.Parameters.AddWithValue("@Credit", Credit);
                cmd.Parameters.AddWithValue("@Program", Program);
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

        public DataTable getAllSubUsers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from SubjectTable", conn);
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
