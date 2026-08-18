using Microsoft.EntityFrameworkCore;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Entidades;

namespace Northwind.Infrastructure.Persistence.Repositorios
{
    public class ProductoRepositorio : IProductRepository
    {
        private readonly NorthwindDbContext _context;

        public ProductoRepositorio(NorthwindDbContext context)
        {
            _context = context;
        }

        public async Task<Products?> ObtenerPorIdAsync(int id) =>
            await _context.Productos
                .Include(p => p.Categoria)
                .Include(p => p.Suplidor)
                .FirstOrDefaultAsync(p => p.ProductId == id);

        public async Task<IEnumerable<Products>> ObtenerFiltradosAsync(int? categoriaId, int? suplidorId)
        {
            var query = _context.Productos
                .Include(p => p.Categoria)
                .Include(p => p.Suplidor)
                .AsQueryable();

            if (categoriaId.HasValue)
                query = query.Where(p => p.CategoryId == categoriaId);

            if (suplidorId.HasValue)
                query = query.Where(p => p.SupplierId == suplidorId);

            return await query.ToListAsync();
        }

        public async Task CrearAsync(Products producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Products producto)
        {
            _context.Productos.Update(producto);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Products>> ObtenerBajoNivelReordenAsync() =>
            await _context.Productos
                .Where(p => p.ReorderLevel.HasValue && p.UnitsInStock.HasValue && p.UnitsInStock <= p.ReorderLevel)
                .ToListAsync();

        public async Task ReasignarSuplidorAsync(int suplidorOrigenId, int suplidorDestinoId)
        {
            var productos = await _context.Productos
                .Where(p => p.SupplierId == suplidorOrigenId)
                .ToListAsync();

            foreach (var producto in productos)
                producto.SupplierId = suplidorDestinoId;

            await _context.SaveChangesAsync();
        }

        public async Task IncrementarPreciosPorCategoriaAsync(int categoriaId, decimal porcentaje)
        {
            var productos = await _context.Productos
                .Where(p => p.CategoryId == categoriaId)
                .ToListAsync();

            foreach (var producto in productos)
                producto.AplicarIncrementoPrecio(porcentaje);

            await _context.SaveChangesAsync();
        }
    }
}
