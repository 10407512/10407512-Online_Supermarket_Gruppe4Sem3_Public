using Microsoft.Data.SqlClient;
using DataAccess.Model;
using System.Data;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DataAccess
{
    public class PersonDAO : DBConnection, IPersonDAO
    {
        public IEnumerable<Person> GetAllEmployees()
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Person where role = 'Employee'";
            SqlDataReader reader = cmd.ExecuteReader();
            List<Person> list = new();

            while (reader.Read())
            {
                Person person = new()
                {
                    F_name = reader.GetString(0),
                    L_name = reader.GetString(1),
                    Email = reader.GetString(2),
                    PhoneNo = reader.GetString(3),
                    Role = reader.GetString(4),
                    UserName = reader.IsDBNull("UserName") ? null : reader.GetString(5)
                };
                list.Add(person);
            }
            conn.Close();
            return list;
        }


		//A method for future development, in case we save customer information to the database
        
		//public IEnumerable<Person> GetAllCustomers()
		//{
		//    SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
		//    conn.Open();

		//    SqlCommand cmd = conn.CreateCommand();
		//    cmd.CommandText = "Select * from Person where role = 'Guest'";
		//    SqlDataReader reader = cmd.ExecuteReader();
		//    List<Person> list = new();

		//    while (reader.Read())
		//    {
		//        Person person = new()
		//        {
		//            F_name = reader.GetString(0),
		//            L_name = reader.GetString(1),
		//            Email = reader.GetString(2),
		//            PhoneNo = reader.GetString(3),
		//            Role = reader.GetString(4),
		//            UserName = reader.IsDBNull("UserName") ? null : reader.GetString(5)
		//        };
		//        list.Add(person);
		//    }
		//    conn.Close();
		//    return list;
		//}

		public Person? GetByEmail(string email)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Person WHERE email = @email";
            cmd.Parameters.AddWithValue("email", email);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Person requestedPerson = new()
                {
                    F_name = reader.GetString(0),
                    L_name = reader.GetString(1),
                    Email = reader.GetString(2),
                    PhoneNo = reader.GetString(3),
                    Role = reader.GetString(4),
                    UserName = reader.IsDBNull("UserName") ? null : reader.GetString(5)
                };
                return requestedPerson;
            }
            return null;
        }

        public Person? GetByUserName(string? userName)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Person WHERE UserName = @username";
            cmd.Parameters.AddWithValue("userName", userName);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Person requestedPerson = new()
                {
                    F_name = reader.GetString(0),
                    L_name = reader.GetString(1),
                    Email = reader.GetString(2),
                    PhoneNo = reader.GetString(3),
                    Role = reader.GetString(4),
                    UserName = reader.IsDBNull("UserName") ? null : reader.GetString(5)
                };
                return requestedPerson;
            }
            return null;
        }


        public bool Insert(Person entity)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Person VALUES (@F_name, @L_name, @Email, @Phone, @Role, @UserName)";
            cmd.Parameters.AddWithValue("F_name", entity.F_name);
            cmd.Parameters.AddWithValue("L_name", entity.L_name);
            cmd.Parameters.AddWithValue("Email", entity.Email);
            cmd.Parameters.AddWithValue("Phone", entity.PhoneNo);
            cmd.Parameters.AddWithValue("Role", entity.Role);
            cmd.Parameters.AddWithValue("UserName", (object?)entity.UserName ?? DBNull.Value);


            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected == 1;
        }

        public bool Update(string email, Person entity)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE Person SET F_name = @f_name, L_name = @l_name, Email = @updatedEmail, PhoneNo = @phoneNo Where Email = @email";
                
            cmd.Parameters.AddWithValue("F_name", entity.F_name);
            cmd.Parameters.AddWithValue("L_name", entity.L_name);
            cmd.Parameters.AddWithValue("UpdatedEmail", entity.Email);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.Parameters.AddWithValue("PhoneNo", entity.PhoneNo);
            //cmd.Parameters.AddWithValue("Role", entity.Role);
            //cmd.Parameters.AddWithValue("UserName", entity.UserName);
            //cmd.Parameters.AddWithValue("UserName", entity ?? DBNull.Value);

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected == 1;
        }
        
        public bool Delete(Person entity, string Email)
        {
            SqlConnection conn = new(_configuration.GetConnectionString("DefaultDbConnection"));
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Person WHERE Email = @email";
            cmd.Parameters.AddWithValue("Email", entity.Email);

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected == 1;
        }
    }
}

