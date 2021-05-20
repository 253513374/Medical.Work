using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Xml.Linq;
using BootstrapBlazor.Components;
using Medical.Work.Data.Enum;

namespace Medical.Work.Data.Models
{
    public class PatientInfo
    {
        public PatientInfo() { }
        [DisplayName("ID")]
        public int ID { set; get; }

        [DisplayName("唯一编码")]
        public string PatientInfoGuid { set; get; }

        [DisplayName("建立时间")]
        public DateTime DateTime { set; get; }


        [DisplayName("建立账号")]
        public string Adminuser {set;get; }


        /// <summary>
        /// 病历号
        /// </summary>
        [DisplayName("病历号")]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName( "患者姓名")]
        public string Name { set; get; }

        /// <summary>
        /// 科室
        /// </summary>
        [DisplayName( "科室")]
        public string Department { set; get; }

        /// <summary>
        /// 性别（男性记为0，女性记为1）
        /// </summary>
        [DisplayName( "性别")]
        public SexEnum Gender { set; get; }

        /// <summary>
        /// 年龄（AGE，year）
        /// </summary>
        [DisplayName( "年龄")]
        public DateTime AGE { set; get; }

        /// <summary>
        /// 体重（BW，kg）
        /// </summary>
        [DisplayName( "体重kg")]
        public int BW { set; get; }

        /// <summary>
        /// 身高（HEI，cm）
        /// </summary>
        [DisplayName( "身高cm")]
        public int HEI { set; get; }
        /// <summary>
        /// 根据身高、体重录入后，系统自动生成，计算通式为:体重/身高2  ,身高，单位:cm；体重，单位：kg) 
        /// </summary>
        [DisplayName("BMI")]
        public string BMI { set; get; }

        /// <summary>
        /// 体表面积（BSA，m2）：有计算公式，S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）；S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）
        /// </summary>
        [DisplayName( "体表面积m2")]
        public string BSA { set; get; }


        /// <summary>
        /// 移植类型
        /// </summary>
        [DisplayName("移植类型")]
        public TransplantationEnum Transplantationtype { set; get; }


        /// <summary>
        /// 移植手术时间
        /// </summary>
        [DisplayName("移植手术时间")]
        public DateTime Transplantationtime { set; get; }

        /// <summary>
        /// 祖籍：***省份
        /// </summary>
        [DisplayName( "祖籍")]
        public string Ancestralhome { set; get; }

        /// <summary>
        /// 民族： 
        /// </summary>
        [DisplayName( "民族")]
        public string Nationality { set; get; }

        /// <summary>
        /// 格拉斯哥评分（GCS）
        /// </summary>
        [DisplayName("格拉斯哥评分(GCS)")]
        public string GCS { set; get; }
       
        /// <summary>
        /// SOFA评分
        /// </summary>
        [DisplayName( "SOFA评分")]
        public string SOFA { set; get; }

        /// <summary>
        /// 入科APACHEⅡ评分
        /// </summary>
        [DisplayName("入科APACHEⅡ评分")]
        public string APACHEⅡ { set; get; }


        /// <summary>
        /// 感染
        /// </summary>
        [DisplayName("感染")]
        public List<PatientInfoExDiagnosisTable> PatientInfoExDiagnosisTable { set; get; }

        ///// <summary>
        ///// 感染部位
        ///// </summary>
        //[DisplayName("感染部位")]
        //public string Affectedarea { set; get; }

        /// <summary>
        /// 入院时间
        /// </summary>
        [DisplayName("入院时间")]
        public DateTime Admissiontime { set; get; }

        /// <summary>
        /// 出院时间
        /// </summary>
        [DisplayName("出院时间")]
        public DateTime Dischargetime { set; get; }


      

        /// <summary>
        /// 病史概要
        /// </summary>
        [DisplayName( "病史概要")]
        public string Medicalhistorysummary { set; get; }


        /// <summary>
        /// 用药目的
        /// </summary>
        [DisplayName("用药目的")]
        public MedicationEnum Medication { set; get; }
        /// <summary>
        /// 病原菌
        /// </summary>
        [DisplayName("病原菌")]
        public GermsEnum Pathogenicbacteria { set; get; }
        /// <summary>
        /// 治疗效果
        /// </summary>
        [DisplayName("治疗效果")]
        public HealingeffectEnum Healingeffect { set; get; }



    }
}
