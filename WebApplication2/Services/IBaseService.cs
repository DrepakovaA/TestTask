using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public interface IBaseService<TResponse, TCreate>
    {
        Task<IEnumerable<TResponse>> GetAllAsync();
        Task<TResponse> GetByIdAsync(int id);
        Task<TResponse> CreateAsync(TCreate entity);
        Task<TResponse> UpdateAsync(int id, TCreate entity);
        Task DeleteAsync(int id);
    }
}
