//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace medicalsite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notes_Tbl
    {
        public int ID { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Table_FK { get; set; }
        public Nullable<int> Fk_type { get; set; }
    }
}
