using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Aranzman
    {
        public int aranzmanId { get; set; }
        public string naziv { get; set; }
        public DateTime datumPolaska { get; set; }
        public DateTime datumPovratka { get; set; }
        public int lokacijaId { get; set; }
        public string tipPrevoza { get; set; }
        public string tipAranzmana { get; set; }
        public int brojmesta { get; set; }
        public string opis { get; set; }
        public decimal cena { get; set; }
    }
}
