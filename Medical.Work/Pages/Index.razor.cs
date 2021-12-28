using BootstrapBlazor.Components;
using Medical.Work.Data;
using Medical.Work.Data.Models;
using Medical.Work.Pages.template;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Pages
{
    public partial class Index
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        private MessageService messageService { set; get; }

        private Message MessageElement { set; get; }

        [Inject]
        private PatientInfoService InfoService { set; get; }

        [Inject]
        private IDbContextFactory<MedicalDbContext> ContextFactory { set; get; }

        [Inject]
        public DialogService? Dialog { set; get; }

        [Inject]
        [NotNull]
        private SwalService? SwalService { get; set; }

        public List<PatientInfo> Patients { set; get; } = new List<PatientInfo>(1000);
        private PatientInfo patientInfo { set; get; }

        public List<string> Items { set; get; } = new List<string>(1000);

        private ListView<PatientInfo> mylistview { set; get; } = new ListView<PatientInfo>();
        public DateTimeRangeValue RangeValue { set; get; } = new() { Start = DateTime.Now.AddDays(-90), End = DateTime.Now };

        protected override async Task OnInitializedAsync()
        {
            await GetForecastAsync();
            return;// base.OnInitializedAsync();
        }

        //protected override void OnInitialized()
        //{
        //    base.OnInitialized();
        //}

        /// <summary>
        /// 加载患者个人信息列表
        /// </summary>
        /// <returns></returns>
        public async Task GetForecastAsync()
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                var Username = authenticationStateTask.Result.User.Identity.Name;
                Patients = await context.patientInfos.Where(w => w.Adminname == Username).Where(w => w.Createtime >= RangeValue.Start && w.Createtime <= RangeValue.End).AsNoTracking().ToListAsync();

                var array = Patients.Select(s => s.Medicalrecordnumber).ToList();
                var arrayname = Patients.Select(s => s.Username).ToArray();

                DataTips.PatientsTips = Patients.Select(s => new PatientsTips { Number = s.Medicalrecordnumber, Description = s.Username }).ToList();

                Items.AddRange(array);
                Items.AddRange(arrayname);
            }
            StateHasChanged();
            return;
        }

        /// <summary>
        /// 添加患者个人基本信息数据
        /// </summary>
        /// <returns></returns>
        private async Task CreateAddDlg()
        {
            var result = await Dialog.ShowModal<PatientInfoDlg>(new ResultDialogOption()
            {
                Title = "新建医患信息",
                BodyContext = new PatientInfo(),
                ComponentParamters = new Dictionary<string, object>
                {
                    //[nameof(PatientInfoDlg.patientInfo)]= patientInfo,
                    [nameof(PatientInfoDlg.OnEventCallback)] = EventCallback.Factory.Create<PatientInfo>(this, v => patientInfo = v)
                }
            });

            if (result == DialogResult.Yes)
            {
                patientInfo.Createtime = DateTime.Now;
                patientInfo.Adminname = authenticationStateTask.Result.User.Identity.Name;
                patientInfo.Guid = Guid.NewGuid().ToString();
                InfoService.AddPatientInfo(patientInfo);
                Patients.Add(patientInfo);
                //UpdateDate();

                ShowColorMessage(Color.Danger, "医患信息添加成功", MessageElement);
            }
            StateHasChanged();
            return;
        }

        /// <summary>
        /// 编辑患者个人基本信息数据
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        private async Task OnEditpatientdlg(PatientInfo patient)
        {
            var result = await Dialog.ShowModal<PatientInfoDlg>(new ResultDialogOption()
            {
                Title = "编辑修改医患信息",
                BodyContext = patient,

                ComponentParamters = new Dictionary<string, object>
                {
                    [nameof(PatientInfoDlg.OnEventCallback)] = EventCallback.Factory.Create<PatientInfo>(this, v => patientInfo = v)
                }
                //ComponentParamters = new KeyValuePair<string, object>[]
                // {
                //      new(nameof(PatientInfoDlg.OnEventCallback), EventCallback.Factory.Create<PatientInfo>(this, v => patientInfo = v))
                // }
            });

            if (result == DialogResult.Yes)
            {
                patientInfo.Createtime = DateTime.Now;
                patientInfo.Adminname = authenticationStateTask.Result.User.Identity.Name;
                InfoService.UpdatePatientInfo(patientInfo);
                ShowColorMessage(Color.Danger, "医患信息修改成功", MessageElement);
            }
            StateHasChanged();
            return;
        }

        /// <summary>
        /// 搜索患者个人信息
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        private async Task OnSearch2(string searchText)
        {
            //Trace2.Log($"SearchText: {searchText}");
            var Username = authenticationStateTask.Result.User.Identity.Name;
            Patients = await InfoService.QueryPatientInfos(searchText, Username);
            //OnQueryPageAsync(new QueryPageOptions() );
            await mylistview.QueryAsync();
            StateHasChanged();
            return;
        }

        private async Task OnClear(string searchText)
        {
            // Trace2.Log($"OnClear: {searchText}");
            //await GetForecastAsync(DateTime.Now);
            StateHasChanged();
            return;
        }

        /// <summary>
        /// 内存分页显示患者信息，自动刷新
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private Task<QueryData<PatientInfo>> OnQueryPageAsync(QueryPageOptions options)
        {
            if (Patients is null)
            {
                return null;
            }
            var items = Patients.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems);
            return Task.FromResult(new QueryData<PatientInfo>()
            {
                Items = items,
                TotalCount = Patients.Count()
            });
        }

        /// <summary>
        /// 删除患者个人信息
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        private async Task Ondel(PatientInfo patient)
        {
            var op = new SwalOption()
            {
                Title = "警告",
                Content = "数据删除不可再恢复，是否确定删除？",
                IsConfirm = true,
                Category = SwalCategory.Warning
            };
            var re = await SwalService.ShowModal(op);
            if (re)
            {
                var ret = InfoService.DeletePatientInfo(patient);
                if (ret)
                {
                    Patients.Remove(patient);
                    StateHasChanged();
                }
            }
            return;
        }

        public void ShowColorMessage(Color color, string content, Message message)
        {
            message.SetPlacement(Placement.Top);
            messageService?.Show(new MessageOption()
            {
                Content = content,
                Icon = "fa fa-info-circle",
                Color = color,
                ShowBar = true,
                ShowDismiss = true,
            }, message);
        }
    }
}