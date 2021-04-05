using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class UsuarioViewModel
    {
        [Required]
        [Display(Name = "ID usuario")]
        public int idUsuario { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(2)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(2)]
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]
        [MinLength(5)]
        [Display(Name = "Correo eléctronico")]
        public string correo { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(8)]
        [Display(Name = "Contraseña")]
        public string contraseña { get; set; }
        [Required]
        [Display(Name = "Fecha de registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> fechaRegistro { get; set; }
        [Required]
        [Display(Name = "Estatus")]
        public Nullable<bool> status { get; set; }
        [Required]
        [Display(Name = "Rol de usuario")]
        public Nullable<int> idRol { get; set; }
        
    }
}