using BootstrapBlazor.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 药物基因组学
    /// </summary>
    public class MedicalPG_Pharmacogenomics
    {

        /// <summary>
        /// ID
        /// </summary>
        [DisplayName( "自增")]
        [AutoGenerateColumn(Ignore = true)]
        public int ID { set; get; }


        /// <summary>
        /// 维一编码
        /// </summary>
        [DisplayName( "维一编码")]
        [AutoGenerateColumn(Ignore = true)]
        public string MedicalPGGuid { set; get; }
        /// <summary>
        /// 管理员账户
        /// </summary>
        [DisplayName("管理员账户")]
        [AutoGenerateColumn(Ignore = true)]
        public string AdminName { set; get; }

        /// <summary>
        /// 创建时间 
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// 患者名称
        /// </summary>
        [DisplayName("患者名称")]
        public string UserName { set; get; }

        /// <summary>
        /// 病历号
        /// </summary>
        [DisplayName("病历号")]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 基因： 
        /// </summary>
        [DisplayName( "基因名")]
        public string Genes { set; get; }

        /// <summary>
        /// RS号：（一个基因对应唯一一个RS） 
        /// </summary>
        [DisplayName( "RS号")]
        public string Rs { set; get; }


        /// <summary>
        /// 基因结果： 
        /// </summary>
        [DisplayName( "基因结果")]
        public string GenesResults { set; get; }

        /// <summary>
        ///代谢类型;   必须由多个基因检测结果共同判断代谢类型；例如：CYP2C19*2检测结果为AA, CYP2C19*3检测结果为GG, CYP2C19*17检测结果为CC,那么这个患者代谢类型为：慢代谢型（PM）,如果缺少了任何一个检测值都不能判断。 
        /// </summary>
        [DisplayName( "代谢型")]
        public string Metabolictype { set; get; }

        /// <summary>
        /// 意义
        /// </summary>
        [DisplayName("意义")]
        public string Exegesis { set; get; }

      

    }
}
