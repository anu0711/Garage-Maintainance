using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.DomainModel;
using Garage_Management.DAL.Model;
using System.Data;

namespace Garage_Management.BAL.Implementation
{
    public class CountManagement : GMEntity<Garage>,ICounts
    {
        public async Task<CountModel> GetCounts()
        {
            using var connection = this.GetConnection();
            var counts = new CountModel();
            var results = connection.QueryMultiple("pd_Counts", commandType: CommandType.StoredProcedure);
            var t = results.Read<(long Loads, long Income)>().ToList();
            counts.Spendings = results.Read<long>().FirstOrDefault();
            counts.Garage = results.Read<long>().FirstOrDefault();
            counts.Employee = results.Read<long>().FirstOrDefault();
            counts.Vehicles = results.Read<long>().FirstOrDefault();
            counts.Loads = t[0].Loads;
            counts.Income = t[0].Income;
            return counts;

        }

        public async Task<List<Reminder>> GetBookings()
        {
            using var connection = this.GetConnection();
            return (await connection.QueryAsync<Reminder>("select * from bookings where CONVERT(varchar, createddate, 103) = CONVERT(varchar, GetDate(), 103) order by createddate")).ToList();
        }

        

        public async Task<List<VehicleSpendings>> GetVehicleSpendings(string VehicleName)
        {
            using var connection = this.GetConnection();
            return (await connection.QueryAsync<VehicleSpendings>("select v.Id,v.VehicleName,v.VehicleNumber,v.VehicleType,s.amount,s.detail from vehicle v inner join spendings s on s.truckid = v.Id where VehicleName = @VehicleName", new { VehicleName = VehicleName })).ToList();

        }
    }

}
