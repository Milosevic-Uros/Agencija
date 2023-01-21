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
        string UpdateAdmin(Admin admin);
        List<User> GetAllUsers();
        string UpdateUser(User user);
        string InsertUser(User user);
        User GetUser(string email, string password);
        string DeleteUser(int userId);

        //Arrangements
        List<Arrangement> GetAllArrangements();
        List<Arrangement> GetArrangementsOfType(string type);
        string UpdateArrangement(Arrangement arrangement);
        string InsertArrangement(Arrangement arrangement);
        Arrangement GetArrangement(int arrangementId);
        string DeleteArrangement(int arrangementId);

        //Tickets
        List<Ticket> GetAllTickets();
        string UpdateTicket(Ticket ticket);
        string InsertTicket(Ticket ticket);
        Ticket GetTicket(int ticketId);
        string DeleteTicket(int ticketId);

        //Exchange Rate
        List<ExchangeRate> GetExchangeRates();
        string UpdateExchangeRateItem(ExchangeRate exchangeRate);
        string InsertExchangeRateItem(ExchangeRate exchangeRate);
        ExchangeRate GetExchangeRate(int currencyId);
        string DeleteExchangeRateItem(int currencyId);

        //Locations
        List<Location> GetLocations();
        string UpdateLocation(Location location);
        string InsertLocation(Location location);
        Location GetLocation(int locationId);
        string DeleteLocation(int locationId);
    }
}
