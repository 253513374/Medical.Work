﻿using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class LaboratoryExaminationDlg : ComponentBase, IResultDialog
    {
        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate) await OnEventCallback.InvokeAsync(Laboratoryexamination);
            }
            //  throw new NotImplementedException();
        }
    }
}