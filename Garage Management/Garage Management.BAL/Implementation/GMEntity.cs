using System.Data;
using System.Security.Cryptography;
using Dapper;
using Garage_Management.DAL.Model;


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

        public string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var cryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[length];
            cryptoServiceProvider.GetBytes(randomBytes);
            char[] randomChars = new char[length];
            for (int i = 0; i < randomBytes.Length; i++)
            {
                randomChars[i] = validChars[randomBytes[i] % validChars.Length];
            }
            return new string(randomChars);
        }
        
}      
}

    
