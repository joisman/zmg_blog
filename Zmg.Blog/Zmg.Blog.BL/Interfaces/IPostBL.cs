using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.BL.DTO;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.BL.Interfaces
{
    public interface IPostBL
    {
        Task CreateAsync(Post post);
        Task UpdateAsync(Post post);
        Task<List<Post>> GetAllPostsAsync();
        Task<PostDTO> GetPostByIdAsync(Post post);
        Task<List<PostDTO>> GetPostByUsername(Post post);
    }
}
