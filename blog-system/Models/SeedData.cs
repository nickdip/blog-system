using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using blog_system.Data;

namespace blog_system.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new BlogContext(serviceProvider.GetRequiredService<DbContextOptions<BlogContext>>()))
			{
				if (context.BlogPosts.Any())
				{
					return; // database has been seeded
				}

                context.BlogPosts.AddRange(
                    new BlogPost
                    {
                        Title = "Lorem Ipsum",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        User = "user123",
                        Date = DateTime.Parse("2023-04-10")
                    },
                    new BlogPost
                    {
                        Title = "Nulla facilisi",
                        Body = "Nulla facilisi. Ut eget quam a tellus sollicitudin lacinia.",
                        User = "john_doe",
                        Date = DateTime.Parse("2023-05-15")
                    },
                    new BlogPost
                    {
                        Title = "Vestibulum ante ipsum",
                        Body = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In eget dui id leo commodo sollicitudin.",
                        User = "jane_smith",
                        Date = DateTime.Parse("2023-06-20")
                    },
                    new BlogPost
                    {
                        Title = "Duis ac quam",
                        Body = "Duis ac quam id lectus efficitur volutpat ut nec libero.",
                        User = "blogger123",
                        Date = DateTime.Parse("2023-07-25")
                    },
                    new BlogPost
                    {
                        Title = "Fusce condimentum",
                        Body = "Fusce condimentum nunc in nisl rutrum, sit amet rhoncus ex facilisis.",
                        User = "writer456",
                        Date = DateTime.Parse("2023-08-30")
                    }
                    );

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving changes: " + ex.Message);
                }
            }
		}
	}
}

