using BootstrapBlazor.Components;
using System.Collections.Generic;

namespace Medical.Work.Data.Enum
{
    public class EnumItems
    {

        /// <summary>
        /// 性别
        /// </summary>
        public static IEnumerable<SelectedItem> SexItems { set; get; } = new[] {
            new SelectedItem("请选择...","请选择..."){ Active = true },
            new SelectedItem("男","男"),
            new SelectedItem("女","女")
        };

      public static IEnumerable<SelectedItem> Weighttype { get; set; } = new SelectedItem[]
      {

            new SelectedItem("估算", "估算") ,
            new SelectedItem("称重", "称重"){ Active = true }
      };
        /// <summary>
        /// 称重单位
        /// </summary>
        public static IEnumerable<SelectedItem> WeightEnum { set; get; } = new[] { 
        
            new SelectedItem("ug","ug"),
            new SelectedItem("mg","mg"),
            new SelectedItem("g","g"),
            new SelectedItem("kg","kg"),
            new SelectedItem("平车","平车"),
            new SelectedItem("卧床","卧床")
        };

        /// <summary>
        /// 手术移植类型
        /// </summary>
        public static IEnumerable<SelectedItem> TransplantationEnum { set; get; } = new[] {

            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("肾移植","肾移植"),
            new SelectedItem("肝移植","肝移植"),
            new SelectedItem("肺移植","肺移植"),
            new SelectedItem("干细胞移植","干细胞移植")
         
        };

    }
}
