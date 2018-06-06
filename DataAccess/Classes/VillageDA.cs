using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VillageDA
    {
        private ADOBathindaEntities context;

        public VillageDA()
        {
            context = new ADOBathindaEntities();
        }
        public static bool Add(BusinessObjects.Village villageBO)
        {
            VillageDA V = new VillageDA();
            var village = new Village
            {
                Name = villageBO.Name,
                DistrictId = villageBO.DistrictId,
                Block = villageBO.Block
            };
            V.context.Villages.Add(village);
            int affectedRows = V.context.SaveChanges();
            V.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Update(BusinessObjects.Village villageBO)
        {
            VillageDA V = new VillageDA();
            var InDb = V.context.Villages.SingleOrDefault(v => v.Id == villageBO.Id);
            InDb.Name = villageBO.Name;
            InDb.DistrictId = villageBO.DistrictId;
            InDb.Block = villageBO.Block;
            int affectedRows = V.context.SaveChanges();
            V.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Delete(BusinessObjects.Village villageBO)
        {
            VillageDA V = new VillageDA();
            var InDb = V.context.Villages.SingleOrDefault(v => v.Id == villageBO.Id);
            V.context.Villages.Remove(InDb);
            int affectedRows = V.context.SaveChanges();
            V.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static BusinessObjects.Village GetDetails(int Id)
        {
            VillageDA V = new VillageDA();
            var InDb = V.context.Villages.SingleOrDefault(v => v.Id == Id);
            BusinessObjects.Village village = new BusinessObjects.Village
            {
                Id = InDb.Id,
                Name = InDb.Name,
                Block = InDb.Block,
                DistrictId = InDb.DistrictId
            };
            V.context.Dispose();
            return village;
        }

        public static List<BusinessObjects.Village> GetAll()
        {
            VillageDA V = new VillageDA();
            List<BusinessObjects.Village> list = new List<BusinessObjects.Village>();
            var listVillagesInDb = V.context.Villages.ToList();
            foreach(var InDb in listVillagesInDb)
            {
                BusinessObjects.Village village = new BusinessObjects.Village
                {
                    Id = InDb.Id,
                    Name = InDb.Name,
                    Block = InDb.Block,
                    DistrictId = InDb.DistrictId
                };
                list.Add(village);
            }
            return list;
        }
    }
}
