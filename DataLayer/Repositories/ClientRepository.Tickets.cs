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
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> ListOfTickets = new List<Ticket>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT t.ticket_id,t.name,t.date_of_departure,t.return_date,l.location_name,t.type_of_transport,t.price,t.number_of_vacancies FROM TICKETS t JOIN LOCATIONS l ON t.location_id=l.location_id;";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ticket ticket = new Ticket();
                    ticket.ticketId = reader.GetInt32(0);
                    ticket.name = reader.GetString(1);
                    ticket.dateOfDeparture = reader.GetDateTime(2);
                    ticket.returnDate = reader.GetDateTime(3);
                    ticket.locationId = reader.GetInt32(4);
                    ticket.typeOfTransport = reader.GetString(5);
                    ticket.price = reader.GetDecimal(6);
                    ticket.numberOfVacancies = reader.GetInt32(7);

                    ListOfTickets.Add(ticket);
                }
                reader.Close();
                connection.Close();

                return ListOfTickets;
            }
        }
        public List<Ticket> GetAllClientTickets(Client client)
        {
            List<Ticket> ListOfTickets = new List<Ticket>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT t.ticket_id,t.name,t.date_of_departure,t.return_date,\r\nl.location_name,t.type_of_transport,t.price,t.number_of_vacancies \r\nFROM CLIENTS_TICKETS c JOIN TICKETS t on c.ticket_id=t.ticket_id JOIN LOCATIONS l ON t.location_id=l.location_id\r\nWHERE client_id=@clientId;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@clientId", client.clientId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ticket ticket = new Ticket();
                    ticket.ticketId = reader.GetInt32(0);
                    ticket.name = reader.GetString(1);
                    ticket.dateOfDeparture = reader.GetDateTime(2);
                    ticket.returnDate = reader.GetDateTime(3);
                    ticket.locationId = reader.GetInt32(4);
                    ticket.typeOfTransport = reader.GetString(5);
                    ticket.price = reader.GetDecimal(6);
                    ticket.numberOfVacancies = reader.GetInt32(7);

                    ListOfTickets.Add(ticket);
                }
                reader.Close();
                connection.Close();

                return ListOfTickets;
            }
        }
 
        public Ticket GetTicket(int ticketId)
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 t.ticket_id,t.name,t.date_of_departure,t.return_date,l.location_name,t.type_of_transport,t.price,t.number_of_vacancies FROM TICKETS t JOIN LOCATIONS l ON t.location_id=l.location_id WHERE ticket_id=@ticketId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ticketId", ticketId);
                    connection.Open();
                    Ticket ticket = new Ticket();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ticket.ticketId = reader.GetInt32(0);
                        ticket.name = reader.GetString(1);
                        ticket.dateOfDeparture = reader.GetDateTime(2);
                        ticket.returnDate = reader.GetDateTime(3);
                        ticket.locationId = reader.GetInt32(4);
                        ticket.typeOfTransport = reader.GetString(5);
                        ticket.price = reader.GetDecimal(6);
                        ticket.numberOfVacancies = reader.GetInt32(7);
                    }
                    reader.Close();
                    connection.Close();
                    return ticket;
                }
        }
        public int BookATicket(Client client,int ticketId, int numberOfPeople)
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
        }
    }
}
