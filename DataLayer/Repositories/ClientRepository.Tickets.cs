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
        public List<Object> GetAllClientTickets(Client client)
        {
            List<Object> ListOfTickets = new List<Object>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT t.ticket_id,t.name,t.date_of_departure,t.return_date,l.location_name,t.type_of_transport,t.price,c.number_of_people FROM CLIENTS_TICKETS c JOIN TICKETS t on c.ticket_id=t.ticket_id JOIN LOCATIONS l ON t.location_id=l.location_id WHERE client_id=@clientId;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@clientId", client.clientId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id= reader.GetInt32(0);
                    string name = reader.GetString(1);
                    DateTime dateOfDeparture = reader.GetDateTime(2);
                    DateTime returnDate = reader.GetDateTime(3);
                    string locationName = reader.GetString(4);
                    string typeOfTransport = reader.GetString(5);
                    decimal price = reader.GetDecimal(6);
                    int numberOfTickets = reader.GetInt32(7);
                    Object ticket = new { id, name, dateOfDeparture, returnDate, locationName, typeOfTransport, price, numberOfTickets };
                    ListOfTickets.Add(ticket);
                }
                reader.Close();
                connection.Close();

                return ListOfTickets;
            }
        }

        public int BookATicket(Client client,int ticketId, int numberOfPeople)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO CLIENTS_TICKETS (ticket_id,client_id,number_of_people) VALUES(@ticketId,@clientId,@numOfPeople)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ticketId", ticketId);
                    command.Parameters.AddWithValue("@clientId", client.clientId);
                    command.Parameters.AddWithValue("@numOfPeople", numberOfPeople);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }catch
            {
                return 0;
            }
        }
    }
}
