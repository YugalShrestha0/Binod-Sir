using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentEntrySystem.Database
{
    class ProgramClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public bool manageprogram(int ProgramID,
            String ProgramName,
            string ProgramCode,
            string Duration,
            string Description, int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageProgram", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProgramID", ProgramID);
                cmd.Parameters.AddWithValue("@ProgramName", ProgramName);
                cmd.Parameters.AddWithValue("@ProgramCode", ProgramCode);
                cmd.Parameters.AddWithValue("@Duration", Duration);
                cmd.Parameters.AddWithValue("@Description", Description);
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

        public DataTable getAllPUsers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from ProgramTable", conn);
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
