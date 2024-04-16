using System.ComponentModel.DataAnnotations;
using blog_system.Common;

namespace blog_system.Models
{
	public class BlogPost
	{
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = "";

        [Required]
        [MaxLength(10000)]
        public string? Body { get; set; } = "";

        [Required]
        [MaxLength(ApplicationSettings.UserNameMaxLength)]
        public string User { get; set; } = "";

        [Required]
        public DateTime Date { get; set; }

        
    }
}

