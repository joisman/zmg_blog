using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.Repository
{
    public interface IApplicationDbContext
    {
        DbSet<Post> Posts { get; set; }

        DbSet<PostComment> Comments { get; set; }
        Task<int> SaveChanges();
    }
}