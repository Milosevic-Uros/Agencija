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
    public partial class AdminRepository : IAdminRepository
    {
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> ListOfTickets = new List<Ticket>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ARRANGEMENTS";
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
        public int UpdateTicket(Ticket ticket)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE TICKETS SET name=@name,date_of_departure=@dateOfDeparture,return_date=@returnDate,location_id=@locationId,type_of_transport=@typeOfTransport,price=@price,number_of_vacancies=@numOfVacancies WHERE ticket_id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", ticket.name);
                command.Parameters.AddWithValue("@date_of_departure", ticket.dateOfDeparture);
                command.Parameters.AddWithValue("@return_date", ticket.returnDate);
                command.Parameters.AddWithValue("@location_id", ticket.locationId);
                command.Parameters.AddWithValue("@type_of_transport", ticket.typeOfTransport);
                command.Parameters.AddWithValue("@price", ticket.price);
                command.Parameters.AddWithValue("@numberOfVacancies", ticket.numberOfVacancies);
                command.Parameters.AddWithValue("@id", ticket.ticketId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public int InsertTicket(Ticket ticket)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TICKETS (name,date_of_departure,return_date,location_id,type_of_transport,price,number_of_vacancies) VALUES(@name,@dateOfDeparture,@returnDate,@locationId,@typeOfTransport,@price,@numberOfVacancies)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", ticket.name);
                command.Parameters.AddWithValue("@date_of_departure", ticket.dateOfDeparture);
                command.Parameters.AddWithValue("@return_date", ticket.returnDate);
                command.Parameters.AddWithValue("@location_id", ticket.locationId);
                command.Parameters.AddWithValue("@type_of_transport", ticket.typeOfTransport);
                command.Parameters.AddWithValue("@price", ticket.price);
                command.Parameters.AddWithValue("@numberOfVacancies", ticket.numberOfVacancies);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
        public Ticket GetTicket(int ticketId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM TICKETS WHERE ticket_id=@ticketId";
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
        public int DeleteTicket(int ticketId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TICKETS WHERE ticket_id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ticketId);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
    }
}
