using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Medical.Work.Pages.template;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Medical.Work.Pages
{
    public partial class X_rayphotographyPage
    {
        private int SelectTable { set; get; }
        private string Querywhere { set; get; }

        private X_raybronchoscopy raybronchoscopy { set; get; }
        private X_raypathological raypathological { set; get; } 
        private X_rayImaging rayImaging { set; get; }



        private List<X_raybronchoscopy>  x_Raybronchoscopies { set; get; } = new();
        private List<X_raypathological> X_Raypathologicals { set; get; } = new();
        private List<X_rayImaging> X_RayImagings { set; get; } = new();

        private async Task OnShowX_rayDialog1()
        {
            var result = await Dialogservice.ShowModal<X_rayImagingDlg>(new ResultDialogOption()
            {
                Title = "新建影像学检查",
                BodyContext = new X_rayImaging(),

                ComponentParamters = new KeyValuePair<string, object>[]
                {
                //new(nameof(EditReportCard.TemplateParameter), Certificatetemplate),
                      new(nameof(X_rayImagingDlg.OnEventCallback), EventCallback.Factory.Create<X_rayImaging>(this, v => rayImaging = v))
                }
            });

            if (result == DialogResult.Yes)
            {
                using (var context = ContextFactor.CreateDbContext())
                {
                    if(rayImaging!=null)
                    {
                        rayImaging.Cretetime = DateTime.Now;
                        rayImaging.Adminname = authenticationStateTask.Result.User.Identity.Name;
                        context.X_rayImagings.Add(rayImaging);
                        context.SaveChanges();
                        X_RayImagings.Add(rayImaging);
                    }
                }
                // MessageTagservice.ShowColorMessage(Color.Danger, "医患信息添加成功", MessageElement);
            }
            return;
        }
        private async Task OnShowX_rayDialog2()
        {
            var result = await Dialogservice.ShowModal<X_raybronchoscopyDlg>(new ResultDialogOption()
            {
                Title = "新建纤维支气管镜检查",
                BodyContext = new X_raybronchoscopy(),

                ComponentParamters = new KeyValuePair<string, object>[]
                  {
                //new(nameof(EditReportCard.TemplateParameter), Certificatetemplate),
                      new(nameof(X_raybronchoscopyDlg.OnEventCallback), EventCallback.Factory.Create<X_raybronchoscopy>(this, v => raybronchoscopy = v))
                  }
            });

            if (result == DialogResult.Yes)
            {
                // MessageTagservice.ShowColorMessage(Color.Danger, "医患信息添加成功", MessageElement);
                using (var context = ContextFactor.CreateDbContext())
                {
                    if (raybronchoscopy != null)
                    {
                        raybronchoscopy.Cretetime = DateTime.Now;
                        raybronchoscopy.Adminname = authenticationStateTask.Result.User.Identity.Name;
                        context.X_raybronchoscopys.Add(raybronchoscopy);
                        context.SaveChanges();
                        x_Raybronchoscopies.Add(raybronchoscopy);
                    }
                }
            }
            return;
            //return Task.CompletedTask;
        }
        private async Task OnShowX_rayDialog3()
        {

            var result = await Dialogservice.ShowModal<X_raypathologicalDlg>(new ResultDialogOption()
            {
                Title = "新建病理检查",
                BodyContext = new X_raypathological(),

                ComponentParamters = new KeyValuePair<string, object>[]
                {
                    //new(nameof(EditReportCard.TemplateParameter), Certificatetemplate),
                    new(nameof(X_raypathologicalDlg.OnEventCallback), EventCallback.Factory.Create<X_raypathological>(this, v => raypathological = v))
                }
            });

            if (result == DialogResult.Yes)
            {
                // MessageTagservice.ShowColorMessage(Color.Danger, "医患信息添加成功", MessageElement);
                using (var context = ContextFactor.CreateDbContext())
                {
                    if (raypathological != null)
                    {
                        raypathological.Cretetime = DateTime.Now;
                        raypathological.Adminname = authenticationStateTask.Result.User.Identity.Name;
                        context.X_raypathologicals.Add(raypathological);
                        context.SaveChanges();
                        X_Raypathologicals.Add(raypathological);
                    }
                }
            }
            return;

        }


        public  async Task OnSelectTableChanged(SelectedItem selected)
        {

            using (var context = ContextFactor.CreateDbContext())
            {
                var username = authenticationStateTask.Result.User.Identity.Name;
                DateTime dateTime = DateTime.Now.AddDays(-10);
                switch (selected.Value)
                {
                    case "1":
                        X_RayImagings = await context.X_rayImagings.AsNoTracking().Where(w => w.Adminname == username).Where(w => w.Cretetime >= dateTime).ToListAsync();
                        break;
                    case "2":
                        x_Raybronchoscopies = await context.X_raybronchoscopys.AsNoTracking().Where(w => w.Adminname == username).Where(w => w.Cretetime >= dateTime).ToListAsync();
                        break;
                    case "3":
                        X_Raypathologicals = await context.X_raypathologicals.AsNoTracking().Where(w => w.Adminname == username).Where(w => w.Cretetime >= dateTime).ToListAsync();
                        break;
                    default:
                        break;
                }
            }
            StateHasChanged();
            return;
        }

    }
}
