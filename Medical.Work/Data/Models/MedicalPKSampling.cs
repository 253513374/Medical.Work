﻿using BootstrapBlazor.Components;
using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 采样信息
    /// </summary>
    public class MedicalPKSampling : BaseDataInterface
    {
        //[AutoGenerateColumn(Ignore = true)]
        //public int MedicalPKSamplingID { set; get; }

        //[AutoGenerateColumn(Ignore = true)]
        //public int MedicalPKID { set; get; }

        ///// <summary>
        ///// 管理员账号
        ///// </summary>
        //[DisplayName("管理员账号")]
        //[AutoGenerateColumn(Ignore = true)]
        //public string Adminname { set; get; }

        ///// <summary>
        ///// 创建时间
        ///// </summary>
        //[DisplayName("创建时间")]
        //[AutoGenerateColumn(Ignore = true)]
        //public DateTime Createtime { set; get; }

        /// <summary>
        /// 标本类型
        /// </summary>
        [DisplayName("标本类型")]
        public SpecimenTypeEnum? SpecimenType { set; get; }

        /// <summary>
        /// 采集时间
        /// </summary>
        [DisplayName("采集时间")]
        public DateTime CollectDateTime { set; get; }

        /// <summary>
        ///采血当日开始给药时间
        /// </summary>
        [DisplayName("采血当日开始给药时间")]
        public DateTime StartDateTime { set; get; }

        /// <summary>
        /// 采血当日输注完时间
        /// </summary>
        [DisplayName("采血当日输注完时间")]
        public DateTime EndDateTime { set; get; }

        /// <summary>
        /// 采血前最后一次给药时间
        /// </summary>
        [DisplayName("采血前最后一次给药时间")]
        public DateTime LastDateTime { set; get; }

        /// <summary>
        /// 采血管
        /// </summary>
        [DisplayName("采血管")]
        public CollectingVesselEnum? Collectingvessel { set; get; }

        /// <summary>
        /// 采血样品详细信息
        /// </summary>
        [AutoGenerateColumn(Ignore = true)]
        public List<MedicalPKSamplingsample> medicalPKSamplings { get; set; }
    }
}