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
        public List<Location> GetLocations()
        {
            List<Location> ListOfLocations = new List<Location>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LOCATIONS";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Location location = new Location();
                    location.locationId = reader.GetInt32(0);
                    location.locationName = reader.GetString(1);

                    ListOfLocations.Add(location);
                }
                reader.Close();
                connection.Close();

                return ListOfLocations;
            }
        }
        public int UpdateLocation(Location location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE LOCATIONS SET location_name=@locationName WHERE location_id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@locationName", location.locationName);
                    command.Parameters.AddWithValue("@id", location.locationId);

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
        public int InsertLocation(Location location)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO LOCATIONS (location_id,location_name) VALUES (@locationId,@locationName)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@locationId", location.locationId);
                    command.Parameters.AddWithValue("@locationName", location.locationName);

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
        public Location GetLocation(int locationId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM LOCATIONS WHERE location_id=@locationId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@location_id", locationId);
                connection.Open();
                Location location = new Location();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    location.locationId = reader.GetInt32(0);
                    location.locationName = reader.GetString(1);
                }
                reader.Close();
                connection.Close();
                return location;
            }
        }
        public int DeleteLocation(int locationId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM LOCATIONS WHERE location_id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", locationId);

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
