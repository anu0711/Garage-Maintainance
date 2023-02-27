﻿using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;

namespace Garage_Management.Common.Interfaces
{
    public interface IVehicle
    {
        Task AddorUpdateVehicle(Vehicle vehicle);

        Task<List<Vehicle>> GetAllVehicles();

        Task<List<DashCount>> GetAllDashbord();

        Task<Spendings> AddMaintenanceSummary(Spendings maintenanceSummary);

        Task<List<Vehicle>> GetByName(string VehicleName);

        Task<List<Vehicle>> GetByVehicleType(string VehicleType);

        Task RemoveVehicle(Vehicle vehicle);    
    }
}
