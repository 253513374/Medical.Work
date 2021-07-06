using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Medical.Work.Pages.template;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Medical.Work.Pages
{
    public partial class MedicalPKPage
    {
        [Inject]
        public DialogService? Dialog { set; get; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        private MedicalPK medicalPK { set; get; }

        private string Querywhere { set; get; }

       //private async Task<List<MedicalPK>> GetmedicalPK()
       // {
       //     using (var context  = contextFactory.CreateDbContext())
       //     {
       //         var adminname = authenticationStateTask.Result.User.Identity.Name;
       //         return await context.medicalPKs.AsNoTracking().Where(w=>w.AdminName== adminname).Where(w => w.CreateTime > DateTime.Now.AddDays(-30)).ToListAsync();
       //     }
       // }

        private async Task OnQuerywhere()
        {
            if(Querywhere is  null)
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    var adminname = authenticationStateTask.Result.User.Identity.Name;
                   var  medicals = await context.medicalPKs.AsNoTracking().Where(w => w.AdminName == adminname).Where(w => w.CreateTime > DateTime.Now.AddDays(-30)).ToListAsync();
                    if(medicals.Count>0)
                    {
                        medicalPK_s = medicals;
                    }
                }
                StateHasChanged();
            }
        }
        private async Task OnShowDlg()
        {
            var retdlg = await Dialog.ShowModal<MedicalPKDlg>(new ResultDialogOption()
            {
                BodyContext = new MedicalPK(),
                Title = "添加给药方案",
                Size = Size.ExtraLarge,
                ComponentParamters = new KeyValuePair<string, object>[]
                   {
                    new(nameof(MedicalPKDlg.OnEventCallback), EventCallback.Factory.Create<MedicalPK>(this, v => medicalPK = v))
                   }

            });

            if (retdlg == DialogResult.Yes)
            {
                using (var context = contextFactory.CreateDbContext())
                {
                    medicalPK.AdminName= authenticationStateTask.Result.User.Identity.Name;
                    medicalPK.CreateTime = DateTime.Now;
                    medicalPK.MedicalPKGuid = Guid.NewGuid().ToString();
                    context.medicalPKs.Add(medicalPK);
                    context.SaveChanges();
                    medicalPK_s.Add(medicalPK);
                }
              
            }
            StateHasChanged();
            return;

        }

        private async Task OnRowEditClick(MedicalPK medical)
        {
            var url = $"MedicalPKDetailsPage/{medical.MedicalPKID}";
            navigationManager.NavigateTo(url);
            return;
        }


        private async Task OnRowDetailedClick(MedicalPK medical)
        {
            return;
        }

    }
}
