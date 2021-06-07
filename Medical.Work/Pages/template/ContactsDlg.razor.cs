using BootstrapBlazor.Components;
using Medical.Work.Data;
using Medical.Work.Data.Models;
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
        public async Task OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
//IEnumerableValues.ForEach(s => s.Remarks = Remarks);
                    await OnEventCallback.InvokeAsync(Contacts);
                }
            }
            return ;
          //  throw new NotImplementedException();
        }
    }
}
