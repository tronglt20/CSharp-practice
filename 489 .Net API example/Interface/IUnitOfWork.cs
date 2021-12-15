using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Interface
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;

        Task BeginTransaction();

        Task CommitTransaction();

        Task RollbackTransaction();

        Task<int> SaveChangesAsync();
    }
}
