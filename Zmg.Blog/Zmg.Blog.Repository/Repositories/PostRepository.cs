using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Domain.Interfaces;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.Repository.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<List<Post>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All function error", typeof(PostRepository));
                return new List<Post>();
            }
        }

        public override async Task<bool> Update(Post entity)
        {
            try
            {
                var existingPost = await dbSet.Where(x => x.id == entity.id)
                                                    .FirstOrDefaultAsync();

                if (existingPost == null)
                    return await Add(entity);

                existingPost.title = entity.title;
                existingPost.content = entity.content;
                existingPost.last_modified_at = DateTime.Now;
                existingPost.status = entity.status;

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(PostRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.id == id)
                                        .FirstOrDefaultAsync();

                if (exist == null) return false;

                dbSet.Remove(exist);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Delete function error", typeof(PostRepository));
                return false;
            }
        }

        public Task<List<Post>> GetPostsByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
