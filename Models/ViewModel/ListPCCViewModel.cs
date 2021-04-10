using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class ListPCCViewModel
    {
        public int idDetalle { get; set; }
        public int idProyecto { get; set; }
        public int idConsultor { get; set; }
        public Nullable<int> idPerfil { get; set; }
        public int idCliente { get; set; }
        public Nullable<decimal> montoPrecio { get; set; }
        public Nullable<decimal> costo { get; set; }
        public string descripcion { get; set; }
        public Nullable<DateTime> fechaInicio { get; set; }
        public Nullable<DateTime> fechaFinal { get; set; }
        public Nullable<decimal> cantidadHrs { get; set; }
    }
}