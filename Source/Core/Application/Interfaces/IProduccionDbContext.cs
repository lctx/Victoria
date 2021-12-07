using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aplication.Interfaces
{
    public interface IProduccionDbContext
    {
        DbSet<Camara> Camara { get; set; }
        DbSet<Produccion> Produccion { get; set; }
        DbSet<ProduccionProducto> ProduccionProducto { get; set; }
        DbSet<Producto> Producto { get; set; }
        DbSet<Sensor> Sensor { get; set; }
        DbSet<Temperatura> Temperatura { get; set; }
        ///no se si este metodo tenga una utilidad por eso esta comentado
        //Task<int> SaveChangesAsync();
    }
}