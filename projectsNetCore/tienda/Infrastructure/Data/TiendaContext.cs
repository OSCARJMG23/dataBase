using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Reflection;

namespace Infrastructure.Data;

public class TiendaContext : DbContext
{
    public TiendaContext(DbContextOptions<TiendaContext> options) : base(options)
    {
        
    }
    public DbSet<Producto>? Productos {get;set;}
    public DbSet<Estado>? Estados {get;set;}
    public DbSet<Pais>? Paises {get;set;}
    public DbSet<Region>? Regiones {get;set;}
    public DbSet<Persona>? Personas {get;set;}
    public DbSet<TipoPersona>? TipoPersonas {get;set;}
    public DbSet<ProductoPersona>? ProductosPersonas {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
}
