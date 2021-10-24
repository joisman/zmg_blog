using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zmg.Blog.BL.Interfaces;
using Zmg.Blog.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zmg.Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostBL _posts;
        public PostController(IPostBL posts)
        {
            _posts = posts;
        }

        // GET: api/<PostController>
        [HttpGet]
        [Authorize]
        public async Task<IEnumerable<Post>> Get()
        {

            var obj = await _posts.GetAllPostsAsync();
            return obj.ToList();
        }

        //public async Task<IEnumerable<PostComment>> GetPostComments()
        //{

        //}

        // GET api/<PostController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PostController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
