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
        public string UpdateInfo(Client client)
        {
            int rowsAffected = this.clientRepository.UpdateInfo(client);

            if (rowsAffected > 0)
            {
                return "Info successfully updated!";
            }
            else
            {
                return "Failed to update user info!";
            }
        }
        public string ChangePassword(Client client)
        {
            int rowsAffected = this.clientRepository.ChangePassword(client);

            if (rowsAffected > 0)
            {
                return "Password successfully updated!";
            }
            else
            {
                return "Failed to update users password!";
            }
        }
        public string DeleteClient(int clientId)
        {
            int rowsAffected = this.clientRepository.DeleteClient(clientId);

            if (rowsAffected > 0)
            {
                return "User successfully deleted!";
            }
            else
            {
                return "Failed to delete user!";
            }
        }
    }
}
