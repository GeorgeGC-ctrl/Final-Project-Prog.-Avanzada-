using Northwind.Application.DTOs;
using Northwind.Domain.Entidades;

namespace Northwind.Application.Validators.Categorias
{
    public interface ICategoryRepository
    {      
        Task<Categories?> GetCategoryByIdAsync(int id);
        Task<IEnumerable<Categories>> GetAllCategoriesAsync();
        Task CreateCategoryAsync(Categories categoria);
        Task UpdateCategoryAsync(Categories categoria);
        Task DeleteCategoryAsync(int id);
        Task<bool> TieneProductosAsociadosAsync(int id);
    }
}

