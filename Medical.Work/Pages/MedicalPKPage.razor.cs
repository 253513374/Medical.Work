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

       private async Task<List<MedicalPK>> GetmedicalPK()
        {
            using (var context  = contextFactory.CreateDbContext())
            {
                return await context.medicalPKs.AsNoTracking().Where(w => w.CreateTime > DateTime.Now.AddDays(-30)).ToListAsync(); 
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
                    context.medicalPKs.Add(medicalPK);
                    context.SaveChanges();
                }
              
            }
            StateHasChanged();
            return;

        }

        private async Task OnRowEditClick(MedicalPK medical)
        {
            return;
        }
        private async Task OnRowDetailedClick(MedicalPK medical)
        {
            return;
        }

    }
}
