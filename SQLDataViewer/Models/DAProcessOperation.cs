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
    
    public partial class DAProcessOperation
    {
        public long SeqNbr { get; set; }
        public long DAProcessSeqNbr { get; set; }
        public string OpType { get; set; }
        public string OpDate { get; set; }
        public string OpTime { get; set; }
        public string User { get; set; }
        public string DAProcessStatus { get; set; }
        public string Data { get; set; }
    
        public DAProcess DAProcess { get; set; }
    }
}
