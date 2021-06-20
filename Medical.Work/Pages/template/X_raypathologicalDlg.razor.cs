using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;

namespace Medical.Work.Pages.template
{
    public partial class X_raypathologicalDlg : ComponentBase, IResultDialog
    {

        private IWebHostEnvironment webHostEnvironment { set; get; }
        async Task IResultDialog.OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    //IEnumerableValues.ForEach(s => s.Remarks = Remarks);
                    await OnEventCallback.InvokeAsync(x_Raypathological);
                }
            }
            return;
        }

        //public X_raypathologicalDlg(IWebHostEnvironment webHost)
        //{
        //    webHostEnvironment = webHost;
        //}

        [CascadingParameter(Name = "BodyContext")]
        public object? objectx_Raypathological { set; get; }


        [Parameter]
        public EventCallback<X_raypathological> OnEventCallback { set; get; }

        private X_raypathological x_Raypathological { set; get; }

        private static long MaxFileLength => 200 * 1024 * 1024;

        [Inject]
        [NotNull]
        private ToastService? ToastService { get; set; }

        //[Inject]
        //[NotNull]
        //private IOptions<WebsiteOptions>? SiteOptions { get; set; }

        protected override Task OnInitializedAsync()
        {
            x_Raypathological = objectx_Raypathological as X_raypathological;
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
                    file.SaveToFile($"D:\\{file.OriginFileName}",MaxFileLength,cancellationToken.Token);
                   // file.s
                }
            }
        }
        //private async Task<bool> SaveToFile(UploadFile file)
        //{
        //    // Server Side 使用
        //    // Web Assembly 模式下必须使用 webapi 方式去保存文件到服务器或者数据库中
        //    // 生成写入文件名称
        //    var ret = false;
        //    if (!string.IsNullOrEmpty(SiteOptions.Value.WebRootPath))
        //    {
        //        var uploaderFolder = Path.Combine(SiteOptions.Value.WebRootPath, $"images{Path.DirectorySeparatorChar}uploader");
        //        file.FileName = $"{Path.GetFileNameWithoutExtension(file.OriginFileName)}-{DateTimeOffset.Now:yyyyMMddHHmmss}{Path.GetExtension(file.OriginFileName)}";
        //        var fileName = Path.Combine(uploaderFolder, file.FileName);

        //        ReadToken ??= new CancellationTokenSource();
        //        ret = await file.SaveToFile(fileName, MaxFileLength, ReadToken.Token);

        //        if (ret)
        //        {
        //            // 保存成功
        //            file.PrevUrl = $"images/uploader/{file.FileName}";
        //        }
        //        else
        //        {
        //            var errorMessage = $"保存文件失败 {file.OriginFileName}";
        //            file.Code = 1;
        //            file.Error = errorMessage;
        //            await ToastService.Error("上传文件", errorMessage);
        //        }
        //    }
        //    else
        //    {
        //        file.Code = 1;
        //        file.Error = "Wasm 模式未实现保存代码";
        //        await ToastService.Information("保存文件", "当前模式为 WebAssembly 模式，请调用 Webapi 模式保存文件到服务器端或数据库中");
        //    }
        //    return ret;
        //}
    }
}
