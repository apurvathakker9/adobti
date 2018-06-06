using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GrantDA
    {
        private ADOBathindaEntities context;

        public GrantDA()
        {
            context = new ADOBathindaEntities();
        }
        public static bool Add(BusinessObjects.Grant grantBO)
        {
            GrantDA G = new GrantDA();
            var grant = new Grant
            {
                Id = Guid.NewGuid(),
                CertificateDate = grantBO.CertificateDate,
                CertificateNumber = grantBO.CertificateNumber,
                Comments = grantBO.Comments,
                DistrictId = grantBO.DistrictId,
                MeetingDate = grantBO.MeetingDate,
                RecievedMoney = grantBO.RecievedMoney,
                RemainingMoney = grantBO.RemainingMoney,
                SchemaId = grantBO.SchemaId,
                SpentMoney = grantBO.SpentMoney,
                VillageId = grantBO.VillageId,
                WorkNameId = grantBO.WorkNameId
            };
            G.context.Grants.Add(grant);
            int affectedRows = G.context.SaveChanges();
            G.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Update(BusinessObjects.Grant grantBO)
        {
            GrantDA G = new GrantDA();
            var grant = G.context.Grants.SingleOrDefault(g => g.Id == grantBO.Id);

            grant.CertificateDate = grantBO.CertificateDate;
            grant.CertificateNumber = grantBO.CertificateNumber;
            grant.Comments = grantBO.Comments;
            grant.DistrictId = grantBO.DistrictId;
            grant.MeetingDate = grantBO.MeetingDate;
            grant.RecievedMoney = grantBO.RecievedMoney;
            grant.RemainingMoney = grantBO.RemainingMoney;
            grant.SchemaId = grantBO.SchemaId;
            grant.SpentMoney = grantBO.SpentMoney;
            grant.VillageId = grantBO.VillageId;
            grant.WorkNameId = grantBO.WorkNameId;


            int affectedRows = G.context.SaveChanges();
            G.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Delete(BusinessObjects.Grant grantBO)
        {
            GrantDA G = new GrantDA();
            var grant = G.context.Grants.SingleOrDefault(g => g.Id == grantBO.Id);

            G.context.Grants.Remove(grant);
            int affectedRows = G.context.SaveChanges();
            G.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static BusinessObjects.Grant GetDetails(Guid Id)
        {
            GrantDA G = new GrantDA();
            var InDb = G.context.Grants.SingleOrDefault(g => g.Id == Id);
            BusinessObjects.Grant grantBO = new BusinessObjects.Grant
            {
                CertificateDate = InDb.CertificateDate,
                CertificateNumber = InDb.CertificateNumber,
                Comments = InDb.Comments,
                DistrictId = InDb.DistrictId,
                MeetingDate = InDb.MeetingDate,
                RecievedMoney = InDb.RecievedMoney,
                RemainingMoney = InDb.RemainingMoney,
                SchemaId = InDb.SchemaId,
                SpentMoney = InDb.SpentMoney,
                VillageId = InDb.VillageId,
                WorkNameId = InDb.WorkNameId
            };
            G.context.Dispose();
            return grantBO;
        }

        public static List<BusinessObjects.Grant> GetAll()
        {
            List<BusinessObjects.Grant> list = new List<BusinessObjects.Grant>();
            GrantDA G = new GrantDA();
            var listGrantsInDb = G.context.Grants.ToList();
            foreach(var InDb in listGrantsInDb)
            {
                BusinessObjects.Grant grantBO = new BusinessObjects.Grant
                {
                    CertificateDate = InDb.CertificateDate,
                    CertificateNumber = InDb.CertificateNumber,
                    Comments = InDb.Comments,
                    DistrictId = InDb.DistrictId,
                    MeetingDate = InDb.MeetingDate,
                    RecievedMoney = InDb.RecievedMoney,
                    RemainingMoney = InDb.RemainingMoney,
                    SchemaId = InDb.SchemaId,
                    SpentMoney = InDb.SpentMoney,
                    VillageId = InDb.VillageId,
                    WorkNameId = InDb.WorkNameId
                };
                list.Add(grantBO);
            }
            return list;
        }
    }
}
