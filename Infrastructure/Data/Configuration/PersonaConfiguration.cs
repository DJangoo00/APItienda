using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Persona");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasMaxLength(3);

            builder.Property(p => p.IdPersona)
            .IsRequired()
            .HasMaxLength(12);

            builder.Property(p => p.NombrePersona)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.FechaNac)
            .IsRequired()
            .HasColumnType("Date");

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPer);
        }
    }
}