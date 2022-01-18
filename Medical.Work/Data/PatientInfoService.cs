using Medical.Work.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data
{
    public class PatientInfoService
    {
        private IDbContextFactory<MedicalDbContext> ContextFactory { set; get; }

        private readonly ILogger _logger;

        public PatientInfoService(IDbContextFactory<MedicalDbContext> contextFactory, ILogger<PatientInfoService> logger)
        {
            ContextFactory = contextFactory;
            _logger = logger;   
        }

        public bool UpdatePatientInfo(PatientInfo info)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                context.patientInfos.Update(info);
                context.SaveChanges();
            }

            return true;
        }

        public bool DeletePatientInfo(PatientInfo info)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                context.patientInfos.Remove(info);
                context.SaveChanges();
            }

            return true;
        }

        public bool AddPatientInfo(List<PatientInfo> info)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                context.patientInfos.AddRange(info);
                context.SaveChanges();
            }

            return true;
        }

        public bool AddPatientInfo(PatientInfo info)
        {
            try
            {
                using (var context = ContextFactory.CreateDbContext())
                {
                    context.patientInfos.Add(info);
                    context.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                _logger.LogInformation(e.StackTrace);
                throw;
            }
           

            return true;
        }

        public async Task<PatientInfo> GetPatientInfo(string guid)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                //context.SaveChanges();
                return await context.patientInfos.Where(w => w.Guid == guid).AsNoTracking().FirstOrDefaultAsync();
            }
        }

        /// <summary>
        /// 根据关键字返回一个集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="Username"></param>
        /// <returns></returns>
        public async Task<List<PatientInfo>> QueryPatientInfos(string key, string Username)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                return await context.patientInfos.Where(w => w.Adminname == Username).Where(w => w.Medicalrecordnumber.Contains(key) || w.Username.Contains(key)).ToListAsync();
            }
            //  null;
        }
    }
}