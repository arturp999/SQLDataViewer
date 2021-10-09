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
    
    public partial class EAIClientLog
    {
        public long ID { get; set; }
        public string Method { get; set; }
        public string Type { get; set; }
        public string Application { get; set; }
        public string Channel { get; set; }
        public string Url { get; set; }
        public string Request { get; set; }
        public int RequestSize { get; set; }
        public System.DateTime RequestTimestamp { get; set; }
        public string Response { get; set; }
        public int ResponseSize { get; set; }
        public System.DateTime ResponseTimestamp { get; set; }
        public int ExecutionTimeMS { get; set; }
        public string ExternalID { get; set; }
        public string KeyData { get; set; }
        public string BizProcNbr { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
