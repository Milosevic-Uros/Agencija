using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class AdminRepository : IAdminRepository
    {
        public List<Location> GetLocations()
        {
            throw new NotImplementedException();
        }
        public int UpdateLocation(Location location)
        {
            throw new NotImplementedException();
        }
        public int InsertLocation(Location location)
        {
            throw new NotImplementedException();
        }
        public Location GetLocation(int locationId)
        {
            throw new NotImplementedException();
        }
        public int DeleteLocation(int locationId)
        {
            throw new NotImplementedException();
        }
    }
}
