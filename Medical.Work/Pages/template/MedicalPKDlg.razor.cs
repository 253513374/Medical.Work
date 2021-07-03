using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class MedicalPKDlg : ComponentBase, IResultDialog
    {
        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate) await OnEventCallback.InvokeAsync(medicalPK);
            }
            //  throw new NotImplementedException();
        }
    }
}
