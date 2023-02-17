using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface IDailyWorkSummary
    {
        Task AddorUpdateDailyWork(DailyWorkSummary dailyWorkSummary);

        Task<List<DailyWorkSummary>> GetAllDailyWorkSummaries();

        Task<List<DailyWorkSummary>> GetDailyWorkById(Guid id);
    }
}
