using System;
using blog_system.Models;

namespace blog_system.ViewModels
{
	public class BlogPostsViewModel
	{

        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public string CommentBody { get; set; } = "";
        public ICollection<BlogPost>? BlogPosts { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public string User { get; set; } = "testUser";
    }
}

