using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IIdentityDbContext
    {
        DbSet<Usuario> Usuario { get; set; }
        DbSet<ControlIngreso> ControlIngreso { get; set; }
        DbSet<Identificacion> Identificacion { get; set; }
        DbSet<Registro> Registro { get; set; }
    }
}