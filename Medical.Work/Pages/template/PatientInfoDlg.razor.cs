using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class PatientInfoDlg : ComponentBase, IResultDialog
    {
        async Task IResultDialog.OnClose(DialogResult result)
        {
            // throw new NotImplementedException();
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    //IEnumerableValues.ForEach(s => s.Remarks = Remarks);
                    await OnEventCallback.InvokeAsync(patientInfo);
                }
            }
            return;
        }
    }
}