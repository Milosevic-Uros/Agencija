using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class ExchangeRate
    {
        public string currencyId { get; set; }
        public string currencyCode { get; set; }
        public string countryName { get; set; }
        public decimal meanExchangeRate { get; set; }
    }
}
