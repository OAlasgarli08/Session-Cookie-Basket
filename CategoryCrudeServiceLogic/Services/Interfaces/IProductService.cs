using CategoryCrudeServiceLogic.Models;

namespace CategoryCrudeServiceLogic.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
    }
}
