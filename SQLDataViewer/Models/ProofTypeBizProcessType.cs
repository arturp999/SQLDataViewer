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
    
    public partial class ProofTypeBizProcessType
    {
        public string BizProcessTypeCode { get; set; }
        public string ProofTypeCode { get; set; }
        public string DocTemplateCode { get; set; }
        public bool IsMandatory { get; set; }
        public Nullable<int> HolderNbr { get; set; }
    
        public virtual BizProcessType BizProcessType { get; set; }
        public virtual ProofType ProofType { get; set; }
    }
}
