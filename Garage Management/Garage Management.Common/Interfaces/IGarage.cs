using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface IGarage
    {
        Task AddorUpdateGarage(Garage garage);

        Task<List<Garage>> GetGarages();

        Task<List<Garage>> SearchGarage(string searchkey);
    }
}
