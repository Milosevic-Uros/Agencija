﻿using DataLayer.Repositories;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class ClientBusiness : IClientBusiness
    {

        public List<Object> GetAllClientTickets(Client client)
        {
            return clientRepository.GetAllClientTickets(client);
        }

        public string BookATicket(Client client, int ticketId, int numberOfPeople)
        {
            int rowsAffected = clientRepository.BookATicket(client,ticketId,numberOfPeople);
            if (rowsAffected > 0)
            {
                return "Ticket successfully booked!";
            }
            else
            {
                return "Booking a ticket failed!";
            }
        }
    }
}
