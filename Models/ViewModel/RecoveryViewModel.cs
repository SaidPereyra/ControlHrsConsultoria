using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class RecoveryViewModel
    {
        [EmailAddress]
        [Required]
        public string correo { get; set; }
    }
}