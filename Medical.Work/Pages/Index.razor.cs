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
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Components.Authorization;

namespace Medical.Work.Pages
{
    public partial class Index
    {

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }
        [Inject]
        private MessageService   messageService { set; get; }
        private Message MessageElement { set; get; }

        [Inject]
        private PatientInfoService InfoService { set; get; }

        [Inject]
        private IDbContextFactory<MedicalDbContext> ContextFactory { set; get; }



        [Inject]
        public DialogService? Dialog { set; get; }

        public List<PatientInfo> Patients { set; get; } = new List<PatientInfo>(1000);
        private PatientInfo patientInfo { set; get; }

        public List<string> Items { set; get; } = new List<string>(1000);


        public DateTimeRangeValue RangeValue { set; get; } = new() { Start = DateTime.Now.AddDays(-10), End = DateTime.Now };


        protected override void OnAfterRender(bool firstRender)
        {
            if(firstRender)
            {
                using (var context = ContextFactory.CreateDbContext())
                {
                    var username = authenticationStateTask.Result.User.Identity.Name;
                    Patients = context.patientInfos.Where(w => w.Adminuser == username).Where(w => w.CreateTime >= RangeValue.Start&&w.CreateTime<=RangeValue.End).AsNoTracking().ToList();
                }
            }
            base.OnAfterRender(firstRender);
        }

        public async Task GetForecastAsync()
        {
            using ( var context  = ContextFactory.CreateDbContext())
            {
                var username = authenticationStateTask.Result.User.Identity.Name;
                Patients = await context.patientInfos.Where(w=>w.Adminuser== username).Where(w => w.CreateTime >= RangeValue.Start && w.CreateTime <= RangeValue.End).AsNoTracking().ToListAsync();

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
                      new(nameof(PatientInfoDlg.OnEventCallback), EventCallback.Factory.Create<PatientInfo>(this, v => patientInfo = v))
                  }
            });

            if (result == DialogResult.Yes)
            {
                patientInfo.CreateTime = DateTime.Now;
                patientInfo.Adminuser = authenticationStateTask.Result.User.Identity.Name;
                InfoService.AddPatientInfo(patientInfo);
                Patients.Add(patientInfo);
                //UpdateDate();

                ShowColorMessage(Color.Danger, "医患信息添加成功", MessageElement);
            }
            StateHasChanged();
            return;

        }


        private async Task OnEditpatientdlg(PatientInfo patient)
        {
            var result = await Dialog.ShowModal<PatientInfoDlg>(new ResultDialogOption()
            {
                Title = "编辑修改医患信息",
                BodyContext = patient,

                ComponentParamters = new KeyValuePair<string, object>[]
                 {
                      new(nameof(PatientInfoDlg.OnEventCallback), EventCallback.Factory.Create<PatientInfo>(this, v => patientInfo = v))
                 }
            });

            if (result == DialogResult.Yes)
            {
                patientInfo.CreateTime = DateTime.Now;
                patientInfo.Adminuser = authenticationStateTask.Result.User.Identity.Name;
                InfoService.UpdatePatientInfo(patientInfo);
                ShowColorMessage(Color.Danger, "医患信息修改成功", MessageElement);
            }
            StateHasChanged();
            return;
        }


        private async Task OnSearch2(string searchText)
        {
            //Trace2.Log($"SearchText: {searchText}");
            var username = authenticationStateTask.Result.User.Identity.Name;
            Patients = await InfoService.QueryPatientInfos(searchText, username);
            await OnQueryPageAsync(new QueryPageOptions() { PageIndex=2, SearchText= searchText });
            StateHasChanged();
            return;
        }
        private async Task OnClear(string searchText)
        {
            // Trace2.Log($"OnClear: {searchText}");
            //await GetForecastAsync(DateTime.Now);
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

        private Task Ondel(PatientInfo patient)
        {
            var ret=InfoService.DeletePatientInfo(patient);
            if(ret)
            {
                Patients.Remove(patient);
                StateHasChanged();
            }
            return Task.CompletedTask;
        }

        public void ShowColorMessage(Color color, string content, Message message)
        {
            message.SetPlacement(Placement.Top);
            messageService?.Show(new MessageOption()
            {
                Host = message,
                Content = content,
                Icon = "fa fa-info-circle",
                Color = color
            });
        }
    }
}
