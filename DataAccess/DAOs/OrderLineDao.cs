using DataAccess.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class OrderLineDAO : DBConnection, IOrderLineDAO
    {
        public IEnumerable<OrderLine> GetAllOrderLinesOnOrder(int orderNo)
        {
            SqlConnection sqlConnection = new(_configuration.GetConnectionString("DefaultDbConnection"));
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM ORDERLINE WHERE order_orderNo = @orderNo";
            cmd.Parameters.AddWithValue("orderNo", orderNo);

            SqlDataReader reader = cmd.ExecuteReader();

            List<OrderLine> orderLines = new List<OrderLine>();
            ProductDAO productDao = new ProductDAO();
            while (reader.Read())
            {
                OrderLine orderLine = new OrderLine(
                    reader.GetInt32("quantity"),
                    reader.GetDouble("subTotal"),
                    productDao.GetByBarcode(reader.GetString("product_barcode"))
                    );
                orderLines.Add(orderLine);
            }
            sqlConnection.Close();

            return orderLines;
        }

        public bool Insert(int orderNo, OrderLine orderLine, SqlTransaction transaction, SqlConnection sqlConnection)
        {
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.Transaction = transaction;

            cmd.CommandText = "INSERT INTO [ORDERLINE] VALUES (@orderNo, @quantity, @subTotal, @barcode)";
            cmd.Parameters.AddWithValue("orderNo", orderNo);
            cmd.Parameters.AddWithValue("quantity", orderLine.Quantity);
            cmd.Parameters.AddWithValue("subTotal", orderLine.SubTotal);
            cmd.Parameters.AddWithValue("barcode", orderLine.Product.Barcode);

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }
    }
}

