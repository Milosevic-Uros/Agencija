using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IAdminBusiness
    {
        //Admin and users
        Admin GetAdmin(string email, string password);
        List<Client> GetAllClients();
        string UpdateClient(Client client);
        string InsertClient(Client client);
        Client GetClient(string email, string password);
        string DeleteClient(int clientId);

        //Arrangements
        List<Arrangement> GetAllArrangements();
        string UpdateArrangement(Arrangement arrangement);
        string InsertArrangement(Arrangement arrangement);
        string DeleteArrangement(int arrangementId);

        //Tickets
        List<Ticket> GetAllTickets();
        string UpdateTicket(Ticket ticket);
        string InsertTicket(Ticket ticket);
        string DeleteTicket(int ticketId);

        //Exchange Rate
        List<ExchangeRate> GetExchangeRates();
        string UpdateExchangeRateItem(ExchangeRate exchangeRate);
        string InsertExchangeRateItem(ExchangeRate exchangeRate);
        string DeleteExchangeRateItem(int currencyId);

        //Locations
        List<Location> GetLocations();
    }
}
