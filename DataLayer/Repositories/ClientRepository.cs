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
    public partial class ClientRepository : IClientRepository
    {
        string connectionString = Constants.ConnectionString;
        public int UpdateInfo(Client client) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE CLIENTS SET first_name=@first_name,last_name=@last_name,id_number=@id_number," +
                    "unique_id_number=@uId,passport_number=@passportNumber,phone_number=@phoneNumber,address=@address," +
                    "email=@email WHERE client_id=@clientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@first_name",client.firstName);
                command.Parameters.AddWithValue("@last_name", client.lastName);
                command.Parameters.AddWithValue("@id_number", client.idNumber);
                command.Parameters.AddWithValue("@uId", client.uniqueIdNumber);
                command.Parameters.AddWithValue("@passportNumber", client.passportNumber);
                command.Parameters.AddWithValue("@phoneNumber", client.phoneNumber);
                command.Parameters.AddWithValue("@address", client.address);
                command.Parameters.AddWithValue("@email", client.email);
                command.Parameters.AddWithValue("@clientId", client.clientId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;

            }
        }
        public int ChangePassword(Client client) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE CLIENTS SET password=@password WHERE client_id=@clientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@password", client.password);
                command.Parameters.AddWithValue("@clientId", client.clientId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;

            }
        }
        public int DeleteClient(int clientId) 
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
    }
}
