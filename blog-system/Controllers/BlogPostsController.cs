using Microsoft.AspNetCore.Mvc;
using blog_system.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blog_system.Controllers
{
    public class BlogPostsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /blogposts/random
        public IActionResult Random()
        {
            BlogPost b = new BlogPost() { Title = "My First Post", Body = "HELLO" };
            return View(b);
        }
    }
}

