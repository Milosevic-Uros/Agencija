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
        string UpdateInfo(Client client);
        string ChangePassword(Client client);
        string DeleteClient(int clientId);


        //Arrangements
        List<Arrangement> GetAllArrangements();
        List<Arrangement> GetAllClientArrangements(Client client);
        List<Arrangement> GetArrangementsOfType(string type);
        Arrangement GetAClientArrangement(Client client, int arrangementId);
        string BookAnArrangement(int clientId, int arrangementId, int numberOfPeople);

        //Tickets
        List<Ticket> GetAllTickets();
        List<Object> GetAllClientTickets(Client client);
        Ticket GetTicket(int ticketId);
        string BookATicket(Client client, int ticketId, int numberOfPeople);

        //Exchange Rate
        List<ExchangeRate> GetExchangeRates();
        ExchangeRate GetExchangeRate(string currencyCode);
    }
}
