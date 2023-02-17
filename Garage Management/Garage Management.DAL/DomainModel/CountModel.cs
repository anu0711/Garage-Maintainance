using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.DomainModel
{
    public class CountModel
    {
        public long Garage { get; set; }

        public long Vehicles { get; set; }

        public long Employee { get; set; }

        public long Loads { get; set; }

        public long Income { get; set; }
        public long Spendings { get; set; }

    }
}
