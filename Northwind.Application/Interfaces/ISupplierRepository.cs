
using Northwind.Application.DTOs;
using Northwind.Domain.Entidades;

namespace Northwind.Application.Validators.Suplidores
{
    public interface ISupplierRepository
    {
        Task<Suppliers?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Suppliers>> ObtenerTodosAsync();
        Task CrearAsync(Suppliers suplidor);
        Task ActualizarAsync(Suppliers suplidor);
        Task EliminarAsync(int id);
        Task<bool> TieneProductosAsociadosAsync(int id);
    }
}