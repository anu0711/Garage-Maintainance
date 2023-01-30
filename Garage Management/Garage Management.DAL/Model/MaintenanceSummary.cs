using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class MaintenanceSummary : Entity
    {
        public Guid Id { get; set; }    
        public string Detail { get; set; }
        public long Amount { get; set; }
        public bool IsOwner { get; set; }


    }
}
