using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class PD_Microbiological_Dlg : ComponentBase, IResultDialog
    {

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    medicalPD_Microbiological.Createtime = DateTime.Now;
                    medicalPD_Microbiological.Adminname = authenticationStateTask.Result.User.Identity.Name;
                    await OnEventCallback.InvokeAsync(medicalPD_Microbiological);
                }
            }
            return;
        }
    }
}