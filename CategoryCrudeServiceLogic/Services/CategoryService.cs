using CategoryCrudeServiceLogic.Data;
using CategoryCrudeServiceLogic.Models;
using CategoryCrudeServiceLogic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CategoryCrudeServiceLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.Where(m => !m.SoftDeleted).ToListAsync();
        }
    }
}
