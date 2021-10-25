using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Zmg.Blog.API.Resources;
using Zmg.Blog.BL.DTO;
using Zmg.Blog.BL.Interfaces;
using Zmg.Blog.Domain.Models;
using Zmg.Blog.Repository.Enums;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zmg.Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostBL _posts;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PostController(IPostBL posts, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _posts = posts;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/<PostController>
        [HttpGet]
        public async Task<IEnumerable<Post>> Get()
        {
            List<Post> posts = new List<Post>();

            // Get user role in order to retrieve their own posts.
            var user = _httpContextAccessor.HttpContext.User;
            string userRole = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value;

            //
            switch (userRole.ToLower())
            {
                case "writer":
                    posts = await _posts.GetPostsByUsernameAsync(user.Identity.Name);
                    break;
                case "editor":
                    posts = await _posts.GetPostsByStatusAsync(PostStatus.Pending);
                    break;
                default:
                    posts = await _posts.GetPostsByStatusAsync(PostStatus.Approved);
                    break;
            }

            return posts.ToList();
        }


        [HttpPost]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Post([FromBody] PostDTO postDTO)
        {

            var user = _httpContextAccessor.HttpContext.User;

            Post post = new Post();
            post.content = postDTO.Content;
            post.created_at = DateTime.Now;
            post.last_modified_at = DateTime.Now;
            post.title = postDTO.Title;
            post.username = user.Identity.Name;
            post.status = (int)PostStatus.Pending;

            await _posts.CreateAsync(post);


            return Ok("Post created successfully!");
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Put(int id, [FromBody] PostDTO postDTO)
        {
            if (postDTO == null)
                return BadRequest();

            var post = await _posts.GetPostByIdAsync(id);

            if (post.status == (int)PostStatus.PendingApproval)
                return BadRequest("The post is locked");

            post.content = postDTO.Content;
            post.created_at = DateTime.Now;
            post.last_modified_at = DateTime.Now;
            post.title = postDTO.Title;
            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.status = (int)PostStatus.Pending;

            await _posts.UpdateAsync(post);

            return Ok("Post updated successfully!");

        }

        [HttpGet]
        [Route("{id}/submit")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Submit(int id)
        {
            var post = await _posts.GetPostByIdAsync(id);

            if (post == null)
                return NotFound("Post not found");

            if (post.status == (int)PostStatus.PendingApproval)
                return BadRequest("The post is locked");

            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.last_modified_at = DateTime.Now;
            post.status = (int)PostStatus.PendingApproval;
            await _posts.UpdateAsync(post);

            return Ok("Post submitted successfully!");
        }


        [HttpGet]
        [Route("{id}/approve")]
        [Authorize(Roles = "Editor")]
        public async Task<IActionResult> Approve(int id)
        {
            var post = await _posts.GetPostByIdAsync(id);

            if (post == null)
                return NotFound("Post not found");

            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.last_modified_at = DateTime.Now;
            post.status = (int)PostStatus.Approved;
            await _posts.UpdateAsync(post);

            return Ok("Post approved successfully!");
        }

        [HttpPut]
        [Route("{id}/reject")]
        [Authorize(Roles = "Editor")]
        public async Task<IActionResult> Reject(int id, [FromBody] PostDTO postDTO)
        {
            var post = await _posts.GetPostByIdAsync(id);

            if (post == null)
                return NotFound("Post not found");

            if (post.status != (int)PostStatus.Pending)
                return BadRequest("This post can't be updated.");

            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.last_modified_at = DateTime.Now;
            post.reject_comments = postDTO.reject_comments;
            post.status = (int)PostStatus.Rejected;
            await _posts.UpdateAsync(post);

            return Ok("Post has been rejected");
        }


        [Route("{id}/comment")]
        [HttpPost]
        public async Task<IActionResult> PostComment(int id, [FromBody] string content)
        {

            try
            {
                var post = await _posts.GetPostByIdAsync(id);

                if (post == null)
                    return NotFound("Post not found");

                var user = _httpContextAccessor.HttpContext.User;
                await _posts.AddCommentAsync(post, content, user.Identity.Name);

                return Ok("Comment posted successfully!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error adding comment to post: {ex.Message}");
            }
        }

        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
