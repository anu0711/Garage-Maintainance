using Dapper;

using Garage_Management.DAL.Model;
using System.Data;
using System.Data.SqlClient;

namespace Garage_Management.BAL.Implementation
{
    public class GMEntity<T> where T : Entity
    {
       
        public virtual async Task<T> AddorUpdate(T entity)
        {
            using var connection = this.GetConnection();
            if (entity.Id == 0 || entity.Id == null)
            {

                entity.Id = await connection.InsertAsync<long, T>(entity);

            }
            return entity;

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

    
