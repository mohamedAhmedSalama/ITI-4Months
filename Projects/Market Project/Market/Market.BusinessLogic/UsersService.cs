using Market.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BusinessLogic
{
   
    public class UsersService
    {
        DBContext dbContext;

        public UsersService()
        {
           dbContext = new DBContext();
        }

        public int AddUser(string username, string password, string adddress, string role, string mail)
        {
            string command = $"INSERT INTO Users(UserName,Password,Address,Role,Email) VALUES('{username}','{password}','{adddress}','{role}','{mail}')";
            return dbContext.ExecuteNonQuery(command) ;
        }

        public int updateUser(int id, string username, string password, string adddress, string role)
        {
            string command = $"UPDATE USERS SET UserName='{username}',Password='{password}',Address='{adddress}',Role='{role}' WHERE UserId='{id}'";
            return dbContext.ExecuteNonQuery(command) ;
        }

        public int deleteUser(int id)
        {
            string command = $"DELETE FROM USERS WHERE UserId={id}";
            return dbContext.ExecuteNonQuery(command) ;
        }

        public int getNumberOfUsers()
        {
            string command = $"Select count(*) from Users where role='user'";
            return (int)dbContext.ExecuteQuery(command).Rows[0][0];
        }
        public DataTable GetUsers()
        {
            string command = "SELECT UserId AS [User ID], UserName AS [User Name], Address, Role FROM Users";
            return dbContext.ExecuteQuery(command) ;
        }

        public bool getUser(string userName, string password, out string role, out int id)
        {
            int rowCount = 0;
            DataTable dt = new DataTable();
            role = "";
            id = -1;
            try
            {
                string command = $"SELECT * FROM Users WHERE UserName='{userName}' AND password='{password}'";
               // Console.WriteLine(command);
                dt = dbContext.ExecuteQuery(command) ;
                rowCount = dt.Rows.Count;
                
                if (rowCount == 1)
                {
                    id= (int)dt.Rows[0]["UserId"];
                    role = (string)dt.Rows[0]["Role"];
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        

    }
}
