using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Persistencia.Configuration
{
    public class ProductsConfiguration: IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired().HasMaxLength(40);
            builder.Property(p => p.QuantityPerUnit).HasMaxLength(20);
            builder.Property(p => p.UnitPrice).HasColumnType("money");
            builder.Property(p => p.UnitsInStock).HasColumnType("smallint");
            builder.Property(p => p.UnitsOnOrder).HasColumnType("smallint");
            builder.Property(p => p.ReorderLevel).HasColumnType("smallint");
            builder.Property(p => p.Discontinued).IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            builder.HasOne(p => p.Suplidor)
                .WithMany(s => s.Productos)
                .HasForeignKey(p => p.SupplierId);
        }
    }
}
