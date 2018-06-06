using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SchemaDA
    {
        private ADOBathindaEntities context;

        public SchemaDA()
        {
            context = new ADOBathindaEntities();
        }

        public static bool Add(BusinessObjects.Schema schemaBO)
        {
            SchemaDA S = new SchemaDA();
            var schema = new Schema
            {
                Id = Guid.NewGuid(),
                Name = schemaBO.Name,
                GrantMoney = schemaBO.GrantMoney,
                DateAdded = DateTime.Now
            };
            S.context.Schemas.Add(schema);
            int affectedRows = S.context.SaveChanges();
            S.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Update(BusinessObjects.Schema schemaBO)
        {
            SchemaDA S = new SchemaDA();
            var InDb = S.context.Schemas.SingleOrDefault(s => s.Id == schemaBO.Id);

            InDb.Name = schemaBO.Name;
            InDb.GrantMoney = schemaBO.GrantMoney;
            int affectedRows = S.context.SaveChanges();
            S.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static bool Delete(BusinessObjects.Schema schemaBO)
        {
            SchemaDA S = new SchemaDA();
            var InDB = S.context.Schemas.SingleOrDefault(s => s.Id == schemaBO.Id);
            S.context.Schemas.Remove(InDB);
            int affectedRows = S.context.SaveChanges();
            S.context.Dispose();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public static BusinessObjects.Schema GetDetails(Guid Id)
        {
            SchemaDA S = new SchemaDA();
            var InDb = S.context.Schemas.SingleOrDefault(s => s.Id == Id);
            BusinessObjects.Schema schema = new BusinessObjects.Schema
            {
                Id = InDb.Id,
                Name = InDb.Name,
                GrantMoney = InDb.GrantMoney,
                DateAdded = InDb.DateAdded
            };
            S.context.Dispose();
            return schema;
        }

        public static List<BusinessObjects.Schema> GetAll()
        {
            List<BusinessObjects.Schema> list = new List<BusinessObjects.Schema>();
            SchemaDA S = new SchemaDA();
            var listSchamaInDb = S.context.Schemas.ToList();
            foreach(var InDb in listSchamaInDb)
            {
                BusinessObjects.Schema schema = new BusinessObjects.Schema
                {
                    Id = InDb.Id,
                    Name = InDb.Name,
                    GrantMoney = InDb.GrantMoney,
                    DateAdded = InDb.DateAdded
                };

                list.Add(schema);
            }
            return list;
        }
    }
}
