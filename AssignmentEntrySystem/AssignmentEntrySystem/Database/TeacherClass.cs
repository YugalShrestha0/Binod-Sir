using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentEntrySystem.Database
{
    class TeacherClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public bool manageteacher(int ID,
            string TeachersID,
            String TeacherName,
            String Department,
            String Post, int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageTeacher", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@TeacherID", TeachersID);
                cmd.Parameters.AddWithValue("@TeacherName", TeacherName);
                cmd.Parameters.AddWithValue("@Department", Department);
                cmd.Parameters.AddWithValue("@Post", Post);
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
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public DataTable getAllTUsers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from TeacherTable", conn);
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
