

using System.ComponentModel.DataAnnotations;

namespace blog_system.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string? User { get; set; }

        [Required]
        public string? Body { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        //foreign key 
        [Required]
        public int? BlogPostId { get; set; }

        //navigation property
        public BlogPost? BlogPost { get; set; }
    }
}

