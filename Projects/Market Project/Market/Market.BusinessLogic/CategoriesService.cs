using Market.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BusinessLogic
{
    public class CategoriesService
    {
        DBContext dbContext;

        public CategoriesService()
        {
            dbContext = new DBContext();
        }

        public DataTable getCategories()
        {
            string command = $"SELECT  CategoryId AS [Category Id], CategoryName AS [Category Name] FROM Categories";
            return dbContext.ExecuteQuery(command);
        }

        public DataTable getCategoriesWithCounts()  
        {
            string command = "SELECT c.CategoryId AS [Category Id], c.CategoryName AS [Category Name], COUNT(p.ProductId) AS ProductCount FROM Categories c LEFT JOIN Products p ON c.CategoryId = p.CategoryId GROUP BY c.CategoryId ,c.CategoryName";
            return dbContext.ExecuteQuery(command);
        }

        public DataTable getCategoryBySearch(string categoryName)
        {
            string command = $"SELECT c.CategoryId AS [Category Id], c.CategoryName AS [Category Name], COUNT(p.ProductId) AS ProductCount FROM Categories c LEFT JOIN Products p ON c.CategoryId = p.CategoryId WHERE c.CategoryName LIKE '{categoryName}%' GROUP BY c.CategoryId ,c.CategoryName ";
            return dbContext.ExecuteQuery(command);
        }

        public DataTable getFavCategories()
        {
            string command = "SELECT TOP 3 c.CategoryName,COUNT(F.ProductId) AS FavouriteCount FROM Products p INNER JOIN Favourites f ON f.ProductId = p.ProductId INNER JOIN Categories c on p.CategoryId = c.CategoryId GROUP BY F.ProductId,C.CategoryName ORDER BY FavouriteCount DESC\r\n";
            return dbContext.ExecuteQuery(command);
        }
        public int getNumberOfCategories()
        {
            //int num = 0;
            string command = $"select count(*) from categories";
            return (int)dbContext.ExecuteQuery(command).Rows[0][0];
        }
        public int addCategory(string categoryName)
        {
            string command = $"INSERT INTO Categories(CategoryName) VALUES('{categoryName}')";
            return dbContext.ExecuteNonQuery(command);
        }

        public int updateCategory(int id, string categoryName)
        {
            string command = $"UPDATE Categories SET CategoryName='{categoryName}' WHERE CategoryId={id}";
            return dbContext.ExecuteNonQuery(command);
        }

        public int deleteCategory(int id)
        {
            string command = $"DELETE FROM Categories WHERE CategoryId={id}";
            return dbContext.ExecuteNonQuery(command);
        }

        public int getCategoryId(string categoryName)
        {
            string command = $"select CategoryId from Categories where CategoryName = '{categoryName}'";
            return (int)dbContext.ExecuteQuery(command).Rows[0][0];
        }

    }
}
