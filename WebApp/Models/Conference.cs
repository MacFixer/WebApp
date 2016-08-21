//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conference
    {
        public int ConferenceId { get; set; }
        public System.DateTime CDate { get; set; }
        public string CTheme { get; set; }
        public byte CTypeId { get; set; }
        public int ClientId { get; set; }
        public string CPlace { get; set; }
        public string CDescription { get; set; }
        public bool CStatus { get; set; }
        public Nullable<System.Guid> ConferenceGuid { get; set; }
        public string CComment { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ConferenceType ConferenceType { get; set; }
    }
}