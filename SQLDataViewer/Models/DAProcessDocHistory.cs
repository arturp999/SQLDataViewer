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
    
    public partial class DAProcessDocHistory
    {
        public long SeqNbr { get; set; }
        public long DAProcessDocSeqNbr { get; set; }
        public System.DateTime AttachmentDate { get; set; }
        public string User { get; set; }
        public string Path { get; set; }
    
        public virtual DAProcessDoc DAProcessDoc { get; set; }
    }
}