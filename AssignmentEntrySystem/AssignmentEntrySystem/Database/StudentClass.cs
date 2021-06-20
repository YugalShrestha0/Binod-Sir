using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentEntrySystem.Database
{
    class StudentClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public bool managestudent(int StudentID,
            String StudentName,
            String Class,
            string Address,
            string Contact,
            String Email,
            String Program, int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentID", StudentID);
                cmd.Parameters.AddWithValue("@StudentName", StudentName);
                cmd.Parameters.AddWithValue("@Class", Class);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@Email", Email);
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

        public DataTable getAllStUsers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from StudentTable", conn);
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
