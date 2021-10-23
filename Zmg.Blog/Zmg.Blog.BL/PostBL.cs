using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.BL.DTO;
using Zmg.Blog.BL.Interfaces;
using Zmg.Blog.Domain.Interfaces;
using Zmg.Blog.Domain.Models;

namespace Zmg.Blog.BL
{
    public class PostBL : IPostBL
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetAllPostsAsync()
        {
            try
            {
                List<Post> posts = await _unitOfWork.Posts.All();
                return posts;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<PostDTO> GetPostByIdAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostDTO>> GetPostByUsername(Post post)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
