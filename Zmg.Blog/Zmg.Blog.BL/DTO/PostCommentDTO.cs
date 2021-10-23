using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmg.Blog.BL.DTO
{
    public class PostCommentDTO
    {
        [Required]
        public string Comment { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public PostDTO Post { get; set; }
    }
}
