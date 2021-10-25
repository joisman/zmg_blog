using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zmg.Blog.Web.Models
{
    public class PostModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime created_at { get; set; }
        public int status { get; set; }
        public DateTime last_modified_at { get; set; }
        public string reject_comments { get; set; }
        public string username { get; set; }
    }
}
