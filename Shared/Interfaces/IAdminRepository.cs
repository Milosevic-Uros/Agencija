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
        
        int UpdateAdmin(Admin admin);
        List<User> GetAllUsers();
        int UpdateUser(User user);
        int InsertUser(User user);
        User GetUser(string email, string password);
        int DeleteUser(int userId);

        //Arrangements
        List<Arrangement> GetAllArrangements();
        List<Arrangement> GetArrangementsOfType(string type);
        int UpdateArrangement(Arrangement arrangement);
        int InsertArrangement(Arrangement arrangement);
        Arrangement GetArrangement(int arrangementId);
        int DeleteArrangement(int arrangementId);

        //Tickets
        List<Ticket> GetAllTickets();
        int UpdateTicket(Ticket ticket);
        int InsertTicket(Ticket ticket);
        Ticket GetTicket(int ticketId);
        int DeleteTicket(int ticketId);

        //Exchange Rate
        List<ExchangeRate> GetExchangeRates();
        int UpdateExchangeRateItem(ExchangeRate exchangeRate);
        int InsertExchangeRateItem(ExchangeRate exchangeRate);
        ExchangeRate GetExchangeRate(int currencyId);
        int DeleteExchangeRateItem(int currencyId);

        //Locations
        List<Location> GetLocations();
        int UpdateLocation(Location location);
        int InsertLocation(Location location);
        Location GetLocation(int locationId);
        int DeleteLocation(int locationId);
    }
}
