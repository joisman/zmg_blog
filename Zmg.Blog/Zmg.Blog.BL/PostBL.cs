using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zmg.Blog.BL.DTO;
using Zmg.Blog.BL.Interfaces;
using Zmg.Blog.Domain.Interfaces;
using Zmg.Blog.Domain.Models;
using Zmg.Blog.Repository.Enums;

namespace Zmg.Blog.BL
{
    public class PostBL : IPostBL
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCommentAsync(Post post, string comment, string username)
        {
            await _unitOfWork.Posts.AddCommentAsync(post, comment, username);
        }


        public async Task CreateAsync(Post post)
        {
            await _unitOfWork.Posts.Add(post);
            await _unitOfWork.CompleteAsync();
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

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return await _unitOfWork.Posts.GetById(id);
        }

        public async Task<List<Post>> GetPostsByUsernameAsync(string username)
        {
            return await _unitOfWork.Posts.GetPostsByUsername(username);
        }

        public async Task<List<PostComment>> GetPostCommentsAsync(int postId)
        {
            return await _unitOfWork.Posts.GetPostCommentsByIdAsync(postId);
        }

        public async Task UpdateAsync(Post post)
        {
            await _unitOfWork.Posts.Update(post);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<List<Post>> GetPostsByStatusAsync(PostStatus status)
        {
            var posts = await _unitOfWork.Posts.Find(x => x.status == (int)status);
            return posts.ToList();
        }
    }
}
