using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Schema
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public Nullable<double> GrantMoney { get; set; }
        public System.DateTime DateAdded { get; set; }
    }
}
