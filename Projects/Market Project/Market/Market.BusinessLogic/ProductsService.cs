using Market.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BusinessLogic
{
    public class ProductsService
    {
        DBContext dBContext;

        public ProductsService()
        {
            dBContext = new DBContext();
        }

        public DataTable getProducts()
        {
            string command = $"SELECT ProductId AS [Product Id], ProductName AS [Product Name], Price, CategoryId AS [Category Id] FROM Products";
            return dBContext.ExecuteQuery(command);
        }

        public DataTable getProductBySearch(string productName)
        {
            string command = $"SELECT ProductId AS [Product Id], ProductName AS [Product Name], Price, CategoryId AS [Category Id] FROM Products WHERE ProductName LIKE '{productName}%'";
            return dBContext.ExecuteQuery(command);
        }

        public DataTable getFavouriteProducts()
        {
            string command = "SELECT TOP 3 P.ProductId,P.ProductName,c.CategoryName,COUNT(F.ProductId) AS FavouriteCount FROM Favourites F INNER JOIN Products P ON F.ProductId = P.ProductId INNER JOIN Categories c ON P.CategoryId = c.CategoryId GROUP BY P.ProductId, P.ProductName,c.CategoryName ORDER BY FavouriteCount DESC\r\n";
            return dBContext.ExecuteQuery(command);
        }
        public int getNumberOfProducts()
        {
            string command = $"select count(*) from Products";
            return (int)dBContext.ExecuteQuery(command).Rows[0][0];
        }
        public int addProduct(string productName, decimal price, int categoryid)
        {
            //remember validtion if there any
            string command = $"INSERT INTO PRODUCTS(ProductName,Price, CategoryId) VALUES ('{productName}',{price},{categoryid})";
            return dBContext.ExecuteNonQuery(command);
        }

        public int updateProduct(int id, string productName, decimal price, int categoryid)
        {
            //remember validtion if there any
            string command = $"UPDATE PRODUCTS SET ProductName='{productName}',Price={price},CategoryId={categoryid} WHERE ProductId={id}";
            return dBContext.ExecuteNonQuery(command);
        }

        public int deleteProduct(int id)
        {
            string command = $"DELETE FROM PRODUCTS WHERE ProductId={id}";
            return dBContext.ExecuteNonQuery(command);
        }




    }
}
