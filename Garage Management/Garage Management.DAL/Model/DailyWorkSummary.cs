using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class DailyWorkSummary:Entity
    {
        public long Id { get; set; }

        public long StartingKilometer { get; set; }

        public long EndKilometer { get; set; }

        public long Number_Of_Loads { get; set; }

        public long TotalEarnings { get; set; }

        public long SpendingSummaryId { get; set; }

        public long TruckSummaryId { get; set; }
    }
}
