//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurnosBus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class frequency
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> hour { get; set; }
        public Nullable<int> @fixed { get; set; }
        public Nullable<int> available { get; set; }
        public Nullable<int> id_place { get; set; }
        public Nullable<int> id_bus { get; set; }
    
        public virtual bus bus { get; set; }
        public virtual place place { get; set; }
    }
}
