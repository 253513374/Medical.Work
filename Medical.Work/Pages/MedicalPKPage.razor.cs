using BootstrapBlazor.Components;
using Medical.Work.Data;
using Medical.Work.Data.Models;
using Medical.Work.Pages.template;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Pages
{
    public partial class MedicalPKPage
    {
        [Inject]
        public DialogService? Dialog { set; get; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        private MedicalPK medicalPK { set; get; } = new();

        private string Querywhere { set; get; }


        private async Task OnQuerywhere()
        {
            if (Querywhere is null)
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    var Adminname = authenticationStateTask.Result.User.Identity.Name;
                    //var  medicals = await context.medicalPKs.AsNoTracking().Where(w => w.Adminname == Adminname).Where(w => w.Createtime > DateTime.Now.AddDays(-30)).ToListAsync();

                    //medicalPK_s = context.MPKs.Include(i => i.MedicalPKSamplings).ThenInclude(t => t.medicalPKSamplings).Where(w => w.Adminname == Adminname).Where(w => w.Createtime > DateTime.Now.AddDays(-30)).ToList();
                    medicalPK_s = await context.MPKs.Where(w => w.Adminname == Adminname ).OrderByDescending(o=>o.Createtime).Take(100).ToListAsync();
                    //if (medicals.Count>0)
                    //{
                    //    medicalPK_s = medicals;
                    //}
                }
                // StateHasChanged();
            }
        }

        private async Task OnShowDlg(MedicalPK obj)
        {

            MedicalPK pK = new MedicalPK();
            var retdlg = await Dialog.ShowModal<MedicalPKDlg>(new ResultDialogOption()
            {
                BodyContext = obj,
                Title = "添加给药方案",
                Size = Size.ExtraLarge,
                ComponentParamters = new Dictionary<string, object>
                {
                    [nameof(MedicalPKDlg.OnEventCallback)] = EventCallback.Factory.Create<MedicalPK>(this, v => pK = v)
                }
            });

            if (retdlg == DialogResult.Yes)
            {
                using (var context = contextFactory.CreateDbContext())
                {
                  
                    context.MPKs.Add(pK);
                    context.SaveChanges();
                    medicalPK_s.Add(pK);
                }
            }
            StateHasChanged();
            return;
        }

        private async Task OnRowDetailedClick(MedicalPK medical)
        {
            return;
        }
    }
}