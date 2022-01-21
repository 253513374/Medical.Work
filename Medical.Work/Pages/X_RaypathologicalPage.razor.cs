using BootstrapBlazor.Components;
using Medical.Work.Data;
using Medical.Work.Data.Models;
using Medical.Work.Pages.template;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MudBlazor;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Color = BootstrapBlazor.Components.Color;
using DialogResult = BootstrapBlazor.Components.DialogResult;

namespace Medical.Work.Pages
{
    public partial class X_RaypathologicalPage
    {
        private string Querywhere { set; get; }

        private bool IsBackdropOpen { set; get; }

        private X_raypathological raypathological { set; get; }

        private List<X_raypathological> x_Raypathologicals { set; get; } = new();

        [Inject]
        private MessageService messageService { set; get; }

        private Message MessageElement { set; get; }

        private MedicalDbContext context { set; get; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public string Name { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if (Text is not null or "")
            {
                // Task.Run(()=> { ); });
                var obj = new X_raypathological();
                obj.Medicalrecordnumber = Text;
                obj.Username = Name;
                await OnShowDlg(obj);
            }
            return;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                context = contextFactory.CreateDbContext();
                await OnSearch();
            }
            return;// base.OnAfterRenderAsync(firstRender);
        }

        private async Task OnShowDlg(X_raypathological obj)
        {
            var result = await dialogService.ShowModal<X_raypathologicalDlg>(new ResultDialogOption()
            {
                Title = "新建病理检查",
                BodyContext = obj,

                ComponentParamters = new Dictionary<string, object>
                {
                    //new(nameof(EditReportCard.TemplateParameter), Certificatetemplate),
                    [nameof(X_raypathologicalDlg.OnEventCallback)] = EventCallback.Factory.Create<X_raypathological>(this, v => raypathological = v)
                }
            });

            if (result == DialogResult.Yes)
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    if (raypathological != null)
                    {
                        raypathological.Createtime = DateTime.Now;
                        raypathological.Adminname = authenticationStateTask.Result.User.Identity.Name;
                        context.X_raypathologicals.Add(raypathological);
                        context.SaveChanges();
                        x_Raypathologicals.Add(raypathological);
                        ShowColorMessage(Color.Success, "病理检查添加成功", MessageElement);
                    }
                }
            }
            return;
        }

        private async Task OnEdit(X_raypathological myobject)
{
            X_raypathological raypathological = new X_raypathological();
            var retdlg = await dialogService.ShowModal<X_raypathologicalDlg>(new ResultDialogOption()
            {
                BodyContext = myobject,
                Title = "编辑修改",
                Size = BootstrapBlazor.Components.Size.ExtraSmall,
                ComponentParamters = new Dictionary<string, object>
                {
                    [nameof(X_raypathologicalDlg.OnEventCallback)] = EventCallback.Factory.Create<X_raypathological>(this, v => raypathological = v)
                }
            });

            if (retdlg == DialogResult.Yes)
            {
                try
                {
                    using (var context = contextFactory.CreateDbContext())
                    {
                        context.Update(raypathological);
                        context.SaveChanges();
                        ShowColorMessage(Color.Success, "数据编辑修改成功", MessageElement);
                        Log.Information(raypathological.ToString() + "-----成功修改------", raypathological);
                    }
                }
                catch (Exception sqlex)
                {
                    ShowColorMessage(Color.Warning, "数据编辑修改失败，请联系管理员", MessageElement);
                    Log.Warning(sqlex.Message);
                }
            }
            StateHasChanged();
        }

        private async Task OnDelete(X_raypathological myobject)
{
            using (var context = contextFactory.CreateDbContext())
            {
                context.X_raypathologicals.Remove(myobject);
                var ok = context.SaveChanges();
                if (ok > 0)
                {
                    x_Raypathologicals.Remove(myobject);
                    ShowColorMessage(Color.Info, "注意：数据已经成功删除", MessageElement);
                    StateHasChanged();
                }
                else
                {
                    ShowColorMessage(Color.Warning, "数据删除失败", MessageElement);

                }
            }

        }
        private async Task OnDetails(X_raypathological myobject)
        {
            raypathological = myobject;
            StateHasChanged();
            IsBackdropOpen = IsBackdropOpen ? false : true;
        }

        public async Task OnSearch()
        {
            using (var context = contextFactory.CreateDbContext())
            {
                var Username = authenticationStateTask.Result.User.Identity.Name;
                DateTime dateTime = DateTime.Now.AddDays(-30);
                if (Querywhere is null)
                {
                    x_Raypathologicals = await context.X_raypathologicals.AsNoTracking().Where(w => w.Adminname == Username).Take(100).ToListAsync();
                }
                else
                {
                    x_Raypathologicals = await context.X_raypathologicals.AsNoTracking().Where(w => w.Adminname == Username).Where(w => w.Medicalrecordnumber.Contains(Querywhere) || w.Username.Contains(Querywhere)).ToListAsync();
                }
            }
            StateHasChanged();
            return;
        }

        private Task<QueryData<X_raypathological>> OnQueryPageAsync(QueryPageOptions options)
        {
            var items = x_Raypathologicals.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems);
            return Task.FromResult(new QueryData<X_raypathological>()
            {
                Items = items,
                TotalCount = x_Raypathologicals.Count()
            });
        }

        public void ShowColorMessage(Color color, string content, Message message)
        {
            message.SetPlacement(BootstrapBlazor.Components.Placement.Top);
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