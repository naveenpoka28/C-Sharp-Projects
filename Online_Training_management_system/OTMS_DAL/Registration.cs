//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OTMS_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int RegistrationId { get; set; }
        public int TrainingId { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<decimal> FeesPaid { get; set; }
        public string Status { get; set; }
    
        public virtual Candidate Candidate { get; set; }
        public virtual Training Training { get; set; }
    }
}
