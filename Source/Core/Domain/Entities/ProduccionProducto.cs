using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class ProduccionProducto: BaseEntity
    {

        [Display(Name = "Cantidad")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal CantidadProducto { get; set; }
        [Display(Name = "Calidad")]
        public Calidad CalidadFinal { get; set; }
        [Display(Name = "Viento")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal TiempoViento { get; set; }
        [Display(Name = "Extractor")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal TiempoExtractor { get; set; }
        [Display(Name = "Calor")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal TiempoCalor { get; set; }

        public int IdProducto { get; set; }
        [ForeignKey("IdProducto")]
        public Producto? Producto { get; set; }

        public int IdProduccion { get; set; }
        [ForeignKey("IdProduccion")]
        public Produccion? Produccion { get; set; }

        public int IdCamara { get; set; }
        [ForeignKey("IdCamara")]
        public Camara? Camara { get; set; }
        public List<Temperatura>? Temperaturas { get; set; }
    }

}