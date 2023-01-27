using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.DAL.Model
{
    public class Entity
    {
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid UpdatedBy { get; set; }
    }
}
