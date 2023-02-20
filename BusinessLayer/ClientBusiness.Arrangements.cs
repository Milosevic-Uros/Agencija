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
        public List<Arrangement> GetAllArrangements()
        {
            return clientRepository.GetAllArrangements();
        }
        public List<Object> GetAllClientArrangements(Client client)
        {
            return clientRepository.GetAllClientArrangements(client);
        }
        public List<Object> GetAllArrangementsByLocationTypeAndDate(int locationId, string typeOfArrangement, DateTime from)
        {
            return clientRepository.GetAllArrangementsByLocationTypeAndDate(locationId, typeOfArrangement, from);
        }

        public string BookAnArrangement(int clientId, int arrangementId, int numberOfPeople)
        {
            int rowsAffected = this.clientRepository.BookAnArrangement(clientId, arrangementId,numberOfPeople);

            if (rowsAffected > 0)
            {
                return "Arrangement successfully booked!";
            }
            else
            {
                return "Booking an arrangement failed!";
            }
        }
    }
}
