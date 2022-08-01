using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medical.Data.Models
{
    /// <summary>
    /// 药学监护报告
    /// </summary>
    public class Summaryreport : BaseDataInterface
    {
        /// <summary>
        /// 监护流程名称
        /// </summary>
        [DisplayName("监护流程名称")]
        [Required(ErrorMessage = "必须填写")]
        public string? Summaryreportclass { set; get; }

        /// <summary>
        /// 检查日期
        /// </summary>
        [DisplayName("药学记录日期")]
        [Required(ErrorMessage = "必须填写")]
        public DateTime? Notesdate { set; get; }

        /// <summary>
        /// 临床症状
        /// </summary>
        [DisplayName("临床症状")]
        public string? Clinicalsymptoms { set; get; }

        /// <summary>
        /// 治疗方案
        /// </summary>
        [DisplayName("治疗方案")]
        public string? Treatmentplan { set; get; }


    }
}