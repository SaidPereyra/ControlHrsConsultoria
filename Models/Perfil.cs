//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlHrsConsultoria.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Perfil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Perfil()
        {
            this.Proyecto_Consultor_Cliente = new HashSet<Proyecto_Consultor_Cliente>();
        }
    
        public int idPerfil { get; set; }
        public Nullable<decimal> tarifa { get; set; }
        public string descripcion { get; set; }
        public string nivelPerfil { get; set; }
        public Nullable<int> idIdioma { get; set; }
    
        public virtual Idioma Idioma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto_Consultor_Cliente> Proyecto_Consultor_Cliente { get; set; }
    }
}
