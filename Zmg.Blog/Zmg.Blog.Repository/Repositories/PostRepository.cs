using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Domain.Interfaces;
using Zmg.Blog.Domain.Models;
using Zmg.Blog.Repository.Enums;

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
                var existingPost = await dbSet.FirstOrDefaultAsync(x => x.id == entity.id);


                if (existingPost == null)
                    return await Add(entity);

                existingPost.title = entity.title;
                existingPost.content = entity.content;
                existingPost.last_modified_at = DateTime.Now;
                existingPost.status = entity.status;
                existingPost.reject_comments = entity.status == (int)PostStatus.Rejected ? entity.reject_comments : null;

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

        public async Task<List<Post>> GetPostsByUsername(string username)
        {
            try
            {
                return await dbSet.Where(x => x.username == username).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All function error", typeof(PostRepository));
                return new List<Post>();
            }
        }

        public async Task AddCommentAsync(Post post, string content, string username)
        {
            try
            {
                var existingPost = await dbSet.FirstOrDefaultAsync(x => x.id == post.id);

                if (existingPost == null)
                    throw new Exception("Post not found");


                PostComment comment = new PostComment();
                comment.username = username;
                comment.created_at = DateTime.Now;
                comment.last_modified_at = DateTime.Now;
                comment.content = content;

                existingPost.Comments = new List<PostComment>();
                existingPost.Comments.Add(comment);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Add Comment function error", typeof(PostRepository));
            }
        }

        public async Task<List<PostComment>> GetPostCommentsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
