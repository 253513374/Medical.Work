using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Xml.Linq;
using BootstrapBlazor.Components;

namespace Medical.Work.Data.Models
{
    public class PatientInfo
    {
        public PatientInfo() { }
        public int ID { set; get; }
        public string PatientInfoGuid { set; get; }
        public DateTime DateTime { set; get; }

        public string username {set;get; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Display(Name = "姓名")]
        public string Name { set; get; }

        /// <summary>
        /// 病历号
        /// </summary>
        [Display(Name = "病历号")]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 科室
        /// </summary>
        [Display(Name = "科室")]
        public string Department { set; get; }

        /// <summary>
        /// 性别（男性记为0，女性记为1）
        /// </summary>
        [Display(Name = "性别")]
        public string Gender { set; get; }

        /// <summary>
        /// 年龄（AGE，year）
        /// </summary>
        [Display(Name = "年龄")]
        public string AGE { set; get; }

        /// <summary>
        /// 体重（BW，kg）
        /// </summary>
        [Display(Name = "体重kg")]
        public string BW { set; get; }

        /// <summary>
        /// 身高（HEI，cm）
        /// </summary>
        [Display(Name = "身高cm")]
        public string HEI { set; get; }

        /// <summary>
        /// 体表面积（BSA，m2）：有计算公式，S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）；S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）
        /// </summary>
        [Display(Name = "体表面积m2")]
        public string BSA { set; get; }

        /// <summary>
        /// 祖籍：***省份
        /// </summary>
        [Display(Name = "祖籍")]
        public string Ancestralhome { set; get; }

        /// <summary>
        /// 民族： 
        /// </summary>
        [Display(Name = "民族")]
        public string Nationality { set; get; }

        /// <summary>
        /// 格拉斯哥评分（GCS）
        /// </summary>
        [Display(Name = "格拉斯哥评分(GCS)")]
        public string GCS { set; get; }
       
        /// <summary>
        /// SOFA评分
        /// </summary>
        [Display(Name = "SOFA评分")]
        public string SOFA { set; get; }

        /// <summary>
        /// 诊断
        /// </summary>
        [Display(Name = "诊断")]
        public string Diagnosis { set; get; }

        /// <summary>
        /// APACHEⅡ评分
        /// </summary>
        [Display(Name = "APACHEⅡ评分")]
        public string APACHEⅡ { set; get; }


       
       
       

        /// <summary>
        /// 病史概要
        /// </summary>
        [Display(Name = "病史概要")]
        public string Medicalhistorysummary { set; get; }

    }
}
