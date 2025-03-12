using Market.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BusinessLogic
{
    public class FavouritesService
    {
        DBContext dbContext;
        
        public FavouritesService()
        {
            dbContext = new DBContext();
        }

        public DataTable getFavourites()
        {
            string command = $"SELECT UserId AS [User ID], ProductId AS [Product Id] FROM Favourites";
            return dbContext.ExecuteQuery(command);
        }

        public bool getFavourite(int userId, int productId)
        {
            string command = $"SELECT UserId AS [User ID], ProductId AS [Product Id] FROM Favourites WHERE UserId={userId} AND ProductId={productId}"; ;
            DataTable dt = new DataTable();
            int rowCount = -1;
            dt = dbContext.ExecuteQuery(command);
            rowCount = dt.Rows.Count;
            if(rowCount == 0 ) 
                return true;
            else
                return false;
        }

        public DataTable getFavouritesById(int id)
        {
            string command = $"select f.UserId,p.ProductName AS [Product Name], p.Price, c.CategoryId AS [Category Id] from Products p inner join Favourites f on p.ProductId = f.ProductId inner join Categories c on c.CategoryId = p.CategoryId WHERE f.UserId ={id}";
            return dbContext.ExecuteQuery(command);
        }

        public int addFavourites(int userId, int productId)
        {
            string command = $"INSERT INTO Favourites(UserId,ProductId) VALUES({userId},{productId})";
            return dbContext.ExecuteNonQuery(command);
        }



        public int updateFavourites(int userId, int productId, int newProduct)
        {
            string command = $"UPDATE Favourites SET ProductId={newProduct} WHERE UserId={userId} AND ProductId={productId}";
            return dbContext.ExecuteNonQuery(command);
        }

        public int deleteFavourites(int userId, int productId)
        {
            string command = $"DELETE FROM Favourites WHERE UserId={userId} AND ProductId={productId}";
            return dbContext.ExecuteNonQuery(command);
        }

        public int deleteFavouriteByProductName(int userid,string productName,int categoryid)
        {
            string command = $"delete from Favourites where UserId = {userid} and ProductId = (select ProductId from Products where ProductName ='{productName}' and CategoryId = {categoryid}) ";
            return dbContext.ExecuteNonQuery(command);
        }
    }
}
