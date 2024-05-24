using CategoryCrudeServiceLogic.Data;
using CategoryCrudeServiceLogic.Models;
using CategoryCrudeServiceLogic.Services.Interfaces;
using CategoryCrudeServiceLogic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CategoryCrudeServiceLogic.Controllers
{
    public class HomeController : Controller
    {
       private readonly AppDbContext _context;
       private readonly IProductService _productService;
       private readonly ICategoryService _categoryService;

        public HomeController(AppDbContext context, IProductService productService, ICategoryService categoryService)
        {
            _context = context;
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {   
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();
            List<Category> categories = await _categoryService.GetAllAsync();
            List<Product> products = await _context.Products.Include(m=>m.ProductImages).ToListAsync();
            List<Blog> blogs = await _context.Blogs.Where(m => !m.SoftDeleted).Take(3).ToListAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo,
                Categories = categories,
                Products = products,
                Blogs = blogs
            };

            return View(model);
        }
    }
}
