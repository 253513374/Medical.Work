using BootstrapBlazor.Components;
using Medical.Work.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class ContactsDlg : ComponentBase, IResultDialog
    {
       
       // IDbContextFactory<MedicalDbContext> ContextFactory;
        public Task OnClose(DialogResult result)
        {
            return Task.CompletedTask;
          //  throw new NotImplementedException();
        }
    }
}
