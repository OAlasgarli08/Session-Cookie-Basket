using CategoryCrudeServiceLogic.Models;

namespace CategoryCrudeServiceLogic.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
    }
}
