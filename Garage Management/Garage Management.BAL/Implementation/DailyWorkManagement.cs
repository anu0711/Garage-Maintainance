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
    public class DailyWorkManagement : IDailyWorkSummary
    {
        public async Task AddorUpdateDailyWork(DailyWorkSummary dailyWorkSummary)
        {
            var a = new GMEntity<DailyWorkSummary>();
            using var connection = a.GetConnection();
            if(dailyWorkSummary != null)
            {
                await a.AddorUpdate(dailyWorkSummary);
            }
        }

        public async Task<List<DailyWorkSummary>> GetAllDailyWorkSummaries()
        {
            var b = new GMEntity<DailyWorkSummary>();
            using var connection = b.GetConnection();
            var data = await connection.QueryAsync<DailyWorkSummary>($"select * from dailyworksummary");
            return data.ToList();
           
        }

        public async Task<List<DailyWorkSummary>>GetDailyWorkById(Guid Id)
        {
            var dbconnect = new GMEntity<DailyWorkSummary>();
            using var connection = dbconnect.GetConnection();
            var result = await connection.QueryAsync<DailyWorkSummary>($"select * from dailyworksummary where id = @Id", new {Id = Id} );
            return result.ToList(); 
        }
    }
}
