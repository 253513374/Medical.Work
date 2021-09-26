using BootstrapBlazor.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 纤维支气管镜检查
    /// </summary>
    public class X_raybronchoscopy : BaseDataInterface
    {

        [AutoGenerateColumn(Ignore=true)]
        public int X_raybronchoscopyID { set; get; }



        //[AutoGenerateColumn(Ignore = true, DefaultSort=true)]
        //public DateTime Createtime { set; get; }



        /// <summary>
        /// 检查日期
        /// </summary>
        [DisplayName("检查日期")]
        public DateTime Photodate { set; get; }

        /// <summary>
        /// 报告日期
        /// </summary>
        [DisplayName("报告日期")]
        public DateTime Reportdate { set; get; }

        /// <summary>
        /// 部位
        /// </summary>
        [DisplayName("部位")]
        public string Xraylocation { set; get; }
        /// <summary>
        /// 检查结果
        /// </summary>
        [DisplayName("检查结果")]
        public string Xrayinspection { set; get; }


        /// <summary>
        /// 摄影图像
        /// </summary>
        [AutoGenerateColumn(Ignore = true)]
        [DisplayName("摄影图像")]
        public List<X_raybronchoscopyPaths>  ImgUrl { set; get; }


    }
}
