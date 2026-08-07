namespace Northwind.Application.DTOs
{
 
    public record CategoriaDto(int CategoryId, string CategoryName, string? Description);
    public record CrearCategoriaRequest(string CategoryName, string? Description);
    public record EditarCategoriaRequest(int CategoryId, string CategoryName, string? Description);
}

