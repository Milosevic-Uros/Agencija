using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class ClientRepository : IClientRepository
    {
        public List<Arrangement> GetAllArrangements()
        {
            List<Arrangement> ListOfArrangements = new List<Arrangement>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT a.arrangement_id,a.name,a.date_of_departure,a.return_date," +
                    "l.location_id,a.type_of_transport,a.type_of_arrangement,a.number_of_vacancies,a.description,a.price  " +
                    "FROM CLIENTS_ARRANGEMENTS c JOIN ARRANGEMENTS a ON c.client_id=a.arrangement_id JOIN LOCATIONS l on a.location_id=l.location_id";
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

        public List<Arrangement> GetAllClientArrangements(Client client) 
        {
            List<Arrangement> ListOfArrangements = new List<Arrangement>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT  a.arrangement_id,a.name,a.date_of_departure,a.return_date,l.location_id,a.type_of_transport," +
                    "a.type_of_arrangement,a.number_of_vacancies,a.description,a.price " +
                    "FROM CLIENTS_ARRANGEMENTS c JOIN ARRANGEMENTS a ON c.arrangement_id=a.arrangement_id JOIN LOCATIONS l on a.location_id=l.location_id " +
                    "WHERE c.client_id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", client.clientId);
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
                string query = "SELECT a.arrangement_id,a.name,a.date_of_departure,a.return_date,l.location_id,a.type_of_transport," +
                    "a.type_of_arrangement,a.number_of_vacancies,a.description,a.price " +
                    "FROM CLIENTS_ARRANGEMENTS c JOIN ARRANGEMENTS a ON c.arrangement_id=a.arrangement_id JOIN LOCATIONS l on a.location_id=l.location_id " +
                    "WHERE a.type_of_arrangement=@typeOfArrangement";
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
        public Arrangement GetAClientArrangement(Client client, int arrangementId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT  a.arrangement_id,a.name,a.date_of_departure,a.return_date,l.location_id," +
                    "a.type_of_transport,a.type_of_arrangement,a.number_of_vacancies,a.description,a.price  " +
                    "FROM CLIENTS_ARRANGEMENTS c JOIN ARRANGEMENTS a ON c.arrangement_id=a.arrangement_id JOIN LOCATIONS l on a.location_id=l.location_id " +
                    "WHERE c.client_id=@clientId AND a.arrangement_id=@arrangementId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", client.clientId);
                command.Parameters.AddWithValue("@arrangementId", arrangementId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                Arrangement arrangement = new Arrangement();
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
        public int BookAnArrangement(int clientId,int arrangementId, int numberOfPeople)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CLIENTS_ARRANGEMENTS (arrangement_id,client_id,number_of_people) " +
                    "VALUES(@arrangementId,@clientId,@numOfPeople)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@arrangement_id", arrangementId);
                command.Parameters.AddWithValue("@client_id", clientId);
                command.Parameters.AddWithValue("@numOfPeople", numberOfPeople);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }


        
    }
}
