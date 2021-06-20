using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AssignmentEntrySystem.Database
{
    class UserClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public bool manageUsers(int UserID, 
            String FirstName, 
            string LastName, 
            string UserName, 
            string Password, 
            String Role, int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@FisrtName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Role", Role);
                cmd.Parameters.AddWithValue("@Mode", mode);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();

                if(result>0)
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

        public DataTable getAllUsers()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from UserTable", conn);
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

        public bool login(String UserName, String Password)
        {
            SqlCommand cmd = new SqlCommand("Select * from UserTable where UserName=@UserName and Password=@Password", conn);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            DataTable dt = new DataTable();

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
