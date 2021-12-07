using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    public class Produccion: BaseEntity
    {
        
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public bool Activa { get; set; }
        public string? Observaciones { get; set; }
        public List<ProduccionProducto>? ProduccionProductos { get; set; }
    }
}