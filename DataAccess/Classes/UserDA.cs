using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess
{
    public class UserDA
    {
        public static bool Add(BusinessObjects.User userBO)
        {
            int i = 0;
            var user = new User
            {
                Name = userBO.Name,
                PhoneNumber = userBO.PhoneNumber,
                EmailId = userBO.EmailId,
                DistrictId = userBO.DistrictId
            };
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                context.Users.Add(user);
                i = context.SaveChanges();
                context.Dispose();
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool Update(BusinessObjects.User userBO)
        {
            int i = 0;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.Users.SingleOrDefault(u => u.Id == userBO.Id);
                InDb.Name = userBO.Name;
                InDb.PhoneNumber = userBO.PhoneNumber;
                InDb.EmailId = userBO.EmailId;
                InDb.DistrictId = userBO.DistrictId;
                i = context.SaveChanges();
                context.Dispose();
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool Delete(BusinessObjects.User userBO)
        {
            int i = 0;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.Users.SingleOrDefault(u => u.Id == userBO.Id);
                context.Users.Remove(InDb);
                i = context.SaveChanges();
                context.Dispose();
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        public static BusinessObjects.User GetDetails(int Id)
        {
            BusinessObjects.User userBO = null;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.Users.Include(u => u.District).SingleOrDefault(u => u.Id == Id);
                userBO = new BusinessObjects.User
                {
                    Name = InDb.Name,
                    PhoneNumber = InDb.PhoneNumber,
                    EmailId = InDb.EmailId,
                    Id = InDb.Id,
                    DistrictId = InDb.DistrictId
                };
                //Adding Foreign Keys
                //District
                userBO.District = new BusinessObjects.District
                {
                    Id = InDb.District.Id,
                    Name = InDb.District.Name
                };

                context.Dispose();
            }
            return userBO;
        }

        public static List<BusinessObjects.User> GetAllByDistrict(int DistrictId)
        {
            List<BusinessObjects.User> list = new List<BusinessObjects.User>();
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var Users = context.Users.Include(u=>u.District).Where(u=>u.DistrictId == DistrictId).ToList();
                foreach(var user in Users)
                {
                    BusinessObjects.User UserBO = new BusinessObjects.User
                    {
                        Name = user.Name,
                        PhoneNumber = user.PhoneNumber,
                        EmailId = user.EmailId,
                        Id = user.Id,
                        DistrictId = user.DistrictId
                    };
                    //Adding Foreign Keys
                    //District
                    UserBO.District = new BusinessObjects.District
                    {
                        Id = user.District.Id,
                        Name = user.District.Name
                    };

                    list.Add(UserBO);
                    context.Dispose();
                }
            }
            return list;
        }
    }
}
