using Medical.Work.Data;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Medical.Work.Pages
{
    public partial class Index
    {


        [Inject]
        private PatientInfoService servcie { set; get; }  

        [Inject]
        private MedicalDbContext dbContext { set; get; }

        public List<PatientInfo> Patients { set; get; }

        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public async Task GetForecastAsync(DateTime startDate)
        {

            //setdata(DateTime.Now);
            Patients = await dbContext.patientInfos.Where(w=>w.DateTime>= startDate.AddDays(-10)).AsNoTracking().ToListAsync();

            //var rng = new Random();
            //return Task.FromResult(Enumerable.Range(1, 15).Select(index => new PatientInfo
            //{
            //    Ancestralhome = "海南",
            //    AGE = rng.Next(10, 100).ToString(),
            //    BW = rng.Next(40, 100).ToString(),
            //    Medicalrecordnumber = rng.Next(100000, 800000).ToString(),
            //    DateTime = startDate.AddDays(index),
            //    Name = Summaries[rng.Next(Summaries.Length)]
            //}).ToList());

            return;
        }

        public List<PatientInfo> setdata(DateTime startDate)
        {
            var rng = new Random();
            var list =  Task.FromResult(Enumerable.Range(1, 150).Select(index => new PatientInfo
            {
                Ancestralhome = "海南",
                AGE = rng.Next(10, 100).ToString(),
                BW = rng.Next(40, 100).ToString(),
                Medicalrecordnumber = rng.Next(100000, 800000).ToString(),
                DateTime = startDate.AddDays(index),
                Name = Summaries[rng.Next(Summaries.Length)]
            }).ToList());

            servcie.AddPatientInfo(list.Result);

            return list.Result;
        }
    }
}
