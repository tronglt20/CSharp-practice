using _489_.Net_API_example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public Task CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public Task RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
        public IRepository<T> Repository<T>() where T : class
        {
            throw new NotImplementedException();
        }

    }
}
