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

     
        private MedicalDbContext DbContext { set; get; }
        public PatientInfoService(MedicalDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public bool UpdatePatientInfo(PatientInfo info)
        {
            DbContext.patientInfos.Update(info);

            DbContext.SaveChanges();
            return true;
        }

        public bool DeletePatientInfo(PatientInfo info)
        {
            DbContext.patientInfos.Remove(info);
            DbContext.SaveChanges();
            return true;
        }


        public bool AddPatientInfo(List<PatientInfo> info)
        {

            DbContext.patientInfos.AddRange (info);
            DbContext.SaveChanges();
            return true;
        }

        public bool AddPatientInfo(PatientInfo info)
        {

            DbContext.patientInfos.Add(info);
            DbContext.SaveChanges();
            return true;
        }

        public async Task<List<PatientInfo>> QueryPatientInfos(string key )
        {

            return await DbContext.patientInfos.Where(w => w.Medicalrecordnumber.Contains(key) || w.Name.Contains(key)).ToListAsync();
           //  null;
        }
    }
}
