using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public partial class AdminRepository : IAdminRepository
    {
        string connectionString = Constants.ConnectionString;
        public List<Arrangement> GetAllArrangements()
        {
            throw new NotImplementedException();
        }
        public List<Arrangement> GetArrangementsOfType(string type)
        {
            throw new NotImplementedException();
        }
        public int UpdateArrangement(Arrangement arrangement)
        {
            throw new NotImplementedException();
        }
        public int InsertArrangement(Arrangement arrangement)
        {
            throw new NotImplementedException();
        }
        public Arrangement GetArrangement(int arrangementId)
        {
            throw new NotImplementedException();
        }
        public int DeleteArrangement(int arrangementId)
        {
            throw new NotImplementedException();
        }
    }
}
