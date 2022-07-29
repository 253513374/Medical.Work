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
        public string Summaryreportclass { set; get; }

        /// <summary>
        /// 检查日期
        /// </summary>
        [DisplayName("药学记录日期")]
        public DateTime Notesdate { set; get; }

        /// <summary>
        /// 临床症状
        /// </summary>
        [DisplayName("临床症状")]
        public string Clinicalsymptoms { set; get; }

        /// <summary>
        /// 治疗方案
        /// </summary>
        [DisplayName("治疗方案")]
        public string Treatmentplan { set; get; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpDateTime { set; get; }

        
        /// <summary>
        /// 文章发布时间
        /// </summary>
        public DateTime PublishedDate { get; set; }


        /// <summary>
        /// 报告标题
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        [StringLength(160)]
        public string Title { get; set; }
        
        /// <summary>
        /// 报告内容
        /// </summary>
        public string BodyContent { set; get; }


        /// <summary>
        /// 文章摘要，方便快速阅读
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        [StringLength(450)]
        public string Description { get; set; }


        /// <summary>
        /// 是否是精选，高质量内容
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        ///  是否需要公开
        /// </summary>
        public bool Ispublic { get; set; }

        /// <summary>
        /// 文章类型。
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        public string PostType { set; get; }


        /// <summary>
        /// 文章关键词
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        public string keywordTag { set; get; }



        ///// <summary>
        ///// 文章中用到的文件(插图)路径,
        ///// </summary>
        //public string FilesPath { set; get; }

    }
}