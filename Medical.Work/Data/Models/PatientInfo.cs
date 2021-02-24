using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class PatientInfo
    {

        public int ID { set; get; }
        public string PatientInfoGuid { set; get; }
        public DateTime DateTime { set; get; }

       
        //病历号
        public string Medicalrecordnumber { set; get; }
        //科室
        public string Department { set; get; }

        //姓名
        public string Name { set; get; }
        //格拉斯哥评分（GCS）
        public string GCS { set; get; }
        //SOFA评分
        public string SOFA { set; get; }
        //诊断
        public string Diagnosis { set; get; }
        //APACHEⅡ评分
        public string APACHEⅡ { set; get; }
        //性别（男性记为0，女性记为1）
        public string Gender { set; get; }
        //年龄（AGE，year）
        public string AGE { set; get; }
        //体重（BW，kg）
        public string BW { set; get; }
        //身高（HEI，cm）
        public string HEI { set; get; }
        //体表面积（BSA，m2）：有计算公式，S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）；S男=0.0057×身高+0.0121×体重+0.0882，S女=0.0073×身高+0.0127×体重-0.2106，若不区别男和女，为中国人适用的通式为S=0.0061×身高+0.0124×体重-0.0099。（S示体表面积，单位：m2；H示身高，单位：cm；W 示体重，单位：kg）

        public string BSA { set; get; }
        //病史概要：   此处文字录入
        public string Medicalhistorysummary { set; get; }

    }
}
