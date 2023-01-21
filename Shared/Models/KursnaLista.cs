using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class KursnaLista
    {
        public string valutaId { get; set; }
        public string oznakaValute { get; set; }
        public string nazivZemlje { get; set; }
        public decimal srednjiKurs { get; set; }
    }
}
