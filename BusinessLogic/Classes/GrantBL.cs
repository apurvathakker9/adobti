using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class GrantBL
    {
        public static bool Add(BusinessObjects.Grant grantBO)
        {
            return GrantDA.Add(grantBO);
        }

        public static bool Update(BusinessObjects.Grant grantBO)
        {
            return GrantDA.Update(grantBO);
        }

        public static bool Delete(BusinessObjects.Grant grantBO)
        {
            return GrantDA.Delete(grantBO);
        }

        public static BusinessObjects.Grant GetDetails(Guid Id)
        {
            return GrantDA.GetDetails(Id);
        }

        public static List<BusinessObjects.Grant> GetAll()
        {
            return GrantDA.GetAll();
        }
    }
}
