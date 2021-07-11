﻿using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 临床微生物学检查
    /// </summary>
    public class MedicalPD_Microbiological
    {
        // MedicalPD_DrugAllergy
        /// <summary>
        /// 自增
        /// </summary>
        [DisplayName("自增")]
        public int MedicalPD_MicrobiologicalID { set; get; }


        /// <summary>
        /// 唯一编码
        /// </summary>
        [DisplayName("唯一编码")]
        public string P_Guid { set; get; }

        /// <summary>
        /// 登陆用户名称
        /// </summary>
        [DisplayName("账号")]
        public string Adminname { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateTime { set; get; }


        /// <summary>
        /// 是否做检查
        /// </summary>
        [DisplayName("是否做检查")]
        public TestorIsNotEnum? TestorisNot { set; get; }

        /// <summary>
        /// 测试日期
        /// </summary>
        [DisplayName("检测日期")]
        public DateTime TestTime { set; get; }

        /// <summary>
        /// 标本类型（血液，痰，肺泡灌洗液，尿液，导管血，脑脊液……）
        /// </summary>
        [DisplayName("标本类型")]
        public SpecimenTypeEnum? SpecimenType { set; get; }

        /// <summary>
        /// 是否检出
        /// </summary>
        [DisplayName("是否检出")]
        public TestorNotEnum? TestorNot { set; get; }


        /// <summary>
        /// 报告时间
        /// </summary>
        [DisplayName("报告时间")]
        public DateTime ReportTime { set; get; }


        /// <summary>
        ///  报告日期
        /// </summary>
        [DisplayName("报告日期")]
        public DateTime Inspectiontime { set; get; }


        /// <summary>
        /// 检出细菌
        /// </summary>
        [DisplayName("检出细菌")]
        public string Bacterial { set; get; }


    }
}