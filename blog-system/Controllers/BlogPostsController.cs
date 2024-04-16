using Microsoft.AspNetCore.Mvc;
using blog_system.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blog_system.Controllers
{
    public class BlogPostsController : Controller
    {

        private readonly BlogContext _context;

        public BlogPostsController(BlogContext context)
        {
            _context = context;
        }

        //GET: /blogposts/
        public async Task<IActionResult> Index()
        {
            var blogposts = await _context.BlogPosts.ToListAsync();
            return View(blogposts);

        }





        //// GET: /blogposts/random
        //public IActionResult Random()
        //{
        //    BlogPost b = new BlogPost() { Title = "My First Post", Body = "HELLO" };

        //    return View(b);
        //}

        //// GET: /blogposts/ 
        //public IActionResult Index(int? pageIndex, string sortBy) // int question mark means that it can be nullable
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Date";
        //    }
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        ////GET: /blogposts/{year}/{month}/{day}
        //[Route("blogposts/{year:range(1900, 2024)}/{month:range(1,12)}/{day:range(1,31)}")] //colons are 'seperators' that allow us to add constraints
        //public IActionResult ByReleaseDate(int year, int month, int day)
        //{
        //    return Content(year + "/" + month + "/" + day);
        //}

        ////POST: /blogposts/new
        //[Route("blogposts/new")]
        //[HttpPost]
        //public IActionResult New()
        //{


        //}
    }
}

