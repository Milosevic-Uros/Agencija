using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Ticket
    {
        public int ticketId { get; set; }
        public string name { get; set; }
        public DateTime dateOfDeparture { get; set; }
        public DateTime returnDate { get; set; }
        public int locationId { get; set; }
        public string typeOfTransport { get; set; }
        public string typeOfArrangement { get; set; }
        public int numberOfVacancies { get; set; }
        public decimal price { get; set; }
    }
}
