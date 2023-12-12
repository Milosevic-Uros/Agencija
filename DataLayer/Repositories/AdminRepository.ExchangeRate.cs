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
    public partial class AdminRepository : IAdminRepository
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
        public int UpdateExchangeRateItem(ExchangeRate exchangeRate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE EXCHANGE_RATES SET currency_code=@currencyCode,country_name=@countryName,mean_exchange_rate=@meanExchangeRate WHERE currency_id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@currencyCode", exchangeRate.currencyCode);
                    command.Parameters.AddWithValue("@countryName", exchangeRate.countryName);
                    command.Parameters.AddWithValue("@meanExchangeRate", exchangeRate.meanExchangeRate);
                    command.Parameters.AddWithValue("@id", exchangeRate.currencyId);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int InsertExchangeRateItem(ExchangeRate exchangeRate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO EXCHANGE_RATES (currency_id,currency_code,country_name,mean_exchange_rate) VALUES(@currencyId,@currencyCode,@countryName,@meanExchangeRate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@currencyId", exchangeRate.currencyId);
                    command.Parameters.AddWithValue("@currencyCode", exchangeRate.currencyCode);
                    command.Parameters.AddWithValue("@countryName", exchangeRate.countryName);
                    command.Parameters.AddWithValue("@meanExchangeRate", exchangeRate.meanExchangeRate);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }
            catch 
            { 
                return 0;
            }
        }

        public int DeleteExchangeRateItem(int currencyId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM EXCHANGE_RATES WHERE currency_id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", currencyId);

                    connection.Open();
                    int rowsUpdated;
                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsUpdated;
                }
            }catch 
            {
                return 0;
            }
        }
    }
}
