using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Domain.Entidades;

namespace Northwind.Infrastructure.Persistencia.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Suppliers>
    {
        public void Configure(EntityTypeBuilder<Suppliers> builder)
        {
            builder.ToTable("Suppliers");
            builder.HasKey(s => s.SupplierId);
            builder.Property(s => s.CompanyName).IsRequired().HasMaxLength(40);
            builder.Property(s => s.ContactName).HasMaxLength(30);
            builder.Property(s => s.ContactTitle).HasMaxLength(30);
            builder.Property(s => s.Address).HasMaxLength(60);
            builder.Property(s => s.City).HasMaxLength(15);
            builder.Property(s => s.Region).HasMaxLength(15);
            builder.Property(s => s.PostalCode).HasMaxLength(10);
            builder.Property(s => s.Country).HasMaxLength(15);
            builder.Property(s => s.Phone).HasMaxLength(24);
            builder.Property(s => s.Fax).HasMaxLength(24);
        }
    }
}
