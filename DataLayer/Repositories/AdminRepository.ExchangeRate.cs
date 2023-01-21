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
        public List<ExchangeRate> GetExchangeRates()
        {
            throw new NotImplementedException();
        }
        public int UpdateExchangeRateItem(ExchangeRate exchangeRate)
        {
            throw new NotImplementedException();
        }
        public int InsertExchangeRateItem(ExchangeRate exchangeRate)
        { 
            throw new NotImplementedException(); 
        }
        public ExchangeRate GetExchangeRate(int currencyId)
        {
            throw new NotImplementedException();
        }
        public int DeleteExchangeRateItem(int currencyId)
        {
            throw new NotImplementedException();
        }
    }
}
