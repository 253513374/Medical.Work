using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
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

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }
        [Inject]
        private IWebHostEnvironment WebHost { get; set; }

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

        private async Task OnCardUpload(UploadFile uploadFile)
        {
            if (uploadFile != null && uploadFile.File != null)
            {

                // 服务器端验证当文件大于 2MB 时提示文件太大信息
                if (uploadFile.Size > MaxFileLength)
                {
                    await ToastService.Information("上传文件", $"文件大小超过 200MB");
                    uploadFile.Code = 1;
                    uploadFile.Error = "文件大小超过 200MB";
                }
                else
                {

                    var path = $"images{Path.DirectorySeparatorChar}{authenticationStateTask.Result.User.Identity.Name}";
                    var uploaderFolder = Path.Combine(WebHost.WebRootPath, path);
                    var FileName1 = $"{Path.GetFileNameWithoutExtension(uploadFile.OriginFileName)}-{DateTimeOffset.Now:yyyyMMddHHmmss}{Path.GetExtension(uploadFile.OriginFileName)}";
                    var fileName = Path.Combine(uploaderFolder, FileName1);

                    if (!Directory.Exists(uploaderFolder))
                    {
                        Directory.CreateDirectory(uploaderFolder);
                    }
                    var ret = await uploadFile.SaveToFile(fileName, MaxFileLength);
                    if (ret)
                    {
                        uploadFile.PrevUrl = $"images/{authenticationStateTask.Result.User.Identity.Name}/{FileName1}";
                    }


                }
            }
        }
    }
}
