using Microsoft.AspNetCore.Mvc;
using blog_system.Data;
using Microsoft.EntityFrameworkCore;
using blog_system.ViewModels;
using blog_system.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//LINQ - language that .NET/C# uses to communicate to the database



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
        public IActionResult Index()
        {
            BlogPostsViewModel viewModel = new BlogPostsViewModel()
            {
                BlogPosts = _context.BlogPosts.ToList(),
                Comments = _context.Comments.ToList()
            };
            return View(viewModel);

        }

        public IActionResult NewPost()
        {
            return View();
        }

        //POST: /blogposts/new
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewPost(BlogPostsViewModel viewModel) //Can I bring 'bind' back into it?
        {
            if (ModelState.IsValid)
            {
                var blogpost = new BlogPost
                {
                    Body = viewModel.Body,
                    Title = viewModel.Title,
                    Date = DateTime.Now,
                    User = "testuser"
                };

                try
                {
                    _context.Update(blogpost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


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

