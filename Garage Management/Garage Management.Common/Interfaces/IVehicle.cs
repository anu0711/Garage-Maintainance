﻿using Garage_Management.BAL.DomainModel;
using Garage_Management.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management.Common.Interfaces
{
    public interface IVehicle
    {
        Task AddorUpdateVehicle(Vehicle vehicle);

        Task<List<Vehicle>> GetAllVehicles();
    }
}
