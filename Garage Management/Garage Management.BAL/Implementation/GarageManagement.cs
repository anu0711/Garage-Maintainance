using Garage_Management.Common.Interfaces;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.BAL.Implementation
{
    public class GarageManagement : IGarage
    {
        public async Task AddorUpdateGarage(Garage garage)
        {
            var a = new GMEntity<Garage>();
            using var connection = a.GetConnection();

            if(garage != null)
            {               

                await a.AddorUpdate(garage);
            }
        }
    }
}
