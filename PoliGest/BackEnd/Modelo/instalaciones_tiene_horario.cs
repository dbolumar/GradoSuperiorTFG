//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoliGest.BackEnd.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class instalaciones_tiene_horario
    {
        public int instalaciones_idinstalaciones { get; set; }
        public int dia_iddia { get; set; }
        public int horario_idhorario { get; set; }
    
        public virtual dia dia { get; set; }
        public virtual horario horario { get; set; }
        public virtual tipo_instalacion tipo_instalacion { get; set; }
    }
}
