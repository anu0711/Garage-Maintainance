using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;

namespace Garage_Management.Common.Interfaces
{
    public interface IVehicle
    {
        Task AddorUpdateVehicle(Vehicle vehicle);

        Task<List<Vehicle>> GetAllVehicles();

        Task<List<DashCount>> GetAllDashbord();

        Task<MaintenanceSummary> AddMaintenanceSummary(MaintenanceSummary maintenanceSummary);


        Task<List<MaintenanceSummaryDomain>> GetMaintenanceSummary();

        Task<List<Vehicle>> GetByName(string VehicleName);
    }
}
