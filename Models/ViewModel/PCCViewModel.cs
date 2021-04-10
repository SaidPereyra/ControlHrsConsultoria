using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class PCCViewModel
    {
        public int idDetalle { get; set; }
        [StringLength(100)]
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
        [Display(Name = "Fecha de Inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> fechaInicio { get; set; }
        [Display(Name = "Fecha de Finalización")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> fechaFinal { get; set; }
        [Required]
        [Range(0, 999.99)]
        [Display(Name = "Cantidad de Horas")]
        public Nullable<decimal> cantidadHrs { get; set; }
    }
}