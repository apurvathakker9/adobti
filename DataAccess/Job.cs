//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        public System.Guid Id { get; set; }
        public System.Guid SchemaId { get; set; }
        public int VillageId { get; set; }
        public int WorkNameId { get; set; }
        public double EstimatedBudget { get; set; }
        public Nullable<double> StartLatitude { get; set; }
        public Nullable<double> StartLongitude { get; set; }
        public Nullable<double> EndLatitude { get; set; }
        public Nullable<double> EndLongitude { get; set; }
        public bool IsVerified { get; set; }
        public bool IsPathStored { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<System.Guid> PreviousGrant { get; set; }
    
        public virtual Village Village { get; set; }
        public virtual WorkName WorkName { get; set; }
        public virtual Schema Schema { get; set; }
    }
}
