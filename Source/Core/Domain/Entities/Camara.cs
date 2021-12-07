using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities
{
    public class Camara : BaseEntity
    {
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }
        //[Range(1,100)]
        //[MaxLength(5)]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Capacidad { get; set; }
        public List<Sensor>? Sensores { get; set; }
        public List<ProduccionProducto>? ProduccionProductos { get; set; }
    }
}