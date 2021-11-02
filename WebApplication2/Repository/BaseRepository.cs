using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities;

namespace WebApplication2.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DbSet<T> _db;
        protected readonly ApiContext _context;

        public BaseRepository(ApiContext context)
        {
            _db = context.Set<T>();
            _context = context;
        }

        public void Add(T entity)
        {
            _db.Add(entity);
        }

        public void Delete(T entity)
        {
            _db.Update(entity);
        }

        public IQueryable<T> GetAll()
        {
            return GetQueryable();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await GetQueryable().ToListAsync();
        }

        public IQueryable<T> GetById(int id)
        {
            return GetQueryable().Where(x => x.Id == id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await GetQueryable().FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual IQueryable<T> GetQueryable()
        {
            return _db.Where(x => !x.Deleted);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            _db.Update(entity);
        }
    }
}
