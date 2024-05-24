using CategoryCrudeServiceLogic.Data;
using CategoryCrudeServiceLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CategoryCrudeServiceLogic.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async  Task<IActionResult> Index()
        {
            return View(await _context.Blogs.Where(m => !m.SoftDeleted).Take(3).ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> ShowMore(int skip)
        {
            List<Blog> blogs = await _context.Blogs.Skip(3).Take(3).ToListAsync();

            return PartialView("_BlogsPartial",blogs);
        }
    
    }
}
