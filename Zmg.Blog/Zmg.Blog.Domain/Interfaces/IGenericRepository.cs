using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zmg.Blog.Repository.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> All();
        Task<T> GetById(int id);
        Task<bool> Add(T entity);
        Task<bool> Delete(int id);
        Task<bool> Update(T entity);
    }
}
