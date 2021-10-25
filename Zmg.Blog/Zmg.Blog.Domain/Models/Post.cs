using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmg.Blog.Domain.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string content { get; set; }
        public DateTime created_at { get; set; }
        public int status { get; set; }
        public DateTime last_modified_at { get; set; }
        public string reject_comments { get; set; }
        [Required]
        public string username { get; set; }

        public List<PostComment> Comments { get; set; }
    }
}
