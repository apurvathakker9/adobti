using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class UserBL
    {
        public static bool Add(BusinessObjects.User userBO)
        {
            return UserDA.Add(userBO);
        }

        public static bool Update(BusinessObjects.User userBO)
        {
            return UserDA.Update(userBO);
        }

        public static bool Delete(BusinessObjects.User userBO)
        {
            return UserDA.Delete(userBO);
        }

        public static BusinessObjects.User GetDetails(int Id)
        {
            return UserDA.GetDetails(Id);
        }

        public static List<BusinessObjects.User> GetAllByDistrict(int DistrictId)
        {
            return UserDA.GetAllByDistrict(DistrictId);
        }
    }
}
