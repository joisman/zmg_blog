using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zmg.Blog.API.Resources
{
    
    public class PostResource
    {
        public string title { get; set; }
        public string content { get; set; }
        public int status { get; set; }
        public string username { get; set; }
    }
}
