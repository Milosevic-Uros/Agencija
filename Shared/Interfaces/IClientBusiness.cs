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
        //Self edit
        string UpdateUser(Client user);
        string DeleteUser(int userId);


        //Arrangements
        List<Arrangement> GetAllArrangements();
        List<Arrangement> GetArrangementsOfType(string type);
        Arrangement GetArrangement(int arrangementId);
        string BookAnArrangement(int arrangementId, int numberOfPeople);

        //Tickets
        List<Ticket> GetAllTickets();
        Ticket GetTicket(int ticketId);
        string BookATicket(int ticketId, int numberOfPeople);

        //Exchange Rate
        List<ExchangeRate> GetExchangeRates();
        ExchangeRate GetExchangeRate(int currencyId);
    }
}
