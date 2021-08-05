using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Medical.Work.Data
{
    public class PatientInfoService
    {


        IDbContextFactory<MedicalDbContext> ContextFactory { set; get; }
        public PatientInfoService(IDbContextFactory<MedicalDbContext> contextFactory)
        {
            ContextFactory = contextFactory;
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

            using (var context = ContextFactory.CreateDbContext())
            {
                context.patientInfos.Add(info);
                context.SaveChanges();
            }
               
            return true;
        }

        public async Task<PatientInfo> GetPatientInfo(string guid)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                //context.SaveChanges();
                return await context.patientInfos.Where(w => w.PatientInfoGuid == guid).AsNoTracking().FirstOrDefaultAsync();  
            }
          
        }


        /// <summary>
        /// 根据关键字返回一个集合
        /// </summary>
        /// <param name="key"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<List<PatientInfo>> QueryPatientInfos(string key,string username)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                return await context.patientInfos.Where(w=>w.AdminName== username).Where(w => w.Medicalrecordnumber.Contains(key) || w.UserName.Contains(key)).ToListAsync();
            }
            //  null;
        }
    }
}
