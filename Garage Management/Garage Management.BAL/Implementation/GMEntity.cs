using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Dapper;
using Garage_Management.DAL.Model;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Garage_Management.BAL.Implementation
{
    public class GMEntity<T> where T : Entity
    {
       
        public virtual async Task<T> AddorUpdate(T entity)
        {
            try
            {
                using var connection = this.GetConnection();
                if (entity.Id == Guid.Empty)
                {
                    entity.CreatedDate = DateTime.Now;
                    entity.UpdatedDate = DateTime.Now;
                    entity.IsActive = true;
                    entity.CreatedBy = Guid.NewGuid();
                    entity.UpdatedBy = Guid.NewGuid();

                    entity.Id = await connection.InsertAsync<Guid, T>(entity,null);
                    
                }
                else
                {
                    entity.UpdatedDate = DateTime.Now;
                    entity.IsActive = true;
                    entity.UpdatedBy = Guid.NewGuid();
                    await connection.UpdateAsync(entity);
                }
                return entity;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public IDbConnection GetConnection(IDbTransaction transaction = null)
        {
            var connection = DbConnection.GetConnection();
            if(connection.State == ConnectionState.Closed)
            connection.Open();   
            return connection;        

        }
    }      
}

    
