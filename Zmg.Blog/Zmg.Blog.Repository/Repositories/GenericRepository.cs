using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Repository.IRepositories;

namespace Zmg.Blog.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal DbSet<T> dbSet;
        protected ApplicationDbContext context;
        public readonly ILogger _logger;

        public GenericRepository(ApplicationDbContext context, ILogger logger)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            _logger = logger;
        }

        public virtual async Task<bool> Add(T entity)
        {
            dbSet.Add(entity);
            await context.SaveChangesAsync();
            return true;
        }

        public virtual async Task<List<T>> All()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Update(T entity)
        {
            return true;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }
    }
}
