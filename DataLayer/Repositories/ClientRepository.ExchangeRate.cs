using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class ClientRepository : IClientRepository
    {
        public List<ExchangeRate> GetExchangeRates() 
        {
            List<ExchangeRate> ListOfExchangeRates = new List<ExchangeRate>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM EXCHANGE_RATES";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExchangeRate exchangeRateItem = new ExchangeRate();
                    exchangeRateItem.currencyId = reader.GetString(0);
                    exchangeRateItem.currencyCode = reader.GetString(1);
                    exchangeRateItem.countryName = reader.GetString(2);
                    exchangeRateItem.meanExchangeRate = reader.GetDecimal(3);
                    ListOfExchangeRates.Add(exchangeRateItem);
                }
                reader.Close();
                connection.Close();
                return ListOfExchangeRates;
            }
        }
        public ExchangeRate GetExchangeRate(int currencyId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM EXCHANGE_RATES WHERE currency_id=@currencyId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currencyId", currencyId);
                connection.Open();
                ExchangeRate exchangeRateItem = new ExchangeRate();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    exchangeRateItem.currencyId = reader.GetString(0);
                    exchangeRateItem.currencyCode = reader.GetString(1);
                    exchangeRateItem.countryName = reader.GetString(2);
                    exchangeRateItem.meanExchangeRate = reader.GetDecimal(3);

                }
                reader.Close();
                connection.Close();
                return exchangeRateItem;
            }
        }
    }
}
