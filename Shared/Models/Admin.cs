using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Admin
    {
        public int adminId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
