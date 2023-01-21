using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class UserRepository : IUserRepository
    {
        public List<Ticket> GetAllTickets() 
        {
            throw new NotImplementedException();
        }
        public Ticket GetTicket(int ticketId)
        {
            throw new NotImplementedException();
        }
        public int BookATicket(int ticketId, int numberOfPeople)
        {
            throw new NotImplementedException();
        }
    }
}
