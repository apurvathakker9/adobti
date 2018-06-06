using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class JobBL
    {
        public static bool Add(BusinessObjects.Job jobBO)
        {
            return JobDA.Add(jobBO);
        }

        public static bool Update(BusinessObjects.Job jobBO)
        {
            return JobDA.Update(jobBO);
        }

        public static bool Delete(BusinessObjects.Job jobBO)
        {
            return JobDA.Delete(jobBO);
        }

        public static BusinessObjects.Job GetDetails(Guid Id)
        {
            return JobDA.GetDetails(Id);
        }

        public static List<BusinessObjects.Job> GetAll()
        {
            return JobDA.GetAll();
        }

        public static List<BusinessObjects.Job> GetAllVerifiedJobs()
        {
            return JobDA.GetAllVerifiedJobs();
        }

        public static List<BusinessObjects.Job> GetAllAssignedJobs()
        {
            return JobDA.GetAllAssignedJobs();
        }
    }
}
