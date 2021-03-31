using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class FProyectoViewModel
    {
        public int IdProyecto { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Proyecto")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Descripción del proyecto")]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha inicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Final")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaFinal { get; set; }

        [Required]
        [Display(Name = "Precio Proyecto")]
        public Nullable<decimal> MontoPrecio { get; set; }

        [Required]
        [Display(Name = "Costo Proyecto")]
        public Nullable<decimal> Costo { get; set; }

        [Required]
        [Display(Name = "Estatus")]
        public bool Status { get; set; }
    }


}