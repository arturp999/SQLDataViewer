//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace portalSQL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeclarationRequest
    {
        public long SeqNbr { get; set; }
        public long DAProcessSeqNbr { get; set; }
        public string TypeCode { get; set; }
        public bool Processed { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public string PostalCode { get; set; }
        public string CodeM37 { get; set; }
    
        public virtual DAProcess DAProcess { get; set; }
    }
}
