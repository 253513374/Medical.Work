﻿using Medical.Work.Data.Enum;
using System;
using System.ComponentModel;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 药敏试验检查
    /// </summary>
    public class MedicalPD_DrugAllergy : BaseDataInterface
    {
        /// <summary>
        /// 是否做检查 TestorIsNotEnum
        /// </summary>
        [DisplayName("是否做检查")]
        public string TestorisNot { set; get; }

        /// <summary>
        /// 测试日期
        /// </summary>
        [DisplayName("检测日期")]
        public DateTime TestTime { set; get; }

        /// <summary>
        /// 报告时间
        /// </summary>
        [DisplayName("报告时间")]
        public DateTime ReportTime { set; get; }

        /// <summary>
        /// 药敏检测方法
        /// </summary>
        [DisplayName("药敏检测方法")]
        public string? DrugsensitivityTest { set; get; }

        /// <summary>
        /// 药敏检测其他方法
        /// </summary>
        [DisplayName("药敏检测其他方法")]
        public string DrugsensitivityTestOther { set; get; }

        /// <summary>
        ///
        /// </summary>
        [DisplayName("药品名称")]
        public string DrugsName { set; get; }

        /// <summary>
        /// MIC: 伏立康唑，氟康唑，卡泊芬净，两性霉素B，美罗培南，亚胺培南，头孢他啶，复方磺胺甲噁唑，头孢哌酮舒巴坦钠，头孢哌酮他唑巴坦，哌拉西林他唑巴坦，替加环素，达托霉素……..
        /// </summary>
        [DisplayName("MIC(mg/ml)")]
        public string MIC { set; get; }

        /// <summary>
        /// 敏感性
        /// </summary>
        [DisplayName("敏感性")]
        public string? Susceptibility { set; get; }

        /// <summary>
        /// T>MIC%
        /// </summary>
        [DisplayName("T>MIC%")]
        public string TMic { set; get; }

        /// <summary>
        /// AUCSS,24h/MIC
        /// </summary>
        [DisplayName("AUCSS,24h/MIC")]
        public string AUCMic { set; get; }
    }
}