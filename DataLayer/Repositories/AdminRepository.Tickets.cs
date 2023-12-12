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
                string query = "SELECT t.ticket_id,t.name,t.date_of_departure,t.return_date,t.location_id,t.type_of_transport,t.price,t.number_of_vacancies FROM TICKETS t JOIN LOCATIONS l ON t.location_id=l.location_id;";
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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE TICKETS SET date_of_departure=CAST(@dateOfDeparture AS DATETIME),return_date=CAST(@returnDate AS DATETIME),type_of_transport=@typeOfTransport WHERE ticket_id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@dateOfDeparture", ticket.dateOfDeparture.ToString("yyyy'-'MM'-'dd"));
                    command.Parameters.AddWithValue("@returnDate", ticket.returnDate.ToString("yyyy'-'MM'-'dd"));
                    command.Parameters.AddWithValue("@typeOfTransport", ticket.typeOfTransport);
                    command.Parameters.AddWithValue("@id", ticket.ticketId);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int InsertTicket(Ticket ticket)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO TICKETS (name,date_of_departure,return_date,location_id,type_of_transport,price,number_of_vacancies) " +
                        "VALUES(@name,@dateOfDeparture,@returnDate,@locationId,@typeOfTransport,@price,@numberOfVacancies)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", ticket.name);
                    command.Parameters.AddWithValue("@dateOfDeparture", ticket.dateOfDeparture.ToString("yyyy'-'MM'-'dd"));
                    command.Parameters.AddWithValue("@returnDate", ticket.returnDate.ToString("yyyy'-'MM'-'dd"));
                    command.Parameters.AddWithValue("@locationId", ticket.locationId);
                    command.Parameters.AddWithValue("@typeOfTransport", ticket.typeOfTransport);
                    command.Parameters.AddWithValue("@price", ticket.price);
                    command.Parameters.AddWithValue("@numberOfVacancies", ticket.numberOfVacancies);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int DeleteTicket(int ticketId)
        {
            try
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
            catch
            {
                return 0;
            }
        }
    }
}
