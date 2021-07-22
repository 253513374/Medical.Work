using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical.Work.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MainLayout
    {
        private bool UseTabSet { get; set; } = true;

        private string Theme { get; set; } 

        private bool IsOpen { get; set; }

        private bool IsFixedHeader { get; set; } = true;

        private bool IsFixedFooter { get; set; } = false;

        private bool IsFullSide { get; set; } = true;

        private bool ShowFooter { get; set; } = true;

        private bool showCollapseBar { get; set; } = true;


        private string calssstring { get; set; }
        private List<MenuItem> Menus { get; set; }

        private Dictionary<string, string> TabItemTextDictionary { get; set; }



        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            // 模拟异步线程切换，正式代码中删除此行代码
            //await Task.Yield();

            // 菜单获取可以通过数据库获取，此处为示例直接拼装的菜单集合
            TabItemTextDictionary = new()
            {
                [""] = "Index"
            };
            Menus = GetIconSideMenuItems();
        }

        private static List<MenuItem> GetIconSideMenuItems()
        {
            var menus = new List<MenuItem>
            {
                new MenuItem() { Text = "首页", Icon = "fa fa-fw fa-home", Url = "/",IsActive=true, Match = NavLinkMatch.All},

                new MenuItem() { Text = "类鼻疽-PD", Icon = "fa fa-fw fa-fa", Items= new  List<MenuItem>{ 
                 new MenuItem(){Text="临床微生物检查" , Url="PD_MicrobiologicalPage"},
                 new MenuItem(){Text="药敏试验",Url="PD_DrugAllergy_Page"}

                } },
                new MenuItem() { Text = "类鼻疽-PG", Icon = "fa fa-fw fa-check-square-o", Items =new List<MenuItem>{
                    new MenuItem(){Text="药物基因组学", Url="PG_PharmacogenomicsPage"},
                     new MenuItem(){Text="病原菌基因" ,Url="PG_PathogenGenePage"}
                } },

                new MenuItem() { Text = "类鼻疽-PK", Icon = "fa fa-fw fa-database" ,Items  = new List<MenuItem>{ 
                    new MenuItem(){Text="给药方案", Url = "MedicalPKPage"},
                     new MenuItem(){Text="采用信息"}
                } },

                new MenuItem() { Text = "影像学检查", Icon = "fa fa-video-camera",Items=new List<MenuItem>(){
                        new MenuItem(){Text="纤维支气管镜检查", Url = "X_RayBronchoscopyPage"},
                        new MenuItem(){Text="影像学检查" , Url = "X_RayImgPage"},
                        new MenuItem(){Text="病理检查" , Url = "X_RaypathologicalPage"}
                } },

                new MenuItem() { Text = "实验室检查", Icon = "fa fa-fw fa-table", Url = "LaboratoryExaminationPage" },
             
                new MenuItem() { Text = "药学监护流程", Icon = "fa fa-fw fa-fa", Url = "SummaryreportPage" },
                new MenuItem() { Text = "联系人管理", Icon = "fa fa-fw fa-check-square-o", Url = "ContactsPage" }
            
            };

            return menus;
        }
      

        private Task OnCollapsedEvent(bool s)
        {
            if (s)
            {
                calssstring = "display: none;";
            }
            else
            {
                calssstring = "display: block;";
            }

            return Task.CompletedTask;
        }


    }
}
