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
        public List<Location> GetLocations()
        {
            return adminRepository.GetLocations();
        }
        public string UpdateLocation(Location location)
        {
            int rowsAffected = this.adminRepository.UpdateLocation(location);

            if (rowsAffected > 0)
            {
                return "Location successfully updated!";
            }
            else
            {
                return "Failed to update location!";
            }
        }
        public string InsertLocation(Location location)
        {
            int rowsAffected = adminRepository.InsertLocation(location);
            if (rowsAffected > 0)
            {
                return "Location successfully added!";
            }
            else
            {
                return "Adding a location failed!";
            }
        }
        public Location GetLocation(int locationId)
        {
            return adminRepository.GetLocation(locationId);
        }
        public string DeleteLocation(int locationId)
        {
            int rowsAffected = adminRepository.DeleteLocation(locationId);
            if (rowsAffected > 0)
            {
                return "Location successfully deleted!";
            }
            else
            {
                return "Deleting location failed!";
            }
        }
    }
}
