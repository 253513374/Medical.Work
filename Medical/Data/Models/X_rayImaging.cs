﻿using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Medical.Data.Models
{
    /// <summary>
    /// 影像学检查
    /// </summary>
    public class X_rayImaging : BaseDataInterface
    {
        /// <summary>
        /// 检查日期
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
        /// 放射诊断方式X_rayImagingEnum
        /// </summary>
        [DisplayName("放射诊断方式")]
        public string Xrayimagingenum { set; get; }

        /// <summary>
        /// 放射诊断部位 X_rayImaginglocationEnum
        /// </summary>
        [DisplayName("放射诊断部位")]
        public string XrayImaginglocationenum { set; get; }

        /// <summary>
        /// 详细描述
        /// </summary>
        [DisplayName("详细描述")]
        public string Describe { set; get; }

        /// <summary>
        /// 摄影图像
        /// </summary>
       // [AutoGenerateColumn(Ignore = true)]
        [DisplayName("摄影图像")]
        public List<X_rayImagePaths> ImgUrl { set; get; }
    }
}