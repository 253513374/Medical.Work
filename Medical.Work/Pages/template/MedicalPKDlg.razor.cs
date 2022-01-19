using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class MedicalPKDlg : ComponentBase, IResultDialog
    {

    
        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    medicalPK.Adminname = authenticationStateTask.Result.User.Identity.Name;
                    medicalPK.Createtime = DateTime.Now;
                    medicalPK.Guid = Guid.NewGuid().ToString();

                    await OnEventCallback.InvokeAsync(medicalPK);
                };
            }
            //  throw new NotImplementedException();
        }
    }
}