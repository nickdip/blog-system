using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_system.Data;
using blog_system.Models;
using blog_system.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blog_system.Controllers
{
    public class CommentsController : Controller
    {

        private readonly BlogContext _context;

        public CommentsController(BlogContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [HttpPost]
        //[AutoValidateAntiforgeryToken]
        public async Task<IActionResult> PostComment([FromBody] AddCommentViewModel input)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // This will send a 400 response with the validation errors.
            }

            Comment comment = new Comment
            {
                Body = input.Body,
                User = "testUser",
                BlogPostId = input.BlogID

            };
            try
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Comment added successfully!" });
            }
            catch (DbUpdateConcurrencyException)
            {
                return Json(new { success = false, message = "Comment not added" });
            }

        }
    }
}

