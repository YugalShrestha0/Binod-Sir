using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UserManagementSystem
{
    class User
    {
        SqlConnection conn = new SqlConnection(@"Data Source=YUGAL\MSSQLSERVER01;Initial Catalog=UserTable;Integrated Security=True");

        public bool manageUser(int UserID, String UserName, String Password, String Role, int mode)
        {
            bool result = false;

            try
            {
                string sql = "";

                switch (mode)
                {
                    case 1:
                        sql = @"insert into USerTable (UserName, Password, Role) values
                                                      (@UserName, @Password, @Role)";
                        break;

                    case 2:
                        sql = @"update UserTable set UserName = @UserName, Password = @Password, Role = @Role
                                               where UserID = @UserID";
                        break;

                    case 3:
                        sql = "Delete from UserTable where UserID = @UserID";
                        break;

                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Role", Role);

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

                throw ex;
            }
            finally { conn.Close(); }
            return result;
        }

        public DataTable getAllUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("Select from UserTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
            }
            catch (Exception a)
            {

                throw a;
            }
            finally { conn.Close(); }
            return dt;
        }
    }
}
