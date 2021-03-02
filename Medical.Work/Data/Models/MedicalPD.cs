using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPD
    {

        public int ID { set; get; }
        public string MedicalPDGuid { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime DateTime { set; get; }
        /// <summary>
        ///  送检时间
        /// </summary>
        [Display(Name = "送检时间")]
        public DateTime Inspectiontime { set; get; }


        /// <summary>
        /// 标本类型（血液，痰，肺泡灌洗液，尿液，导管血，脑脊液……）
        /// </summary>
        [Display(Name = "标本类型")]
        public string Typeofspecimen { set; get; }

        /// <summary>
        /// 报告时间
        /// </summary>
        [Display(Name = "报告时间")]
        public DateTime Reporttime { set; get; }
        /// <summary>
        /// MIC: 伏立康唑，氟康唑，卡泊芬净，两性霉素B，美罗培南，亚胺培南，头孢他啶，复方磺胺甲噁唑，头孢哌酮舒巴坦钠，头孢哌酮他唑巴坦，哌拉西林他唑巴坦，替加环素，达托霉素……..
        /// </summary>
        [Display(Name = "MIC")]
        public string MIC { set; get; }
        /// <summary>
        /// NGS信息：
        /// </summary>
        [Display(Name = "NGS信息")]
        public string NGSinformation { set; get; }
       

    }
}
