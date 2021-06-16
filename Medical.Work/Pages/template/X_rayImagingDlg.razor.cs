using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;

namespace Medical.Work.Pages.template 
{
    public partial class X_rayImagingDlg : ComponentBase, IResultDialog
    {
        Task IResultDialog.OnClose(DialogResult result)
        {
            //throw new NotImplementedException();
            return Task.CompletedTask;
        }
        [CascadingParameter(Name = "BodyContext")]
        public object? objectX_rayImaging { set; get; }


        [Parameter]
        public EventCallback<X_rayImaging> OnEventCallback { set; get; }

        private X_rayImaging x_RayImaging { set; get; }


        private static long MaxFileLength => 200 * 1024 * 1024;

        [Inject]
        [NotNull]
        private ToastService? ToastService { get; set; }

        protected override Task OnInitializedAsync()
        {
            x_RayImaging = objectX_rayImaging as X_rayImaging;
            return base.OnInitializedAsync();
        }
        private async Task OnCardUpload(UploadFile file)
        {
            if (file != null && file.File != null)
            {
                // 服务器端验证当文件大于 2MB 时提示文件太大信息
                if (file.Size > MaxFileLength)
                {
                    await ToastService.Information("上传文件", $"文件大小超过 200MB");
                    file.Code = 1;
                    file.Error = "文件大小超过 200MB";
                }
                else
                {
                    CancellationTokenSource cancellationToken = new();
                    file.SaveToFile($"D:\\{file.OriginFileName}", MaxFileLength, cancellationToken.Token);
                    // file.s
                }
            }
        }
    }
}
