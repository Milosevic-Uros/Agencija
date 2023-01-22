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
        public int UpdateAdmin(Admin admin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ADMIN SET email=@email, @password=@password WHERE admin_id=@admin_id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", admin.email);
                command.Parameters.AddWithValue("@password", admin.password);
                command.Parameters.AddWithValue("@admin_id", admin.adminId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;

            }
        }
        public List<Client> GetAllUsers()
        {
            List<Client> ListofUsers = new List<Client>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USERS";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client user = new Client();
                    user.userId = reader.GetInt32(0);
                    user.firstName = reader.GetString(1);
                    user.lastName = reader.GetString(2);
                    user.idNumber = reader.GetString(3);
                    user.uniqueIdNumber = reader.GetString(4);
                    user.passportNumber = reader.GetString(5);
                    user.phoneNumber=reader.GetString(6);
                    user.address = reader.GetString(7);
                    user.email = reader.GetString(8);
                    user.password = reader.GetString(9);
                    ListofUsers.Add(user);
                }
                reader.Close();
                connection.Close();

                return ListofUsers;
            }
        }
        public int UpdateUser(Client user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE u WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", doc.Status);


                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;

            }
        }
        public int InsertUser(Client user)
        {
            throw new NotImplementedException();
        }
        public Client GetUser(string email, string password)
        {
            throw new NotImplementedException();
        }
        public int DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
