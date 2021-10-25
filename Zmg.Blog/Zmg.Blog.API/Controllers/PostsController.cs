using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        /// <summary>
        /// Get the posts depending on the current user role.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<Post>> Get()
        {
            List<Post> posts = new List<Post>();

            // Get user role in order to retrieve their own posts.
            var user = _httpContextAccessor.HttpContext.User;
            if (user.HasClaim(x => x.Type == ClaimTypes.Role))
            {

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
            }
            else
            {
                posts = await _posts.GetPostsByStatusAsync(PostStatus.Approved);
            }

            return posts.ToList();
        }


        /// <summary>
        /// Creates a new post
        /// </summary>
        /// <param name="postDTO"></param>
        /// <returns></returns>
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

            return Ok(new { success = true, message = "Post created successfully!" });

        }

        /// <summary>
        /// Updates a post.
        /// </summary>
        /// <param name="id">Post id</param>
        /// <param name="postDTO">JSON object with the data will be updated.</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Put(int id, [FromBody] PostDTO postDTO)
        {
            if (postDTO == null)
                return NotFound(new { success = false, message = "Post not found." });

            var post = await _posts.GetPostByIdAsync(id);

            if (post.status == (int)PostStatus.PendingApproval)
                return BadRequest(new { success = false, message = "Couldn't submit the post. This post is locked." });

            post.content = postDTO.Content;
            post.created_at = DateTime.Now;
            post.last_modified_at = DateTime.Now;
            post.title = postDTO.Title;
            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.status = (int)PostStatus.Pending;

            await _posts.UpdateAsync(post);

            return Ok(new { success = true, message = "Post updated successfully!" });

        }

        /// <summary>
        /// Submits a post.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/submit")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Submit(int id)
        {
            var post = await _posts.GetPostByIdAsync(id);

            if (post == null)
                return NotFound(new { success = false, message = "Post not found" });

            if (post.status == (int)PostStatus.PendingApproval)
                return BadRequest(new { success = false, message = "Couldn't submit the post. This post is locked." });

            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.last_modified_at = DateTime.Now;
            post.status = (int)PostStatus.PendingApproval;
            await _posts.UpdateAsync(post);

            return Ok(new { success = true, message = "Post submitted successfully!" });
        }


        /// <summary>
        /// Approves the selected post.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/approve")]
        [Authorize(Roles = "Editor")]
        public async Task<IActionResult> Approve(int id)
        {
            var post = await _posts.GetPostByIdAsync(id);

            if (post == null)
                return NotFound(new { success = false, message = "Post not found" });

            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.last_modified_at = DateTime.Now;
            post.status = (int)PostStatus.Approved;
            await _posts.UpdateAsync(post);

            return Ok(new { success = true, message = "Post approved successfully!" });
        }

        /// <summary>
        /// Rejects a post.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="postDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/reject")]
        [Authorize(Roles = "Editor")]
        public async Task<IActionResult> Reject(int id, [FromBody] PostDTO postDTO)
        {
            var post = await _posts.GetPostByIdAsync(id);

            if (post == null)
                return NotFound(new { success = false, message = "Post not found" });

            if (post.status != (int)PostStatus.Pending)
                return BadRequest(new { success = false, message = "This post can't be updated because is already published." });

            post.username = _httpContextAccessor.HttpContext.User.Identity.Name;
            post.last_modified_at = DateTime.Now;
            post.reject_comments = postDTO.reject_comments;
            post.status = (int)PostStatus.Rejected;
            await _posts.UpdateAsync(post);

            return Ok(new { success = true, message = "The post has been rejected" });
        }


        /// <summary>
        /// Creates a comment for the selected post.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/comment")]
        public async Task<IActionResult> PostComment(int id, [FromBody] string content)
        {

            try
            {
                var post = await _posts.GetPostByIdAsync(id);

                if (post == null)
                    return NotFound("Post not found");

                var user = _httpContextAccessor.HttpContext.User;
                await _posts.AddCommentAsync(post, content, user.Identity.Name);

                return Ok(new { success = true, message = "Comment posted successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"Error adding comment to post: {ex.Message}" });
            }
        }

        /// <summary>
        /// Retrieves all the post comments
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/comment")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPostComments(int id)
        {

            try
            {
                var post = await _posts.GetPostByIdAsync(id);

                if (post == null)
                    return NotFound("Post not found");

                var comments = await _posts.GetPostCommentsAsync(id);

                string json = JsonConvert.SerializeObject(comments, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    MaxDepth = 1
                });

                return Ok(json);
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = $"Error adding comment to post: {ex.Message}" });
            }
        }

      
    }
}
