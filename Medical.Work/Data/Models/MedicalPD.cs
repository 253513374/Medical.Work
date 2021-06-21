using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPD
    {

        /// <summary>
        /// 自增
        /// </summary>
        [DisplayName("自增")]
        public int ID { set; get; }


        ///// <summary>
        ///// 唯一编码
        ///// </summary>
        //[DisplayName("唯一编码")]
        //public string MedicalPDGuid { set; get; }

        /// <summary>
        /// 登陆用户名称
        /// </summary>
        [DisplayName("账号")]
        public string Adminname { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// 结果
        /// </summary>
        [DisplayName("是否测试")]
        public TestorNotEnum TestorNot { set; get; }

        /// <summary>
        /// 测试日期
        /// </summary>
        [DisplayName("测试日期")]
        public DateTime TestTime { set; get; }

        /// <summary>
        ///  送检时间
        /// </summary>
        [DisplayName(  "送检日期")]
        public DateTime Inspectiontime { set; get; }


        /// <summary>
        /// 标本类型（血液，痰，肺泡灌洗液，尿液，导管血，脑脊液……）
        /// </summary>
        [DisplayName( "标本类型")]
        public SpecimenTypeEnum SpecimenType { set; get; }



        /// <summary>
        /// 报告时间
        /// </summary>
        [DisplayName(  "报告时间")]
        public DateTime Reporttime { set; get; }


        /// <summary>
        /// 药敏检测方法
        /// </summary>
        [DisplayName("药敏检测方法")]
        public DrugsensitivityEnum DrugsensitivityTest { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName("药品名称")]
        public string Drugsname { set; get; }
        /// <summary>
        /// MIC: 伏立康唑，氟康唑，卡泊芬净，两性霉素B，美罗培南，亚胺培南，头孢他啶，复方磺胺甲噁唑，头孢哌酮舒巴坦钠，头孢哌酮他唑巴坦，哌拉西林他唑巴坦，替加环素，达托霉素……..
        /// </summary>
        [DisplayName("MIC")]
        public string MIC { set; get; }

        /// <summary>
        /// 敏感性
        /// </summary>
        [DisplayName("敏感性")]
        public SusceptibilityEnum Susceptibility { set; get; }
        ///// <summary>
        ///// NGS信息：
        ///// </summary>
        //[DisplayName("NGS信息")]
        //public string NGSinformation { set; get; }


      
       

    }
}
