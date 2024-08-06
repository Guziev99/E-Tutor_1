using E_TutorApp.Application.Repositories.Common;
using E_TutorApp.Domain.Entities.Common;
using E_TutorApp.Persistence.Db_Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TutorApp.Persistence.Repositories.Common
{
    public class WriteGenericRepository<T> : GenericRepository<T>, IWriteGenericRepository<T> where T : class, IBaseEntity, new()
    {
        public WriteGenericRepository(TutorDbContext dbcontext) : base(dbcontext)
        {
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
