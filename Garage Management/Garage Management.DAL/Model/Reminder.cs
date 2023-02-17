using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class Reminder:Entity
    {
        public string Product { get; set; }

        public string Quantity { get; set; }

        public string Place { get; set; }

        public string Contact { get; set; }
    }
}
