
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    public class Producto : BaseEntity
    {

        public string Nombre { get; set; }
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }
        public List<ProduccionProducto>? ProduccionProductos { get; set; }

    }
}