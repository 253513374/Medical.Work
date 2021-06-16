using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;

namespace Medical.Work.Pages.template
{
    public partial class X_raypathologicalDlg : ComponentBase, IResultDialog
    {
        Task IResultDialog.OnClose(DialogResult result)
        {
            //throw new NotImplementedException();

            return Task.CompletedTask;
        }
    }
}
