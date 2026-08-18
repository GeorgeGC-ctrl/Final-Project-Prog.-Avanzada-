using Microsoft.EntityFrameworkCore;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Entidades;

namespace Northwind.Infrastructure.Persistence.Repositorios
{
    public class CategoriaRepositorio : ICategoryRepository
    {
        private readonly NorthwindDbContext _context;

        public CategoriaRepositorio(NorthwindDbContext context)
        {
            _context = context;
        }
               
        public async Task<Categories?> GetCategoryByIdAsync(int id) => await _context.Categorias.FindAsync(id);

        public async Task<IEnumerable<Categories>> GetAllCategoriesAsync() => await _context.Categorias.ToListAsync();

        public async Task CreateCategoryAsync(Categories categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Categories categoria)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var cat = await _context.Categorias.FindAsync(id);
            if (cat != null)
            {
                _context.Categorias.Remove(cat);
                await _context.SaveChangesAsync();
            }
        }
             
        public async Task<bool> TieneProductosAsociadosAsync(int id)
        {
            return await _context.Productos.AnyAsync(p => p.CategoryId == id);
        }
    }
}


