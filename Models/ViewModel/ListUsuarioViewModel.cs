using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class ListUsuarioViewModel
    {
        public Nullable<int> idUsuario { get; set; }
        public string nombre {get; set;}
        public string apellidos {get; set;}
        public string correo {get; set;}
        public string contraseña { get; set; }
        public Nullable<DateTime> fechaRegistro { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> idRol { get; set; }

    }
}