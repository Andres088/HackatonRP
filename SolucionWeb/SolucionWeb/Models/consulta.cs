//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolucionWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class consulta
    {
        public int query_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string departamento { get; set; }
        public string mall { get; set; }
        public string rubro { get; set; }
        public string tienda { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
    }
}