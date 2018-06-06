using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Grant
    {
        public System.Guid Id { get; set; }
        public System.Guid SchemaId { get; set; }
        public int VillageId { get; set; }
        public int DistrictId { get; set; }
        public int WorkNameId { get; set; }
        public System.DateTime MeetingDate { get; set; }
        public double RecievedMoney { get; set; }
        public Nullable<double> SpentMoney { get; set; }
        public Nullable<double> RemainingMoney { get; set; }
        public int CertificateNumber { get; set; }
        public System.DateTime CertificateDate { get; set; }
        public string Comments { get; set; }
        public Nullable<double> StartLatitude { get; set; }
        public Nullable<double> StartLongitude { get; set; }
        public Nullable<double> EndLatitude { get; set; }
        public Nullable<double> EndLongitude { get; set; }

        public virtual District District { get; set; }
        public virtual Schema Schema { get; set; }
        public virtual Village Village { get; set; }
        public virtual WorkName WorkName { get; set; }
    }
}
