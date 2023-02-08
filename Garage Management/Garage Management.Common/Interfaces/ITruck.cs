using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface ITruck
    {
        Task AddOrUpdateTruck(TruckSummary truckSummary);

        Task<List<TruckSummary>> GetTruckSummaries();

        Task<List<TruckSummary>> SearchTruck(string searchkey);

    }
}
