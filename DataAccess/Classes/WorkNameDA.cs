using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WorkNameDA
    {
        public static bool Add(BusinessObjects.WorkName workNameBO)
        {
            int i = 0;
            var workName = new WorkName
            {
                Name = workNameBO.Name
            };
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                context.WorkNames.Add(workName);
                i = context.SaveChanges();
                context.Dispose();
            }

            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool Update(BusinessObjects.WorkName workNameBO)
        {
            int i = 0;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.WorkNames.SingleOrDefault(w => w.Id == workNameBO.Id);
                InDb.Name = workNameBO.Name;
                i = context.SaveChanges();
                context.Dispose();
            }
            if (i < 0)
                return true;
            else
                return false;
        }

        public static bool Delete(BusinessObjects.WorkName workNameBO)
        {
            int i = 0;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.WorkNames.SingleOrDefault(w => w.Id == workNameBO.Id);
                context.WorkNames.Remove(InDb);
                i = context.SaveChanges();
                context.Dispose();
            }
            if (i < 0)
                return true;
            else
                return false;
        }

        public static BusinessObjects.WorkName GetDetails(int Id)
        {
            BusinessObjects.WorkName workName = null;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.WorkNames.SingleOrDefault(w => w.Id == Id);
                workName = new BusinessObjects.WorkName
                {
                    Id = InDb.Id,
                    Name = InDb.Name
                };
                context.Dispose();
            }
            return workName;
        }

        public static List<BusinessObjects.WorkName> GetAll()
        {
            List<BusinessObjects.WorkName> list = new List<BusinessObjects.WorkName>();
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var WorkNames = context.WorkNames.ToList();
                foreach(var InDb in WorkNames)
                {
                    BusinessObjects.WorkName workName = new BusinessObjects.WorkName
                    {
                        Id = InDb.Id,
                        Name = InDb.Name
                    };
                    list.Add(workName);
                }
            }
            return list;
        }
    }
}
