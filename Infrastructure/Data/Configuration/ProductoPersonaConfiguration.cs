using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProductoPersonaConfiguration : IEntityTypeConfiguration<ProductoPersona>
    {
        public void Configure(EntityTypeBuilder<ProductoPersona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("ProductoPersona");

            builder.HasOne(p=> p.Persona)
            .WithMany(p=> p.ProductosPersonas)
            .HasForeignKey(p=> p.IdPersona);

            builder.HasOne(p=> p.Producto)
            .WithMany(p=> p.ProductosPersonas)
            .HasForeignKey(p=> p.IdProducto);
        }
    }
}