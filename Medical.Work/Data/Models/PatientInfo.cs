using Medical.Work.Data.Enum;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medical.Work.Data.Models
{
    public class PatientInfo : BaseDataInterface
    {
        /// <summary>
        /// 科室
        /// </summary>
        [DisplayName("科室")]
        public string Department { set; get; }

        /// <summary>
        /// 性别（男性记为0，女性记为1）
        /// </summary>
        [DisplayName("性别")]
        public string Gender { set; get; }

        /// <summary>
        /// 年龄（AGE，year）
        /// </summary>

        [Display(Name = "年龄")]
        public int AGE { set; get; }

        /// <summary>
        /// 年龄（AGE，year）
        /// </summary>
        [Display(Name = "月")]
        public int MonthAGE { set; get; }

        /// <summary>
        /// 年龄（AGE，year）
        /// </summary>
        [Display(Name = "日")]
        public int DayAGE { set; get; }

        /// <summary>
        /// 体重（BW，kg）
        /// </summary>
        [DisplayName("体重")]
        public double BW { set; get; }

        /// <summary>
        /// 体重单位（BW，kg）WeightEnum
        /// </summary>
        [DisplayName("")]
        public string BWWeight { set; get; } = "kg";

        /// <summary>
        /// 体重测量方法（BW，kg）
        /// </summary>
        [DisplayName("体重测量方式")]
        public string IsBWType { set; get; }

        /// <summary>
        /// 身高（HEI，cm）
        /// </summary>
        [DisplayName("身高cm")]
        public int HEI { set; get; }

        /// <summary>
        /// 根据身高、体重录入后，系统自动生成，计算通式为:体重/身高2  ,身高，单位:cm；体重，单位：kg)
        /// </summary>
        [DisplayName("BMI")]
        public string BMI { set; get; }

        /// <summary>
        /// 体表面积（BSA，m2）：有计算公式，S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）；S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）
        /// </summary>
        [DisplayName("体表面积m2")]
        public string BSA { set; get; }

        /// <summary>
        /// 移植类型 TransplantationEnum
        /// </summary>
        [DisplayName("移植类型")]
        public string? Transplantationtype { set; get; }

        /// <summary>
        /// 移植手术时间
        /// </summary>
        [DisplayName("移植手术时间")]
        public DateTime? Transplantationtime { set; get; }

        /// <summary>
        /// 祖籍：***省份
        /// </summary>
        [DisplayName("祖籍")]
        public string Ancestralhome { set; get; }

        /// <summary>
        /// 民族：
        /// </summary>
        [DisplayName("民族")]
        public string Nationality { set; get; }

        /// <summary>
        /// 格拉斯哥评分（GCS）
        /// </summary>
        [DisplayName("格拉斯哥评分(GCS)")]
        public string GCS { set; get; }

        /// <summary>
        /// SOFA评分
        /// </summary>
        [DisplayName("SOFA评分")]
        public string SOFA { set; get; }

        /// <summary>
        /// 入科APACHEⅡ评分
        /// </summary>
        [DisplayName("入科APACHEⅡ评分")]
        public string APACHEⅡ { set; get; }

        /// <summary>
        /// 入院时间
        /// </summary>
        [DisplayName("入院时间")]
        public DateTime? Admissiontime { set; get; }

        /// <summary>
        /// 出院时间
        /// </summary>
        [DisplayName("出院时间")]
        public DateTime? Dischargetime { set; get; }
    }
}