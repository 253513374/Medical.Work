using BootstrapBlazor.Components;
using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{

    /// <summary>
    /// 病理检查
    /// </summary>
    public class X_raypathological
    {
        [AutoGenerateColumn(Ignore = true)]
        public int ID { set; get; }

        [AutoGenerateColumn(Ignore = true, DefaultSort = true)]
        public DateTime Cretetime { set; get; }

        /// <summary>
        /// 管理员账号
        /// </summary>
        [AutoGenerateColumn(Ignore = true)]
        public string Adminname { set; get; }


        /// <summary>
        /// 患者名称
        /// </summary>
        [DisplayName("患者姓名")]
        public string Username { set; get; }

        /// <summary>
        /// 病历号
        /// </summary>
        [DisplayName("病历号")]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 
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
        /// 放射诊断方式
        /// </summary>
        [DisplayName("检查结果")]
        public string Xrayinspection { set; get; }
        /// <summary>
        /// 摄影图像
        /// </summary>
        [DisplayName("摄影图像")]
        [AutoGenerateColumn(Ignore = true)]
        public byte[] Imge1 { set; get; }
        /// <summary>
        /// 摄影图像
        /// </summary>
        [DisplayName("摄影图像")]
        [AutoGenerateColumn(Ignore = true)]
        public byte[] Imge2 { set; get; }
        /// <summary>
        /// 摄影图像
        /// </summary>
        [DisplayName("摄影图像")]
        [AutoGenerateColumn(Ignore = true)]
        public byte[] Imge3 { set; get; }
        /// <summary>
        /// 摄影图像
        /// </summary>
        [DisplayName("摄影图像")]
        [AutoGenerateColumn(Ignore = true)]
        public byte[] Imge4 { set; get; }
        /// <summary>
        /// 摄影图像
        /// </summary>
        [DisplayName("摄影图像")]
        [AutoGenerateColumn(Ignore = true)]
        public byte[] Imge5 { set; get; }
    }
}
