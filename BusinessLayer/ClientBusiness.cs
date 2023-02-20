using DataLayer.Repositories;
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
        private readonly IClientRepository clientRepository;

        public ClientBusiness(IClientRepository _clientRepository)
        {
            clientRepository = _clientRepository;
        }      
    }
}
