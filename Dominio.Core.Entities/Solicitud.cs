using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Core.Entities
{
    public class Solicitud
    {
        [Display(Name ="Codigo Solicitud")]
        [Required(ErrorMessage ="Ingrese código")]
        public Int32 idsol { get; set; }
        [Display(Name = "Fecha Solicitud")]
        [Required(ErrorMessage = "Ingrese fecha de solicitud")]
        public DateTime fechasol { get; set; }
        [Display(Name = "Codigo Cliente")]
        [Required(ErrorMessage = "Ingrese código de cliente")]
        public string idcliente { get; set; }
        [Display(Name = "Detalle de Solicitud")]
        [Required(ErrorMessage = "Ingrese detalle de solicitud")]
        public string detsol { get; set; }
        [Display(Name = "Costo de Solicitud")]
        [Required(ErrorMessage = "Ingrese costo de solicitud")]
        public decimal costosol { get; set; }
    }
}
