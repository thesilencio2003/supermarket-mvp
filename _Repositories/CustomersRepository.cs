using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CustomersModel customersModel)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES(@document, @firstname, @lastname, @address, @birthday,@phone,@email)";
                command.Parameters.Add("@document", SqlDbType.Int).Value = customersModel.Document;
                command.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = customersModel.FirstName;
                command.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = customersModel.lastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = customersModel.Date;
                command.Parameters.Add("@phone", SqlDbType.Int).Value = customersModel.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customersModel.Email;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE Customers_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomersModel customersModel)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers
                                        SET Customers_Document =@document,
                                        Customers_FirstName = @firstname,
                                        Customers_LastName = @lastname,
                                        Customers_Address = @address,
                                        Customers_Birthday = @birthday,
                                        Customers_Phone = @phone,
                                        Customers_Email = @email
                                        WHERE Customers_Id = @id";
                command.Parameters.Add("@document", SqlDbType.Int).Value = customersModel.Document;
                command.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = customersModel.FirstName;
                command.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = customersModel.lastName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = customersModel.Date;
                command.Parameters.Add("@phone", SqlDbType.Int).Value = customersModel.PhoneNumber;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customersModel.Email;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document = reader["Customers_Document"].ToString();
                        customersModel.FirstName = reader["Customers_FirstName"].ToString();
                        customersModel.lastName = reader["Customers_LastName"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Date = reader.GetDateTime(reader.GetOrdinal("Customers_Birthday"));
                        customersModel.PhoneNumber = reader["Customers_Phone"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();


                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {

            var customersList = new List<CustomersModel>();
            int customersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersFirstName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers
                                        WHERE Customers_Id=@id or Customers_FirstName LIKE @firstname+ '%'
                                        ORDER By Customers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = customersFirstName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document = reader["Customers_Document"].ToString();
                        customersModel.FirstName = reader["Customers_FirstName"].ToString();
                        customersModel.lastName = reader["Customers_LastName"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Date = reader.GetDateTime(reader.GetOrdinal("Customers_Birthday"));
                        customersModel.PhoneNumber = reader["Customers_Phone"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customersList.Add(customersModel);

                    }
                }
            }
            return customersList;
        }





    }
}
