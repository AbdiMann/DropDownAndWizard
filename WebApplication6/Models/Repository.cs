using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Repository
    {
        string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["test"].ConnectionString;

        


        // Waa list-gii caadiga ahaa oo kale ee aan istcmaali jirnay dhincaga view ga ayuunbay wax isbadalayaan.

        public List<Customers> GetCustomerName()
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"SELECT *
                                        FROM CustomersTable
                                        ";
                //command.Parameters.AddWithValue("@username", username);
                connection.Open();
                var reader = command.ExecuteReader();
                var customers = new List<Customers>();
                while (reader.Read())
                    ff
                {
                    var customer = new Customers();
                    customer.Id = (int)reader["Id"];
                    customer.CustomerName = reader["CustomerName"] as string;
                    customer.CustomerAddress = reader["CustomerAddress"] as string;
                    customer.CustomerPhone = reader["CustomerPhone"] as string;
                    customers.Add(customer);
                }
                return customers;
            }
        }   

    }
}