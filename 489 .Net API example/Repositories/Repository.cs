using _489_.Net_API_example.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbSet<T> Entities => _dbContext.Set<T>() ;

        public readonly ApplicationDbContext _dbContext;
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await Entities.FindAsync(id);
            await DeleteAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
             Entities.Remove(entity);
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            Entities.RemoveRange(entities);
        }

        public T Find(params object[] keyValues)
        {
            return Entities.Find(keyValues);
        }

        public async Task<T> FindAsync(params object[] keyValues)
        {
            return await Entities.FindAsync(keyValues);
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await Entities.ToListAsync();
        }

        public async Task InsertAsync(T entity)
        {
            await Entities.AddAsync(entity);        
        }

        public async Task InsertRangeAsync(IEnumerable<T> entities)
        {
            await Entities.AddRangeAsync(entities);
        }
    }
}
