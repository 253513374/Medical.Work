using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class PatientInfoDlg : ComponentBase, IResultDialog
    {
        async Task IResultDialog.OnClose(DialogResult result)
        {
            // throw new NotImplementedException();
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    //IEnumerableValues.ForEach(s => s.Remarks = Remarks);
                    patientInfo.Adminname=authenticationStateTask.Result.User.Identity.Name;
                    patientInfo.Createtime = DateTime.Now;
                    patientInfo.Guid = Guid.NewGuid().ToString();
                    await OnEventCallback.InvokeAsync(patientInfo);
                }
            }
            return;
        }
    }
}