
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Medical.Data.Models
{
    public class BaseDataInterface
    {
        /// <summary>
        /// ID
        /// </summary>
        [DisplayName("自增")]
       
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
        [Required(ErrorMessage = "编号必须填写")]
        [DisplayName("编号")]
        public string? Medicalrecordnumber { set; get; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [NotNull]
        [Required(ErrorMessage = "姓名必须填写")]
        [DisplayName("患者姓名")]
        public string? Username { set; get; }

        [DisplayName("唯一编码")]
        public string? Guid { set; get; }

        [DisplayName("记录时间")]
        public DateTime? Createtime { set; get; }
    }
}