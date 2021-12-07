using Aplication.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class ProduccionDbContext : DbContext, IProduccionDbContext
    {
        public DbSet<Camara> Camara { get; set; }
        public DbSet<Produccion> Produccion { get; set; }
        public DbSet<ProduccionProducto> ProduccionProducto { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<Temperatura> Temperatura { get; set; }
        public ProduccionDbContext(DbContextOptions<ProduccionDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}