using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;

namespace BusinessLayer
{
    public partial class AdminBusiness : IAdminBusiness
    {
        public List<Arrangement> GetAllArrangements() 
        { 
            return adminRepository.GetAllArrangements();
        }

        public string UpdateArrangement(Arrangement arrangement) 
        {
            int rowsAffected = adminRepository.UpdateArrangement(arrangement);

            if (rowsAffected > 0)
            {
                return "Arrangement successfully updated!";
            }
            else
            {
                return "Failed to update arrangement!";
            }
        }
        public string InsertArrangement(Arrangement arrangement)
        {
            int rowsAffected = adminRepository.InsertArrangement(arrangement);
            if (rowsAffected > 0)
            {
                return "Arrangement successfully added!";
            }
            else
            {
                return "Adding an arrangement failed!";
            }
        }
        public string DeleteArrangement(int arrangementId)
        {
            int rowsAffected = adminRepository.DeleteArrangement(arrangementId);
            if (rowsAffected > 0)
            {
                return "Arrangement successfully deleted!";
            }
            else
            {
                return "Deleting an arrangement failed!";
            }
        }
    }
}
