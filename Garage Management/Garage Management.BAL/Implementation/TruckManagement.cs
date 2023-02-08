using Dapper;
using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class TruckManagement : ITruck
    {
        public async Task AddOrUpdateTruck(TruckSummary truckSummary)
        {
            var dbconnect = new GMEntity<TruckSummary>();
            using var connection = dbconnect.GetConnection();

            if (truckSummary != null)
            {
                await dbconnect.AddorUpdate(truckSummary);
            }
        }

        public async Task<List<TruckSummary>> GetTruckSummaries()
        {
            var dbconnect = new GMEntity<TruckSummary>();
            using var connection = dbconnect.GetConnection();
            var result = await connection.QueryAsync<TruckSummary>($"select * from trucksummary");
            return result.ToList(); 
            
        }

        public async Task<List<TruckSummary>> SearchTruck(string searchkey)
        {
            try
            {
                var dbconnect = new GMEntity<TruckSummary>();
                using var connection = dbconnect.GetConnection();
                return(List<TruckSummary>) await connection.QueryAsync<TruckSummary>($"select * from trucksummary where startlocation LIKE '%{searchkey}%' or haltLocation LIKE'%{searchkey}%'");
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
