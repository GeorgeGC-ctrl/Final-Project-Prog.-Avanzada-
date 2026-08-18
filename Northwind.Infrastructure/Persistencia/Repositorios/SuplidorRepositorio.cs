using Microsoft.EntityFrameworkCore;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Entidades;

namespace Northwind.Infrastructure.Persistence.Repositorios
{
    public class SuplidorRepositorio : ISupplierRepository
    {
        private readonly NorthwindDbContext _context;

        public SuplidorRepositorio(NorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<Suppliers?> ObtenerPorIdAsync(int id) =>
            await _context.Suplidores.FindAsync(id);

        public async Task<IEnumerable<Suppliers>> ObtenerTodosAsync() =>
            await _context.Suplidores.ToListAsync();

        public async Task CrearAsync(Suppliers suplidor)
        {
            await _context.Suplidores.AddAsync(suplidor);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Suppliers suplidor)
        {
            _context.Suplidores.Update(suplidor);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var suplidor = await _context.Suplidores.FindAsync(id);
            if (suplidor != null)
            {
                _context.Suplidores.Remove(suplidor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> TieneProductosAsociadosAsync(int id) =>
            await _context.Productos.AnyAsync(p => p.SupplierId == id);
    }
}
