using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync();

        T Find(params object[] keyValues);

        Task<T> FindAsync(params object[] keyValues);

        Task InsertAsync(T entity);

        Task InsertRangeAsync(IEnumerable<T> entities);

        Task DeleteAsync(int id);

        Task DeleteAsync(T entity);

        Task DeleteRangeAsync(IEnumerable<T> entities);
    }
}
