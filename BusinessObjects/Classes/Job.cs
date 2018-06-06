using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Job
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

        public virtual Schema Schema { get; set; }
        public virtual Village Village { get; set; }
        public virtual WorkName WorkName { get; set; }
    }
}
