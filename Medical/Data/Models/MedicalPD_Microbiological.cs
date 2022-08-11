using Medical.Data.Enum;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medical.Data.Models
{
    /// <summary>
    /// 临床微生物学检查
    /// </summary>
    public class MedicalPD_Microbiological : BaseDataInterface
    {
        ///// <summary>
        ///// 登陆用户名称
        ///// </summary>
        //[DisplayName("账号")]
        //[AutoGenerateColumn(Ignore = true)]
        //public string Adminname { set; get; }

        ///// <summary>
        ///// 创建时间
        ///// </summary>
        //[DisplayName("创建时间")]
        //public DateTime CreateTime { set; get; }

        ///// <summary>
        ///// 病历号
        ///// </summary>
        //[NotNull]
        //[DisplayName("病历号")]
        //public string Medicalrecordnumber { set; get; }

        ///// <summary>
        ///// 患者姓名
        ///// </summary>
        //[NotNull]
        //[DisplayName("患者姓名")]
        //public string Username { set; get; }

        /// <summary>
        /// 是否做检查 TestorIsNotEnum
        /// </summary>
        [DisplayName("是否做检查")]
        [Required(ErrorMessage = "必须填写")]
        public string? TestorisNot { set; get; }

        /// <summary>
        /// 测试日期
        /// </summary>
        [DisplayName("检测日期")]
        public DateTime? TestTime { set; get; }

        /// <summary>
        /// 标本类型（血液，痰，肺泡灌洗液，尿液，导管血，脑脊液……）SpecimenTypeEnum
        /// </summary>
        [DisplayName("标本类型")]
        public string? SpecimenType { set; get; }

        /// <summary>
        /// 是否检出
        /// </summary>
        [DisplayName("是否检出")]
        public string? TestorNot { set; get; }

        /// <summary>
        /// 报告时间
        /// </summary>
        [DisplayName("报告时间")]
        public DateTime? ReportTime { set; get; }

        /// <summary>
        ///  报告日期
        /// </summary>
        [DisplayName("报告日期")]
        public DateTime? Inspectiontime { set; get; }

        /// <summary>
        /// 检出细菌
        /// </summary>
        [DisplayName("检出细菌")]
        public string? Bacterial { set; get; }
    }
}