using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Registro : BaseEntity
    {
        [Display(Name = "Fecha")]
        public DateTime FechaHora { get; set; }
        public string idUsuario { get; set; }
        //[EnumDataType(typeof(TipoRegistro), ErrorMessage = "Tipo de registro desconocido")]
        public TipoRegistro Tipo { get; set; }
        public virtual ControlIngreso? ControlIngresos { get; set; }

        [ForeignKey("idUsuario")]
        public Usuario? Usuario { get; set; }
    }
}