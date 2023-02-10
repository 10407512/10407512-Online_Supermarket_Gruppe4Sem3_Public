using DataAccess.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Transactions;

namespace DataAccess.DataAccess
{
    public class ProductDAO : DBConnection, IProductDAO
    {
        public IEnumerable<Product> GetAll()
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Product";

            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> list = new List<Product>();

            while (reader.Read())
            {
                Product product = new(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetDouble(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    reader.GetString(5)
                );
                
                list.Add(product);
            }
            conn.Close();
            return list;
        }

        public Product? GetByName(String name)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Product WHERE NAME = @name";
            cmd.Parameters.AddWithValue("name", name);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) { 
                Product product = new(

                     reader.GetString(0),
                     reader.GetString(1),
                     reader.GetDouble(2),
                     reader.GetString(3),
                     reader.GetInt32(4),
                     reader.GetString(5)
                 );
                return product;
            }
            return null;
        }

        public Product? GetByBarcode(String barcode)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Product WHERE BARCODE = @barcode";
            cmd.Parameters.AddWithValue("barcode", barcode);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Product product = new(
                     reader.GetString(0),
                     reader.GetString(1),
                     reader.GetDouble(2),
                     reader.GetString(3),
                     reader.GetInt32(4),
                     reader.GetString(5)
                 );
                return product;
            }
            return null;
        }

        public bool Insert(Product entity)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Product VALUES (@name, @brand, @price, @description, @stock, @barcode)";
            cmd.Parameters.AddWithValue("name", entity.Name);
            cmd.Parameters.AddWithValue("brand", entity.Brand);
            cmd.Parameters.AddWithValue("price", entity.Price);
            cmd.Parameters.AddWithValue("description", entity.Description);
            cmd.Parameters.AddWithValue("stock", entity.Stock);
            cmd.Parameters.AddWithValue("barcode", entity.Barcode);

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }

        public bool Update(Product entity, string barcode)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Product SET " +
                "Name = @name, " +
                "Brand = @brand, " +
                "Price = @price, " +
                "Description = @description, " +
                "Stock = @stock Where Barcode = @barcode";
            cmd.Parameters.AddWithValue("Name", entity.Name);
            cmd.Parameters.AddWithValue("Brand", entity.Brand);
            cmd.Parameters.AddWithValue("Price", entity.Price);
            cmd.Parameters.AddWithValue("Description", entity.Description);
            cmd.Parameters.AddWithValue("Stock", entity.Stock);
            cmd.Parameters.AddWithValue("Barcode", barcode); //Barcode can't be updated, but needs to be written anyway when updating other attributes.

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }

        public bool UpdateStock(Product entity, string barcode)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Product SET Stock = @stock Where Barcode = @barcode";
            cmd.Parameters.AddWithValue("Stock", entity.Stock);
            cmd.Parameters.AddWithValue("Barcode", barcode); //Barcode can't be updated, but needs to be written anyway when updating other attributes.

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }

        public bool Delete(Product entity)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Product WHERE Barcode = @barcode";
            cmd.Parameters.AddWithValue("Barcode", entity.Barcode);
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }

        public bool CheckStock(string barcode, int quantity, SqlTransaction transaction)
        {
            var isAvailable = false;
            SqlCommand cmd = transaction.Connection.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = "SELECT CAST(CASE WHEN stock >= 0 AND @quantity <= stock THEN 1 ELSE 0 end as bit) FROM Product WHERE barcode = @barcode";
            cmd.Parameters.AddWithValue("barcode", barcode);
            cmd.Parameters.AddWithValue("quantity", quantity);
            isAvailable = Convert.ToBoolean(cmd.ExecuteScalar());
            return isAvailable;
        }

        public bool ReduceStock(string barcode, int quantity, SqlTransaction transaction)
        {
            SqlCommand cmd = transaction.Connection.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandText = "UPDATE Product SET Stock-= @quantity Where Barcode = @barcode";
            cmd.Parameters.AddWithValue("Quantity", quantity);
            cmd.Parameters.AddWithValue("Barcode", barcode); //Barcode can't be updated, but needs to be written anyway when updating other attributes.

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }
    }
}
