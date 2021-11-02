using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities;

namespace WebApplication2.Services
{
    public class BaseService<TResponse, TCreate, TEntity> : IBaseService<TResponse, TCreate> where TEntity : BaseEntity
    {
        public BaseService()
        {

        }
        public Task<TResponse> CreateAsync(TCreate entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TResponse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> UpdateAsync(int id, TCreate entity)
        {
            throw new NotImplementedException();
        }
    }
}
