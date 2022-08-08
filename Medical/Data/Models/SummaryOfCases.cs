using Medical.Data.Enum;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medical.Data.Models
{

    /// <summary>
    /// 案列总结
    /// </summary>
    public class SummaryOfCases : BaseDataInterface
    {
        /// <summary>
        /// 病史概要
        /// </summary>
        [DisplayName("病史概要")]
        public string? Medicalhistorysummary { set; get; }

        /// <summary>
        /// 用药目的 MedicationEnum
        /// </summary>
        [DisplayName("用药目的")]
        public string? Medication { set; get; }

        /// <summary>
        /// 病原菌 GermsEnum
        /// </summary>
        [DisplayName("病原菌")]
        public string? Pathogenicbacteria { set; get; }

        /// <summary>
        /// 治疗效果 HealingeffectEnum
        /// </summary>
        [DisplayName("治疗效果")]
        public string? Healingeffect { set; get; }

        /// <summary>
        /// 文本路径
        /// </summary>
        public string? TextUrl { set; get; }

        /// <summary>
        /// 感染
        /// </summary>
        [DisplayName("感染")]
        public List<PatientInfoExDiagnosisTable> PatientInfoExDiagnosisTable { set; get; }


       public string? SummaryOfCasesGuid { set; get; }



        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpDateTime { set; get; }


        /// <summary>
        /// 文章发布时间
        /// </summary>
        public DateTime? PublishedDate { get; set; }


        /// <summary>
        /// 报告标题
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        [StringLength(160)]
        public string? Title { get; set; }

        /// <summary>
        /// 报告内容
        /// </summary>
        public string? BodyContent { set; get; }


        /// <summary>
        /// 文章摘要，方便快速阅读
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        [StringLength(450)]
        public string? Description { get; set; }


        /// <summary>
        /// 是否是精选，高质量内容
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        ///  是否需要公开
        /// </summary>
        public bool Ispublic { get; set; }

        ///// <summary>
        ///// 文章类型。
        ///// </summary>
        //[Required(ErrorMessage = "必须填写")]
        //public string PostType { set; get; }


        /// <summary>
        /// 文章关键词
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        public string? keywordTag { set; get; }
    }
}