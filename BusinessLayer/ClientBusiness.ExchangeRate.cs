using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class ClientBusiness : IClientBusiness
    {
        public List<ExchangeRate> GetExchangeRates()
        {
            return clientRepository.GetExchangeRates();
        }
        public ExchangeRate GetExchangeRate(int currencyId)
        {
            return clientRepository.GetExchangeRate(currencyId);
        }
    }
}