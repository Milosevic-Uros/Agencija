using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IClientBusiness
    {
        //Arrangements
        List<Arrangement> GetAllArrangements();
        List<Object> GetAllClientArrangements(Client client);
        List<Object> GetAllArrangementsByLocationTypeAndDate(int locationId, string typeOfArrangement, DateTime from);
        string BookAnArrangement(int clientId, int arrangementId, int numberOfPeople);

        //Tickets
        List<Object> GetAllClientTickets(Client client);
        string BookATicket(Client client, int ticketId, int numberOfPeople);

    }
}
