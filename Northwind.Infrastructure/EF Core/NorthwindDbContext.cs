using Microsoft.EntityFrameworkCore;
using Northwind.Domain.Entidades;

namespace Northwind.Infrastructure;

public class NorthwindDbContext : DbContext
{

    public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options)
    {

    }
    public DbSet<Categories> Categorias { get; set; }
    public DbSet<Suppliers> Suplidores { get; set; }
    public DbSet<Products> Productos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(NorthwindDbContext).Assembly);

    }
}
