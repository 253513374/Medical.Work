using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class PatientInfoDlg : ComponentBase, IResultDialog
    {
        Task IResultDialog.OnClose(DialogResult result)
        {
            // throw new NotImplementedException();

            return Task.CompletedTask;
        }
    }
}
