using DataAccess.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class OrderDAO : DBConnection, IOrderDAO
    {
        public IEnumerable<Order> GetAll()
        {
            SqlConnection sqlConnection = new(_configuration.GetConnectionString("DefaultDbConnection"));
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM [ORDER]";

            SqlDataReader reader = cmd.ExecuteReader();

            List<Order> orders = new List<Order>();
            OrderLineDAO orderLineDao = new OrderLineDAO();
            while (reader.Read())
            {
                Order order = new Order(
                    reader.GetInt32("orderNo"),
                    reader.GetDouble("total"),
                    reader.GetDateTime("date"),
                    reader.GetBoolean("isReady"),
                    reader.GetBoolean("isCollected"),
                    reader.GetBoolean("isPaid"),
                    reader.IsDBNull("orderCreator") ? null : reader.GetString("orderCreator"),
                    reader.IsDBNull("Handler") ? null : reader.GetString("Handler"),
                    orderLineDao.GetAllOrderLinesOnOrder(reader.GetInt32("orderNo")).ToList()
                );
                orders.Add(order);
            }
            sqlConnection.Close();
            return orders;
        }

        public Order GetByOrderNo(int orderNo)
        {
            SqlConnection sqlConnection = new(_configuration.GetConnectionString("DefaultDbConnection"));
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM [ORDER] WHERE OrderNo = @orderNo";
            cmd.Parameters.AddWithValue("orderNo", orderNo);

            SqlDataReader reader = cmd.ExecuteReader();
            OrderLineDAO orderLineDao = new OrderLineDAO();
            Order order = null;
            if (reader.Read())
            {
                Order currOrder = new Order(
                    reader.GetInt32("orderNo"),
                    reader.GetDouble("total"),
                    reader.GetDateTime("date"),
                    reader.GetBoolean("isReady"),
                    reader.GetBoolean("isCollected"),
                    reader.GetBoolean("isPaid"),
                    reader.IsDBNull("orderCreator") ? null : reader.GetString("orderCreator"),
                    reader.IsDBNull("Handler") ? null : reader.GetString("Handler"),
                    orderLineDao.GetAllOrderLinesOnOrder(reader.GetInt32("orderNo")).ToList()
                );
                order = currOrder;
            }
            return order;
        }

        public bool Insert(Order entity)
        {
            //Creates connection to database
            SqlConnection sqlConnection = new(_configuration.GetConnectionString("DefaultDbConnection"));
            sqlConnection.Open();

            int attempts = 0;
            bool completedSuccessfully = false;

            while (!completedSuccessfully && attempts < entity.MaxAttempts)
            {
                //Start transaction
				SqlTransaction transaction = sqlConnection.BeginTransaction(IsolationLevel.RepeatableRead);
				SqlCommand cmd = sqlConnection.CreateCommand();
				cmd.Connection = sqlConnection;
				cmd.Transaction = transaction;

				try 
                {
					attempts++; //Increment attempts
					ProductDAO productDAO = new();
                    bool isAvailable = false;
                    foreach (var orderline in entity.OrderLines)
                    {
                        isAvailable = productDAO.CheckStock(orderline.Product.Barcode, orderline.Quantity, transaction);
                        if (isAvailable == false)
                        {
							throw new Exception("Not enough stock");
						}
                    }
					Thread.Sleep(5000); //used to intentionally get a deadlock and test multiple purchase attempts

					cmd.CommandText = "INSERT INTO [ORDER] VALUES (@total, @date, @isReady, @isColleceted, @isPaid, @orderCreatorKey, @handlerKey, @phoneNo, @email); SELECT @@IDENTITY";
                    cmd.Parameters.AddWithValue("total", entity.Total);
                    cmd.Parameters.AddWithValue("date", DateTime.Now);
                    cmd.Parameters.AddWithValue("isReady", false);
                    cmd.Parameters.AddWithValue("isColleceted", false);
                    cmd.Parameters.AddWithValue("isPaid", true);
                    cmd.Parameters.AddWithValue("orderCreatorKey", (object?)entity.OrderCreatorKey ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("handlerKey", (object?)entity.HandlerKey ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("phoneNo", (object?)entity.Person.PhoneNo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("email", entity.Person.Email);

					int orderNo = Convert.ToInt32(cmd.ExecuteScalar()); //Converts the returned object to int and assigns it to orderNo
					OrderLineDAO orderLineDao = new OrderLineDAO();
                    foreach (var orderline in entity.OrderLines)
                    {
						//Now we reduce stock and add orderlines
						productDAO.ReduceStock(orderline.Product.Barcode, orderline.Quantity, transaction);
                        orderLineDao.Insert(orderNo, orderline, transaction, sqlConnection);
                    }
					//Commit will only happen if all the above code runs without any errors
					//Rollback will happen if any of the above code throws an error
					transaction.Commit();
					completedSuccessfully = true;
					Console.WriteLine("Transaction completed successfully after " + attempts + " attempt/s");
					//Prints text to the console to show that the transaction was completed successfully
					sqlConnection.Close();
                }
                catch (Exception)
                {
					Console.WriteLine("Transaction failed, retrying... ");
				}
            }
            return completedSuccessfully;
        }

        
        public bool Update(int orderNo, Order entity)
        {
            SqlConnection sqlConnection = new(_configuration.GetConnectionString("DefaultDbConnection"));
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "UPDATE [ORDER] SET " +
                "isReady = @isReady, " +
                "isCollected = @isCollected " +
               "WHERE orderNo = @orderNo";
            cmd.Parameters.AddWithValue("isReady", entity.IsReady);
            cmd.Parameters.AddWithValue("isCollected", entity.IsColleceted);
            cmd.Parameters.AddWithValue("orderNo", orderNo);
			//cmd.Parameters.AddWithValue("total", entity.Total);
			//cmd.Parameters.AddWithValue("date", entity.Date);
			//cmd.Parameters.AddWithValue("isPaid", entity.IsPaid);
			//cmd.Parameters.AddWithValue("orderCreatorKey", entity.OrderCreatorKey);
			//cmd.Parameters.AddWithValue("handlerKey", entity.HandlerKey);

			//In case we want to update further attributes of the order table in the future we can uncomment the above lines and update query.
			int rowsAffected = cmd.ExecuteNonQuery();

            sqlConnection.Close();
            return rowsAffected == 1;
        }

        public bool Delete(int orderNo)
        {
            SqlConnection sqlConnection = new(_configuration.GetConnectionString("DefaultDbConnection"));
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "DELETE [ORDER] WHERE orderNo = @orderNo";
            cmd.Parameters.AddWithValue("orderNo", orderNo);

            int rowsAffected = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return rowsAffected == 1;
        }
    }
}
