using BootstrapBlazor.Components;
using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 影像学检查
    /// </summary>
    public class X_rayImaging
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
        [NotNull]
        public string Username { set; get; }



        /// <summary>
        /// 病历号
        /// </summary>
        [DisplayName("病历号")]
        [NotNull]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName("检查日期")]
        [NotNull]
        public DateTime Photodate { set; get; }

        /// <summary>
        /// 报告日期
        /// </summary>
        [DisplayName("报告日期")]
        [NotNull]
        public DateTime Reportdate { set; get; }

        /// <summary>
        /// 放射诊断方式
        /// </summary>
        [DisplayName("放射诊断方式")]
        public X_rayImagingEnum Xrayimagingenum { set; get; }

        /// <summary>
        /// 放射诊断部位
        /// </summary>
        [DisplayName("放射诊断部位")]
        public X_rayImaginglocationEnum XrayImaginglocationenum { set; get; }

        /// <summary>
        /// 详细描述
        /// </summary>
        [DisplayName("详细描述")]
        public string Describe { set; get; }


        /// <summary>
        /// 摄影图像
        /// </summary>
        [AutoGenerateColumn(Ignore = true)]
        [DisplayName("摄影图像")]
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
