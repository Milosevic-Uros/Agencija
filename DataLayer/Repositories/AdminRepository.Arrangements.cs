using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class AdminRepository : IAdminRepository
    {
        public List<Arrangement> GetAllArrangements()
        {
            List<Arrangement> ListOfArrangements = new List<Arrangement>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT a.arrangement_id,a.name,a.date_of_departure,a.return_date,l.location_id,a.type_of_transport,a.type_of_arrangement,a.number_of_vacancies,a.description,a.price\r\nFROM ARRANGEMENTS a JOIN LOCATIONS l ON a.location_id=l.location_id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Arrangement arrangement = new Arrangement();
                    arrangement.arrangementId = reader.GetInt32(0);
                    arrangement.name = reader.GetString(1);
                    arrangement.dateOfDeparture = reader.GetDateTime(2);
                    arrangement.returnDate = reader.GetDateTime(3);
                    arrangement.locationId = reader.GetInt32(4);
                    arrangement.typeofTransport = reader.GetString(5);
                    arrangement.typeOfArrangement = reader.GetString(6);
                    arrangement.numberOfVacancies = reader.GetInt32(7);
                    arrangement.description = reader.GetString(8);
                    arrangement.price = reader.GetDecimal(9);
                    ListOfArrangements.Add(arrangement);
                }
                reader.Close();
                connection.Close();

                return ListOfArrangements;
            }
        }
        public List<Arrangement> GetArrangementsOfType(string type)
        {
            List<Arrangement> ListOfArrangements = new List<Arrangement>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT a.arrangement_id,a.name,a.date_of_departure,a.return_date,l.location_id,a.type_of_transport,a.type_of_arrangement,a.number_of_vacancies,a.description,a.price FROM ARRANGEMENTS a JOIN LOCATIONS l ON a.location_id=l.location_id WHERE type_of_arrangement=@typeOfArrangement";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@typeOfArrangement", type);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Arrangement arrangement = new Arrangement();
                    arrangement.arrangementId = reader.GetInt32(0);
                    arrangement.name = reader.GetString(1);
                    arrangement.dateOfDeparture = reader.GetDateTime(2);
                    arrangement.returnDate = reader.GetDateTime(3);
                    arrangement.locationId = reader.GetInt32(4);
                    arrangement.typeofTransport = reader.GetString(5);
                    arrangement.typeOfArrangement = reader.GetString(6);
                    arrangement.numberOfVacancies = reader.GetInt32(7);
                    arrangement.description = reader.GetString(8);
                    arrangement.price = reader.GetDecimal(9);
                    ListOfArrangements.Add(arrangement);
                }
                reader.Close();
                connection.Close();

                return ListOfArrangements;
            }
        }
        public int UpdateArrangement(Arrangement arrangement)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ARRANGEMENTS SET date_of_departure=CAST(@dateOfDeparture AS DATETIME),return_date=CAST(@returnDate AS DATETIME) WHERE arrangement_id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dateOfDeparture", arrangement.dateOfDeparture);
                command.Parameters.AddWithValue("@returnDate", arrangement.returnDate);
                command.Parameters.AddWithValue("@id", arrangement.arrangementId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public int InsertArrangement(Arrangement arrangement)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ARRANGEMENTS (name,date_of_departure,return_date,location_id,type_of_transport,type_of_arrangement,number_of_vacancies,description,price) VALUES(@name,@dateOfDeparture,@returnDate,@locationId,@typeOfTransport,@typeOfArrangement,@numberOfVacancies,@description,@price)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", arrangement.name);
                command.Parameters.AddWithValue("@date_of_departure", arrangement.dateOfDeparture);
                command.Parameters.AddWithValue("@return_date", arrangement.returnDate);
                command.Parameters.AddWithValue("@location_id", arrangement.locationId);
                command.Parameters.AddWithValue("@type_of_transport", arrangement.typeofTransport);
                command.Parameters.AddWithValue("@type_of_arrangement", arrangement.typeOfArrangement);
                command.Parameters.AddWithValue("@number_of_vacancies", arrangement.numberOfVacancies);
                command.Parameters.AddWithValue("@description", arrangement.description);
                command.Parameters.AddWithValue("@price", arrangement.price);
                command.Parameters.AddWithValue("@id", arrangement.arrangementId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public Arrangement GetArrangement(int arrangementId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM ARRANGEMENTS WHERE arrangement_id=@arrangementId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@arrangementId", arrangementId);
                connection.Open();
                Arrangement arrangement = new Arrangement();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    arrangement.arrangementId = reader.GetInt32(0);
                    arrangement.name = reader.GetString(1);
                    arrangement.dateOfDeparture = reader.GetDateTime(2);
                    arrangement.returnDate = reader.GetDateTime(3);
                    arrangement.locationId = reader.GetInt32(4);
                    arrangement.typeofTransport = reader.GetString(5);
                    arrangement.typeOfArrangement = reader.GetString(6);
                    arrangement.numberOfVacancies = reader.GetInt32(7);
                    arrangement.description = reader.GetString(8);
                    arrangement.price = reader.GetDecimal(9); 
                }
                reader.Close();
                connection.Close();
                return arrangement;
            }
        }
        public int DeleteArrangement(int arrangementId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ARRANGEMENTS WHERE arrangement_id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", arrangementId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
    }
}
