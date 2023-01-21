using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class UserRepository : IUserRepository
    {
        public List<Arrangement> GetAllArrangements() 
        {
            throw new NotImplementedException();
        }
        public List<Arrangement> GetArrangementsOfType(string type)
        {
            throw new NotImplementedException();
        }
        public Arrangement GetArrangement(int arrangementId)
        {
            throw new NotImplementedException();
        }
        public int BookAnArrangement(int arrangementId, int numberOfPeople)
        {
            throw new NotImplementedException();
        }
    }
}
