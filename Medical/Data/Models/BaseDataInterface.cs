﻿using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Medical.Data.Models
{
    public interface ITenantInterface
    { }

    public abstract class BaseDataInterface
    {
        /// <summary>
        /// ID
        /// </summary>

        public int ID { set; get; }

        //[AutoGenerateColumn(Ignore = true)]
        //public int LaboratoryExaminationID { set; get; }

        /// <summary>
        /// 登陆用户名称
        /// </summary>
        public string? Adminname { set; get; }

        /// <summary>
        /// 病历号 编号
        /// </summary>
        [NotNull]
        [DisplayName("病历编号")]
        public string? Medicalrecordnumber { set; get; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [NotNull]
        [DisplayName("患者姓名")]
        public string? Username { set; get; }

        /// <summary>
        /// PatientInfo 的唯一编码
        /// </summary>
        [DisplayName("唯一编码")]
        public string? Guid { set; get; }

        [DisplayName("记录时间")]
        public DateTime? CreateTime { set; get; }

        //[NotMapped]
        //[Required(ErrorMessage = "必须填写")]
        //public PatientInfo Patient { get; set; }
    }
}