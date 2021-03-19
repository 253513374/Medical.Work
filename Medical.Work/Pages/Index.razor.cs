using Medical.Work.Data;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using BootstrapBlazor.Components;
using Medical.Work.Pages.template;
using System.Runtime.InteropServices.ComTypes;

namespace Medical.Work.Pages
{
    public partial class Index
    {
        [Inject]
        private MessageTag MessageTagservice { set; get; }
        private Message MessageElement { set; get; }

        [Inject]
        private PatientInfoService InfoService { set; get; }  

        [Inject]
        private MedicalDbContext dbContext { set; get; }

        public List<PatientInfo> Patients { set; get; }

        [Inject]
        public DialogService? Dialog { set; get; }

        private PatientInfo patientInfo { set; get; }

        public List<string> Items { set; get; } = new List<string>(1000);

        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public async Task GetForecastAsync(DateTime startDate)
        {

            //setdata(DateTime.Now);
            Patients = await dbContext.patientInfos.Where(w=>w.DateTime>= startDate.AddDays(-10)).AsNoTracking().ToListAsync();


           
            var array=Patients.Select(s => s.Medicalrecordnumber).ToList();
            var arrayname=Patients.Select(s => s.Name).ToArray();
            Items.AddRange(array);
            Items.AddRange(arrayname);


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

            InfoService.AddPatientInfo(list.Result);

            return list.Result;
        }

        private async Task CreateAddDlg()
        {
            var result = await Dialog.ShowModal<PatientInfoDlg>(new ResultDialogOption()
            {
                Title = "新建医患信息",
                BodyContext = new PatientInfo(),
                KeepChildrenState = false,
                ComponentParamters = new KeyValuePair<string, object>[]
                  {
                //new(nameof(EditReportCard.TemplateParameter), Certificatetemplate),
                new(nameof(PatientInfoDlg.OnEventCallback), EventCallback.Factory.Create<PatientInfo>(this, v => patientInfo = v))
                  }
            });

            if (result == DialogResult.Yes)
            {
                InfoService.UpdatePatientInfo(patientInfo);
                //UpdateDate();

                MessageTagservice.ShowColorMessage(Color.Danger, "医患信息添加成功", MessageElement);
            }

            return;//Task.CompletedTask;
           // return Task.CompletedTask;
        }


        private async Task OnSearch2(string searchText)
        {
            //Trace2.Log($"SearchText: {searchText}");

            Patients = await InfoService.QueryPatientInfos(searchText);
            StateHasChanged();
            return;
        }
        private async Task OnClear(string searchText)
        {
            // Trace2.Log($"OnClear: {searchText}");
            await GetForecastAsync(DateTime.Now);
            StateHasChanged();
            return ;
        }
    }
}
