using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.BL.DTO;
using Zmg.Blog.Domain.Models;
using Zmg.Blog.Repository.Enums;

namespace Zmg.Blog.BL.Interfaces
{
    public interface IPostBL
    {
        Task CreateAsync(Post post);
        Task UpdateAsync(Post post);
        Task<List<Post>> GetAllPostsAsync();
        Task<List<Post>> GetPostsByStatusAsync(PostStatus status);
        
        Task<Post> GetPostByIdAsync(int id);
        Task<List<Post>> GetPostsByUsernameAsync(string username);
        Task AddCommentAsync(Post post, string comment, string username);
        Task<List<PostComment>> GetPostCommentsAsync(int postId);
    }
}
