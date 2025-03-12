using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Market.DataAccess
{
    public class DBContext
    {
        SqlConnection conn;

        public DBContext()
        {
            conn = new SqlConnection("server= DESKTOP-JEJ8BBV; Database= Market; Trusted_Connection= True; TrustServerCertificate= True");
        }
        // select disconnected
        public DataTable ExecuteQuery(string sqlCommand)
        {
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand= new SqlCommand(sqlCommand,conn);
            adapter.Fill(result);
            return result;
        }
        // update , delete ,insert -> connected

        public int ExecuteNonQuery(string sqlCommand)
        {
            int rowsAffected = 0;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(sqlCommand,conn);
            try
            {
                conn.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //handle exception
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return rowsAffected;
            
        }
    }
}
