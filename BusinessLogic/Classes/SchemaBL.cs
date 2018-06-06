using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class SchemaBL
    {
        public static bool Add(BusinessObjects.Schema schemaBO)
        {
            return SchemaDA.Add(schemaBO);
        }

        public static bool Update(BusinessObjects.Schema schemaBO)
        {
            return SchemaDA.Update(schemaBO);
        }

        public static bool Delete(BusinessObjects.Schema schemaBO)
        {
            return SchemaDA.Delete(schemaBO);
        }

        public static BusinessObjects.Schema GetDetails(Guid Id)
        {
            return SchemaDA.GetDetails(Id);
        }

        public static List<BusinessObjects.Schema> GetAll()
        {
            return SchemaDA.GetAll();
        }
    }
}
