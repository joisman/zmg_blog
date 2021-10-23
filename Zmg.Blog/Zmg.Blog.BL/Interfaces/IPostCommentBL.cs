using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.BL.Interfaces
{
    public interface IPostCommentBL
    {
        Task CreateAsync(PostComment post);
        Task DeleteAsync(PostComment post);
        Task<List<PostComment>> GetPostCommentsAsync(int postId);
    }
}
