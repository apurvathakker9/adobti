using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JobDA
    {
        public static bool Add(BusinessObjects.Job jobBO)
        {
            int i = 0;
            var job = new Job
            {
                DateAdded = DateTime.Now,
                Id = Guid.NewGuid(),
                EstimatedBudget = jobBO.EstimatedBudget,
                IsPathStored = false,
                IsVerified = false,
                SchemaId = jobBO.SchemaId,
                VillageId = jobBO.VillageId,
                WorkNameId = jobBO.WorkNameId
            };

            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                context.Jobs.Add(job);
                i = context.SaveChanges();
                context.Dispose();
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool Update(BusinessObjects.Job jobBO)
        {
            int i = 0;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.Jobs.SingleOrDefault(j => j.Id == jobBO.Id);
                InDb.IsPathStored = jobBO.IsPathStored;
                InDb.IsVerified = jobBO.IsVerified;
                InDb.SchemaId = jobBO.SchemaId;
                InDb.StartLatitude = jobBO.StartLatitude;
                InDb.StartLongitude = jobBO.StartLongitude;
                InDb.EstimatedBudget = jobBO.EstimatedBudget;
                InDb.EndLatitude = jobBO.EndLatitude;
                InDb.EndLongitude = jobBO.EndLongitude;
                InDb.PreviousGrant = jobBO.PreviousGrant;
                InDb.VillageId = jobBO.VillageId;
                InDb.WorkNameId = jobBO.WorkNameId;
                i = context.SaveChanges();
                context.Dispose();
            }

            if (i > 0)
                return true;
            else
                return false;
        }

        public static bool Delete(BusinessObjects.Job jobBO)
        {
            int i = 0;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.Jobs.SingleOrDefault(j => j.Id == jobBO.Id);
                context.Jobs.Remove(InDb);
                i = context.SaveChanges();
            }

            if (i > 0)
                return true;
            else
                return false;
        }

        public static BusinessObjects.Job GetDetails(Guid Id)
        {
            BusinessObjects.Job job = null;
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var InDb = context.Jobs.SingleOrDefault(j => j.Id == Id);
                job = new BusinessObjects.Job
                {
                    Id = InDb.Id,
                    DateAdded = InDb.DateAdded,
                    EndLatitude = InDb.EndLatitude,
                    EndLongitude = InDb.EndLongitude,
                    EstimatedBudget = InDb.EstimatedBudget,
                    IsPathStored = InDb.IsPathStored,
                    IsVerified = InDb.IsVerified,
                    PreviousGrant = InDb.PreviousGrant,
                    SchemaId = InDb.SchemaId,
                    StartLatitude = InDb.StartLatitude,
                    StartLongitude = InDb.StartLongitude,
                    VillageId = InDb.VillageId,
                    WorkNameId = InDb.WorkNameId
                };
            }
            return job;
        }

        public static List<BusinessObjects.Job> GetAll()
        {
            List<BusinessObjects.Job> list = new List<BusinessObjects.Job>();
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var JobsInDb = context.Jobs.ToList();
                foreach (var InDb in JobsInDb)
                {
                    BusinessObjects.Job job = new BusinessObjects.Job
                    {
                        Id = InDb.Id,
                        DateAdded = InDb.DateAdded,
                        EndLatitude = InDb.EndLatitude,
                        EndLongitude = InDb.EndLongitude,
                        EstimatedBudget = InDb.EstimatedBudget,
                        IsPathStored = InDb.IsPathStored,
                        IsVerified = InDb.IsVerified,
                        PreviousGrant = InDb.PreviousGrant,
                        SchemaId = InDb.SchemaId,
                        StartLatitude = InDb.StartLatitude,
                        StartLongitude = InDb.StartLongitude,
                        VillageId = InDb.VillageId,
                        WorkNameId = InDb.WorkNameId
                    };

                    list.Add(job);
                }
            }
            return list;
        }

        public static List<BusinessObjects.Job> GetAllVerifiedJobs()
        {
            List<BusinessObjects.Job> list = new List<BusinessObjects.Job>();
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var JobsInDb = context.Jobs.Where(j=>j.IsVerified == true).ToList();
                foreach (var InDb in JobsInDb)
                {
                    BusinessObjects.Job job = new BusinessObjects.Job
                    {
                        Id = InDb.Id,
                        DateAdded = InDb.DateAdded,
                        EndLatitude = InDb.EndLatitude,
                        EndLongitude = InDb.EndLongitude,
                        EstimatedBudget = InDb.EstimatedBudget,
                        IsPathStored = InDb.IsPathStored,
                        IsVerified = InDb.IsVerified,
                        PreviousGrant = InDb.PreviousGrant,
                        SchemaId = InDb.SchemaId,
                        StartLatitude = InDb.StartLatitude,
                        StartLongitude = InDb.StartLongitude,
                        VillageId = InDb.VillageId,
                        WorkNameId = InDb.WorkNameId
                    };

                    list.Add(job);
                }
            }
            return list;
        }

        public static List<BusinessObjects.Job> GetAllAssignedJobs()
        {
            List<BusinessObjects.Job> list = new List<BusinessObjects.Job>();
            using (ADOBathindaEntities context = new ADOBathindaEntities())
            {
                var JobsInDb = context.Jobs.Where(j => j.IsVerified == false).ToList();
                foreach (var InDb in JobsInDb)
                {
                    BusinessObjects.Job job = new BusinessObjects.Job
                    {
                        Id = InDb.Id,
                        DateAdded = InDb.DateAdded,
                        EndLatitude = InDb.EndLatitude,
                        EndLongitude = InDb.EndLongitude,
                        EstimatedBudget = InDb.EstimatedBudget,
                        IsPathStored = InDb.IsPathStored,
                        IsVerified = InDb.IsVerified,
                        PreviousGrant = InDb.PreviousGrant,
                        SchemaId = InDb.SchemaId,
                        StartLatitude = InDb.StartLatitude,
                        StartLongitude = InDb.StartLongitude,
                        VillageId = InDb.VillageId,
                        WorkNameId = InDb.WorkNameId
                    };

                    list.Add(job);
                }
            }
            return list;
        }
    }
}
