using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class AdminBusiness : IAdminBusiness
    {
        public List<Ticket> GetAllTickets()
        {
            return adminRepository.GetAllTickets();
        }
        public string UpdateTicket(Ticket ticket)
        {
            int rowsAffected = this.adminRepository.UpdateTicket(ticket);

            if (rowsAffected > 0)
            {
                return "Ticket successfully updated!";
            }
            else
            {
                return "Failed to update ticket!";
            }
        }
        public string InsertTicket(Ticket ticket)
        {
            int rowsAffected = adminRepository.InsertTicket(ticket);
            if (rowsAffected > 0)
            {
                return "Ticket successfully added!";
            }
            else
            {
                return "Inserting a arrangement ticket!";
            }
        }

        public string DeleteTicket(int ticketId)
        {
            int rowsAffected = adminRepository.DeleteTicket(ticketId);
            if (rowsAffected > 0)
            {
                return "Ticket successfully deleted!";
            }
            else
            {
                return "Deleting ticket failed!";
            }
        }
    }
}
