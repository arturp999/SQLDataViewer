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
    
    public partial class DAProcessSignature
    {
        public long SeqNbr { get; set; }
        public long DAProcessSeqNbr { get; set; }
        public string SignatureKey { get; set; }
        public string StatusDate { get; set; }
        public string StatusTime { get; set; }
        public string Status { get; set; }
        public Nullable<long> DAProcessDocSeqNbr { get; set; }
        public string SignatureTypeCode { get; set; }
    
        public  DAProcess DAProcess { get; set; }
        public  DAProcessDoc DAProcessDoc { get; set; }
        public  DAProcessSignatureStatu DAProcessSignatureStatu { get; set; }
        public  SignatureType SignatureType { get; set; }
    }
}