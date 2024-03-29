﻿using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class MedicalPKSamplingsampleDlg : ComponentBase, IResultDialog
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    if (medicalPKSampling.medicalPKSamplings is null) medicalPKSampling.medicalPKSamplings = new();
                    //var name = authenticationStateTask.Result.User.Identity.Name;
                    medicalPKSampling.Adminname = authenticationStateTask.Result.User.Identity.Name;
                    medicalPKSampling.Createtime = DateTime.Now;

               
                    medicalPKSampling.medicalPKSamplings.AddRange(pKSampling_Samples);
                    await OnEventCallback.InvokeAsync(medicalPKSampling);
                }
            }
            return;
            //throw new NotImplementedException();
        }
    }
}