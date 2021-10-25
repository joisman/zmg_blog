using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zmg.Blog.Web.Models
{
    public class PostCommentModel
    {
        public int id { get; set; }
        public string content { get; set; }
        public string username { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_modified_at { get; set; }

        public PostModel Post { get; set; }
    }
}
