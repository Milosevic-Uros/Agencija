using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;
using Shared.Models;

namespace BusinessLayer
{
    public partial class AdminBusiness : IAdminBusiness
    {
        private readonly IAdminRepository adminRepository;

        public AdminBusiness(IAdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }

        public Admin GetAdmin(string email,string password)
        {
            return adminRepository.GetAdmin(email,password);
        }

        public List<Client> GetAllClients()
        { 
            return adminRepository.GetAllClients();
        }
        public string UpdateClient(Client client)
        {
            int rowsAffected = adminRepository.UpdateClient(client);
            if (rowsAffected > 0)
            {
                return "Client successfully updated!";
            }
            else
            {
                return "Client's data update failed!";
            }
        }
        public string InsertClient(Client client) 
        {
            int rowsAffected = adminRepository.InsertClient(client);
            if (rowsAffected > 0)
            {
                return "Client successfully added!";
            }
            else
            {
                return "Adding a client failed!";
            }
        }
        public Client GetClient(string email, string password)
        {
            return adminRepository.GetClient(email, password);
        }
        public string DeleteClient(int clientId) 
        {
            int rowsAffected = adminRepository.DeleteClient(clientId);
            if (rowsAffected > 0)
            {
                return "Client successfully deleted!";
            }
            else
            {
                return "Deleting a client failed!";
            }
        }
    }
}
