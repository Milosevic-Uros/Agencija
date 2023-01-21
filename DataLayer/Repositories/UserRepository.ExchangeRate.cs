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
        public List<ExchangeRate> GetExchangeRates() 
        {
            throw new NotImplementedException();
        }
        public ExchangeRate GetExchangeRate(int currencyId)
        {
            throw new NotImplementedException();
        }
    }
}
