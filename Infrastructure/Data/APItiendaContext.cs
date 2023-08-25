using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class APItiendaContext : DbContext
{
    public APItiendaContext(DbContextOptions<APItiendaContext> options) : base(options)
    {
    }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<ProductoPersona> ProductosPersonas { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>().HasIndex(idx => idx.IdPersona).IsUnique();
        modelBuilder.Entity<ProductoPersona>().HasKey(r => new {r.IdPersona, r.IdProducto});
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}