using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.DTOs
{
    public record SuplidorDto(int SupplierId, string CompanyName, string? ContactName, string? ContactTitle, string? Phone, string? Country, string city);
    public record CrearSuplidorRequest(string CompanyName, string? ContactName, string? ContactTitle, string? Phone, string? Country, string city);  
    public record EditarSuplidorRequest(int SupplierId, string CompanyName, string? ContactName, string? ContactTitle, string? Phone, string? Country, string city);
    public record ReasignarSuplidorRequest(int SuplidorOrigenId, int SuplidorDestinoId);
    public record IncrementarPrecioCategoriaRequest(int CategoriaId, decimal Porcentaje);
}
