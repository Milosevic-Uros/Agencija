using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class AdminRepository : IAdminRepository
    {
        string connectionString = Constants.ConnectionString;

        public Admin GetAdmin(string email, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ADMINS WHERE email=@email AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password",password);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                Admin admin = new Admin();
                while (reader.Read())
                {
                    admin.adminId = reader.GetInt32(0);
                    admin.name = reader.GetString(1);
                    admin.lastName = reader.GetString(2);
                    admin.email = reader.GetString(3);
                    admin.password = reader.GetString(4);
                }
                reader.Close();
                connection.Close();

                return admin;
            }
        }
        public List<Client> GetAllClients()
        {
            List<Client> ListofClients = new List<Client>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CLIENTS";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.clientId = reader.GetInt32(0);
                    client.firstName = reader.GetString(1);
                    client.lastName = reader.GetString(2);
                    client.idNumber = reader.GetString(3);
                    client.uniqueIdNumber = reader.GetString(4);
                    client.passportNumber = reader.GetString(5);
                    client.phoneNumber=reader.GetString(6);
                    client.address = reader.GetString(7);
                    client.email = reader.GetString(8);
                    client.password = reader.GetString(9);
                    ListofClients.Add(client);
                }
                reader.Close();
                connection.Close();

                return ListofClients;
            }
        }
        public int UpdateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE CLIENTS SET phone_number=@phoneNumber,email=@email,password=@password WHERE client_id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@phoneNumber", client.phoneNumber);
                    command.Parameters.AddWithValue("@email", client.email);
                    command.Parameters.AddWithValue("@password", client.password);
                    command.Parameters.AddWithValue("@id", client.clientId);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int InsertClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CLIENTS (first_name,last_name,id_number,unique_id_number,passport_number,phone_number,address,email,password) VALUES(@firstName,@lastName,@idNumber,@jmbg,@passportNumber,@phoneNumber,@address,@email,@password)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@firstName", client.firstName);
                    command.Parameters.AddWithValue("@lastName", client.lastName);
                    command.Parameters.AddWithValue("@idNumber", client.idNumber);
                    command.Parameters.AddWithValue("@jmbg", client.uniqueIdNumber);
                    command.Parameters.AddWithValue("@passportNumber", client.passportNumber);
                    command.Parameters.AddWithValue("@phoneNumber", client.phoneNumber);
                    command.Parameters.AddWithValue("@address", client.address);
                    command.Parameters.AddWithValue("@email", client.email);
                    command.Parameters.AddWithValue("@password", client.password);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public Client GetClient(string email, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM CLIENTS WHERE email=@email AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                Client client = new Client();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    client.clientId = reader.GetInt32(0);
                    client.firstName = reader.GetString(1);
                    client.lastName = reader.GetString(2);
                    client.idNumber = reader.GetString(3);
                    client.uniqueIdNumber = reader.GetString(4);
                    client.passportNumber = reader.GetString(5);
                    client.phoneNumber = reader.GetString(6);
                    client.address = reader.GetString(7);
                    client.email = reader.GetString(8);
                    client.password = reader.GetString(9);
                }
                reader.Close();
                connection.Close();
                return client;
            }
        }
        public int DeleteClient(int clientId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM CLIENTS WHERE client_id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", clientId);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}