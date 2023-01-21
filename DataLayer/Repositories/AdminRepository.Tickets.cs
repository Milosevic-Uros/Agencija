using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class AdminRepository : IAdminRepository
    {
        public List<Ticket> GetAllTickets()
        {
            throw new NotImplementedException();
        }
        public int UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
        public int InsertTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
        public Ticket GetTicket(int ticketId)
        {
            throw new NotImplementedException();
        }
        public int DeleteTicket(int ticketId)
        {
            throw new NotImplementedException();
        }
    }
}
