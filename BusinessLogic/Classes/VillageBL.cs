using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class VillageBL
    {
        public static bool Add(BusinessObjects.Village villageBO)
        {
            return VillageDA.Add(villageBO);
        }

        public static bool Update(BusinessObjects.Village villageBO)
        {
            return VillageDA.Update(villageBO);
        }

        public static bool Delete(BusinessObjects.Village villageBO)
        {
            return VillageDA.Delete(villageBO);
        }

        public static BusinessObjects.Village GetDetails(int Id)
        {
            return VillageDA.GetDetails(Id);
        }

        public static List<BusinessObjects.Village> GetAll()
        {
            return VillageDA.GetAll();
        }
    }
}
