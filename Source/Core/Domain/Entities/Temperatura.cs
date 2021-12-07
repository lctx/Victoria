using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities
{
    public class Temperatura : BaseEntity
    {

        [Column(TypeName = "decimal(5, 2)")]
        [Display(Name = "Temperatura")]
        public decimal TemperaturaCamara { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Humedad { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdProduccionProducto { get; set; }
        [ForeignKey("IdProduccionProducto")]
        public ProduccionProducto? ProduccionProducto { get; set; }
        public int IdSensor { get; set; }
        [ForeignKey("IdSensor")]
        public Sensor? Sensor { get; set; }
    }
}