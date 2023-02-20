using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class AdminBusiness : IAdminBusiness
    {
        public List<ExchangeRate> GetExchangeRates()
        {
            return adminRepository.GetExchangeRates();
        }
        public string UpdateExchangeRateItem(ExchangeRate exchangeRate)
        {
            int rowsAffected = this.adminRepository.UpdateExchangeRateItem(exchangeRate);

            if (rowsAffected > 0)
            {
                return "Exchange rate item successfully updated!";
            }
            else
            {
                return "Failed to update exchange rate item!";
            }
        }
        public string InsertExchangeRateItem(ExchangeRate exchangeRate)
        {
            int rowsAffected = adminRepository.InsertExchangeRateItem(exchangeRate);
            if (rowsAffected > 0)
            {
                return "Exchange rate item successfully added!";
            }
            else
            {
                return "Adding an exchange rate item failed!\nYou might have tried to insert a duplicate record";
            }
        }

        public string DeleteExchangeRateItem(int currencyId)
        {
            int rowsAffected = adminRepository.DeleteExchangeRateItem(currencyId);
            if (rowsAffected > 0)
            {
                return "Exchange rate item successfully deleted!";
            }
            else
            {
                return "Deleting an exchange rate item failed!";
            }
        }
    }
}
