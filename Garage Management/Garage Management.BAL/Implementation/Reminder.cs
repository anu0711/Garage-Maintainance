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
    public class Reminders:IReminder
    {
        public async Task<long> GetProfit()
        {
            var a = new GMEntity<DailyWorkSummary>();
            var connection = a.GetConnection();
             var t = (await connection.QueryAsync<DailyWorkSummary>("SELECT Sum(Totalearnings) as TotalEarnings FROM DailyWorkSummary ")).FirstOrDefault();
            return t.TotalEarnings;
        }
        public async Task<long> GetLoss()
        {
            var a = new GMEntity<MaintenanceSummary>();
            var connection = a.GetConnection();
            var t = (await connection.QueryAsync<MaintenanceSummary>("SELECT Sum(Amount) as Amount FROM MaintenanceSummary ")).FirstOrDefault();
            return t.Amount;
        }
    }
}
