using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class WorkNameBL
    {
        public static bool Add(BusinessObjects.WorkName workNameBO)
        {
            return WorkNameDA.Add(workNameBO);
        }

        public static bool Update(BusinessObjects.WorkName workNameBO)
        {
            return WorkNameDA.Update(workNameBO);
        }

        public static bool Delete(BusinessObjects.WorkName workNameBO)
        {
            return WorkNameDA.Delete(workNameBO);
        }

        public static BusinessObjects.WorkName GetDetails(int Id)
        {
            return WorkNameDA.GetDetails(Id);
        }

        public static List<BusinessObjects.WorkName> GetAll()
        {
            return WorkNameDA.GetAll();
        }
    }
}
