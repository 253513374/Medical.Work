using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class PG_Pharmacogenomics_Dlg : ComponentBase, IResultDialog
    {
         async Task IResultDialog.OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    await OnEventCallback.InvokeAsync(Genome);
                }
            }
            return;
        }
    }
}
