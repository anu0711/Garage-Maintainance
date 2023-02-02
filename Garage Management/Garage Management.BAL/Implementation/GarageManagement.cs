using Dapper;
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
       

        public async Task<List<Garage>> GetGarages()
        {
            var b = new GMEntity<Garage>();
            using var connection = b.GetConnection();
            var data = await connection.QueryAsync<Garage>($"select * from Garage");
            return data.ToList();
        }

        public async Task<List<Garage>> SearchGarage(string searchkey)
        {
            try
            {
                var connect = new GMEntity<Garage>();
                using var connection = connect.GetConnection();
                return (List<Garage>)await connection.QueryAsync<Garage>($"select * from garage where name LIKE '%{searchkey}%' or location LIKE '%{searchkey}%'");

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
