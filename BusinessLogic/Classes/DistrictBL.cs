using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObjects;

namespace BusinessLogic
{
    public class DistrictBL
    {
        public static bool Add(BusinessObjects.District district)
        {
            return DistrictDA.Add(district);
        }

        public static bool Update(BusinessObjects.District district)
        {
            return DistrictDA.Update(district);
        }

        public static bool Delete(BusinessObjects.District district)
        {
            return DistrictDA.Delete(district);
        }

        public static BusinessObjects.District GetDetails(int Id)
        {
            return DistrictDA.GetDetails(Id);
        }

        public static List<BusinessObjects.District> GetAll()
        {
            return DistrictDA.GetAll();
        }
    }
}
