using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmg.Blog.Domain.Models
{
    public class PostComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string content { get; set; }
        public string username { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_modified_at { get; set; }
        
        [Required]
        public Post Post { get; set; }
    }
}
