using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DistrictDA
    {
        private ADOBathindaEntities context;

        public DistrictDA()
        {
            context = new ADOBathindaEntities();
        }

        public static bool Add(BusinessObjects.District districtBO)
        {
            DistrictDA D = new DistrictDA();
            var district = new District
            {
                Name = districtBO.Name
            };
            D.context.Districts.Add(district);
            int affectedRows = D.context.SaveChanges();
            D.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Update(BusinessObjects.District districtBO)
        {
            DistrictDA D = new DistrictDA();
            var InDb = D.context.Districts.SingleOrDefault(d => d.Id == districtBO.Id);
            InDb.Name = districtBO.Name;

            int affectedRows = D.context.SaveChanges();
            D.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Delete(BusinessObjects.District districtBO)
        {
            DistrictDA D = new DistrictDA();
            var InDb = D.context.Districts.SingleOrDefault(d => d.Id == districtBO.Id);
            D.context.Districts.Remove(InDb);

            int affectedRows = D.context.SaveChanges();
            D.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static BusinessObjects.District GetDetails(int Id)
        {
            DistrictDA D = new DistrictDA();
            var InDb = D.context.Districts.SingleOrDefault(d => d.Id == Id);
            BusinessObjects.District district = new BusinessObjects.District
            {
                Id = InDb.Id,
                Name = InDb.Name
            };
            D.context.Dispose();

            return district;
        }

        public static List<BusinessObjects.District> GetAll()
        {
            DistrictDA D = new DistrictDA();
            List<BusinessObjects.District> list = new List<BusinessObjects.District>();

            var InDbList = D.context.Districts.ToList();

            foreach(var single in InDbList)
            {
                BusinessObjects.District district = new BusinessObjects.District
                {
                    Id = single.Id,
                    Name = single.Name
                };
                list.Add(district);
            }
            return list;
        }
    }
}
