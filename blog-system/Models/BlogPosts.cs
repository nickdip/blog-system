using System.ComponentModel.DataAnnotations;
using blog_system.Common;

namespace blog_system.Models
{
	public class BlogPost
	{
        // primary key
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = "";

        [Required]
        [MaxLength(10000)]
        public string? Body { get; set; } = "";

        [MaxLength(ApplicationSettings.UserNameMaxLength)]
        public string User { get; set; } = "";

        public DateTime Date { get; set; }

        // navigation property 
        public ICollection<Comment>? Comments { get; set; } = new List<Comment>();

        
    }
}

// Entity Framework