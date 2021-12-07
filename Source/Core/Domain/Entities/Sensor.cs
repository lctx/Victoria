using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities
{
    public class Sensor: BaseEntity
    {
        
        public string Tipo { get; set; }
        public string Marca { get; set; }
        [Display(Name = "Ubicación")]
        public string Ubicacion { get; set; }
        public int IdCamara { get; set; }
        [ForeignKey("IdCamara")]
        public Camara? Camara { get; set; }
        public List<Temperatura>? Temperaturas { get; set; }
    }
}