using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Zmg.Blog.Web.Models;

namespace Zmg.Blog.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public BlogController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            List<PostModel> postList = new List<PostModel>();
            var request = new HttpRequestMessage(HttpMethod.Get, "post");

            var client = _clientFactory.CreateClient("blogAPI");
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                postList = await JsonSerializer.DeserializeAsync<List<PostModel>>(responseStream);
            }

            return View(postList);
        }

        [Route("post/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            List<PostCommentModel> postList = new List<PostCommentModel>();
            var request = new HttpRequestMessage(HttpMethod.Get, $"post/{id}/comment");

            var client = _clientFactory.CreateClient("blogAPI");
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                postList = await JsonSerializer.DeserializeAsync<List<PostCommentModel>>(responseStream);
            }

            return View(postList);
        }
    }
}
