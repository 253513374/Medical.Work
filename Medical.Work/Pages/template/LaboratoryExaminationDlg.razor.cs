using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class LaboratoryExaminationDlg : ComponentBase, IResultDialog
    {
        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
            if (OnEventCallback.HasDelegate) 
                {
                    Laboratoryexamination.Adminname = authenticationStateTask.Result.User.Identity.Name;
                    Laboratoryexamination.Createtime = DateTime.Now;
                    await OnEventCallback.InvokeAsync(Laboratoryexamination);
                }
            }
            //  throw new NotImplementedException();
        }
    }
}