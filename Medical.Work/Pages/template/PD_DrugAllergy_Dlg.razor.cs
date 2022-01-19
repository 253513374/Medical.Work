using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class PD_DrugAllergy_Dlg : ComponentBase, IResultDialog
    {
        async Task IResultDialog.OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    medicalPD_DrugAllergy.Createtime = DateTime.Now;
                    medicalPD_DrugAllergy.Adminname = authenticationStateTask.Result.User.Identity.Name;
                    await OnEventCallback.InvokeAsync(medicalPD_DrugAllergy);
                }
            }
            return;
        }
    }
}