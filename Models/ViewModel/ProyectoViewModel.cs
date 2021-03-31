using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class ProyectoViewModel
    {
        public int IdProyecto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public Nullable<decimal> MontoPrecio { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}