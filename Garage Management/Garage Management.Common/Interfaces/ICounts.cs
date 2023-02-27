using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface ICounts
    {
        Task<CountModel> GetCounts();
        Task<List<Reminder>> GetBookings();
        Task<List<VehicleSpendings>> GetVehicleSpendings(string VehicleName);
    }

}
