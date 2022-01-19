using BootstrapBlazor.Components;
using Medical.Work.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;

namespace Medical.Work.Pages.template
{
    public partial class X_raybronchoscopyDlg : ComponentBase, IResultDialog
    {
        async Task IResultDialog.OnClose(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                if (OnEventCallback.HasDelegate)
                {
                    x_Raybronchoscopy.Createtime = DateTime.Now;
                    x_Raybronchoscopy.Adminname = authenticationStateTask.Result.User.Identity.Name;
                    await OnEventCallback.InvokeAsync(x_Raybronchoscopy);
                }
            }
            else
            {
                if (x_Raybronchoscopy.ImgUrl is null) return;
                foreach (var item in x_Raybronchoscopy.ImgUrl)
                {
                    var uploaderFolder = Path.Combine(WebHost.WebRootPath, item.ImgUrl);
                    var delpath = Path.GetFullPath(uploaderFolder);
                    System.IO.File.Delete(delpath);
                }
            }
            return;
        }

        [CascadingParameter(Name = "BodyContext")]
        public object? objectX_raybronchoscopy { set; get; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        private IWebHostEnvironment WebHost { get; set; }

        [Parameter]
        public EventCallback<X_raybronchoscopy> OnEventCallback { set; get; }

        private X_raybronchoscopy x_Raybronchoscopy { set; get; } = new();

        private static long MaxFileLength => 200 * 1024 * 1024;

        [Inject]
        [NotNull]
        private ToastService? ToastService { get; set; }

        protected override Task OnParametersSetAsync()
        {
            if (objectX_raybronchoscopy is not null)
            {
                x_Raybronchoscopy = objectX_raybronchoscopy as X_raybronchoscopy;
            }

            return base.OnParametersSetAsync();
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
                        if (x_Raybronchoscopy.ImgUrl is null) x_Raybronchoscopy.ImgUrl = new();

                        // x_Raybronchoscopy.ImgUrl.Add(new X_raybronchoscopyPaths() { ImgUrl = imapath });

                        var imgpath = GetImgPath(uploadFile.PrevUrl);
                        x_Raybronchoscopy.ImgUrl.Add(imgpath);
                    }
                }
            }
        }

        private Task<bool> OnFileDelete(UploadFile item)
        {
            //Trace?.Log($"{item.OriginFileName} {Localizer["RemoveMsg"]}");
            //  var path = $"images{Path.DirectorySeparatorChar}{authenticationStateTask.Result.User.Identity.Name}";
            var uploaderFolder = Path.Combine(WebHost.WebRootPath, item.PrevUrl);

            x_Raybronchoscopy.ImgUrl.RemoveAll(r => r.ImgUrl == item.PrevUrl);
            var delpath = Path.GetFullPath(uploaderFolder);
            System.IO.File.Delete(delpath);
            return Task.FromResult(true);
        }

        private X_raybronchoscopyPaths GetImgPath(string url)
        {
            var name = authenticationStateTask.Result.User.Identity.Name;
            return new X_raybronchoscopyPaths()
            {
                ImgUrl = url,
                Createtime = DateTime.Now,
                Adminuser = name,
            };
        }
    }
}