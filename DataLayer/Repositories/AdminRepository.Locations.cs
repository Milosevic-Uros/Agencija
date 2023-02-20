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
    }
}
