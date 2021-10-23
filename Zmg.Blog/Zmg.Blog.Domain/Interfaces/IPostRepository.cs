using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Domain.Models;
using Zmg.Blog.Repository.IRepositories;

namespace Zmg.Blog.Domain.Interfaces
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Task<List<Post>> GetPostsByUsername(string username);
    }
}
