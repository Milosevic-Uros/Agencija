using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IAdminRepository
    {
        //Admin and users
        Admin GetAdmin(string email, string password);
        List<Client> GetAllClients();
        int UpdateClient(Client client);
        int InsertClient(Client client);
        Client GetClient(string email, string password);
        int DeleteClient(int clientId);

        //Arrangements
        List<Arrangement> GetAllArrangements();
        int UpdateArrangement(Arrangement arrangement);
        int InsertArrangement(Arrangement arrangement);
        int DeleteArrangement(int arrangementId);

        //Tickets
        List<Ticket> GetAllTickets();
        int UpdateTicket(Ticket ticket);
        int InsertTicket(Ticket ticket);
        int DeleteTicket(int ticketId);

        //Exchange Rate
        List<ExchangeRate> GetExchangeRates();
        int UpdateExchangeRateItem(ExchangeRate exchangeRate);
        int InsertExchangeRateItem(ExchangeRate exchangeRate);
        int DeleteExchangeRateItem(int currencyId);

        //Locations
        List<Location> GetLocations();

    }
}
