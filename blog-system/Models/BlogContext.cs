using System;
using Microsoft.EntityFrameworkCore;
using blog_system.Models;

namespace blog_system.Data
{
	public class BlogContext : DbContext
	{
        public DbSet<BlogPost> BlogPosts { get; set; }

        public BlogContext(DbContextOptions options) : base(options) // options carried the configuration info, like the connection string and database provider
		{
		}
	}
}

