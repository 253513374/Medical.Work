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
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using System.IO.Pipelines;
using Microsoft.AspNetCore.Components.Authorization;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.AspNetCore.Hosting.Server;

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
                    //IEnumerableValues.ForEach(s => s.Remarks = Remarks);
                    await OnEventCallback.InvokeAsync(x_Raybronchoscopy);
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
            if(objectX_raybronchoscopy is not  null)
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

                    var path= $"images{Path.DirectorySeparatorChar}{authenticationStateTask.Result.User.Identity.Name}";
                    var uploaderFolder = Path.Combine(WebHost.WebRootPath, path);
                    var FileName1 = $"{Path.GetFileNameWithoutExtension(uploadFile.OriginFileName)}-{DateTimeOffset.Now:yyyyMMddHHmmss}{Path.GetExtension(uploadFile.OriginFileName)}";
                    var fileName = Path.Combine(uploaderFolder, FileName1);

                    if (!Directory.Exists(uploaderFolder) )
{
                        Directory.CreateDirectory(uploaderFolder);
                    }
                    var ret =  await uploadFile.SaveToFile(fileName, MaxFileLength);
                    if(ret)
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
