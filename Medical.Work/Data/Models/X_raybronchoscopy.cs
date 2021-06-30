﻿using BootstrapBlazor.Components;
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
    public class X_raybronchoscopy
    {

        [AutoGenerateColumn(Ignore=true)]
        public int X_raybronchoscopyID { set; get; }



        [AutoGenerateColumn(Ignore = true, DefaultSort=true)]
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
        /// 放射诊断方式
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
