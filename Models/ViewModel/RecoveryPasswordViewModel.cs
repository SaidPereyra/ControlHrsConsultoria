using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlHrsConsultoria.Models.ViewModel
{
    public class RecoveryPasswordViewModel
    {
        public string token { get; set; }
        [Required]
        public string password { get; set; }
        [Compare("password")]
        [Required]
        public string password2 { get; set; }
    }
}