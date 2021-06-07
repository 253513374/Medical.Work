﻿using Medical.Work.Data;
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
using Microsoft.Extensions.Options;

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
        private IDbContextFactory<MedicalDbContext> ContextFactory { set; get; }

        public List<PatientInfo> Patients { set; get; } = new List<PatientInfo>(1000);

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
            using ( var context  = ContextFactory.CreateDbContext()) {
                Patients = await context.patientInfos.Where(w => w.DateTime >= startDate.AddDays(-10)).AsNoTracking().ToListAsync();

                var array = Patients.Select(s => s.Medicalrecordnumber).ToList();
                var arrayname = Patients.Select(s => s.Name).ToArray();
                Items.AddRange(array);
                Items.AddRange(arrayname);
            }
            return;
        }


        private async Task CreateAddDlg()
        {
            var result = await Dialog.ShowModal<PatientInfoDlg>(new ResultDialogOption()
            {
                Title = "新建医患信息",
                BodyContext = new PatientInfo(),

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

            return;

        }


        private async Task OnSearch2(string searchText)
        {
            //Trace2.Log($"SearchText: {searchText}");

            Patients = await InfoService.QueryPatientInfos(searchText);
            await OnQueryPageAsync(new QueryPageOptions() { PageIndex=2, SearchText= searchText });
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

        private  Task<QueryData<PatientInfo>> OnQueryPageAsync(QueryPageOptions options)
        {
            var items = Patients.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems);
            return Task.FromResult(new QueryData<PatientInfo>()
            {
             Items = items,
             TotalCount = Patients.Count()
            });
          
        }
    }
}
