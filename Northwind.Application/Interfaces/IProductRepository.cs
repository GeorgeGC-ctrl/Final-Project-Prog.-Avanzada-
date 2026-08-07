using Northwind.Application.DTOs;
using Northwind.Domain.Entidades;
using System.ComponentModel;

namespace Northwind.Application.Validators.Productos
{
    public interface IProductRepository 
    {
        Task<Products?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Products>> ObtenerFiltradosAsync(int? categoriaId, int? suplidorId);
        Task CrearAsync(Products producto);
        Task ActualizarAsync(Products producto);
        Task<IEnumerable<Products>> ObtenerBajoNivelReordenAsync();
        Task ReasignarSuplidorAsync(int suplidorOrigenId, int suplidorDestinoId);
        Task IncrementarPreciosPorCategoriaAsync(int categoriaId, decimal porcentaje);
    }
}


