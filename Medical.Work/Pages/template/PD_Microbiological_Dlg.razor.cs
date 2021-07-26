using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class PD_Microbiological_Dlg : ComponentBase, IResultDialog
    {
        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {

                    await OnEventCallback.InvokeAsync(medicalPD_Microbiological);
                }
            }
            return;
        }
    }
}
