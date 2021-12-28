using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
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
                    await OnEventCallback.InvokeAsync(contacts);
                }
            }
            return;
            //  throw new NotImplementedException();
        }
    }
}