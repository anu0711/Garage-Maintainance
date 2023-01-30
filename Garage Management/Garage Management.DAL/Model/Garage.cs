using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class Garage : Entity
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
    }
}
