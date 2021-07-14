using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{

    /// <summary>
    /// 病原菌基因
    /// </summary>
    public class MedicalPG_PathogenGene
    {
        /// <summary>
        /// ID
        /// </summary>
        [DisplayName("自增")]
        public int ID { set; get; }


        /// <summary>
        /// 维一编码
        /// </summary>
        [DisplayName("维一编码")]
        public string MedicalPGGuid { set; get; }
        /// <summary>
        /// 管理员账户
        /// </summary>
        [DisplayName("管理员账户")]
        public string Adminname { set; get; }

        /// <summary>
        /// 创建时间 
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// 患者名称
        /// </summary>
        [DisplayName("患者名称")]
        public string Username { set; get; }

        /// <summary>
        /// 病历号
        /// </summary>
        [DisplayName("病历号")]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 致病菌名称：
        /// </summary>
        [DisplayName("致病菌名称")]
        public string PathogenName { set; get; }

        /// <summary>
        /// 致病菌菌体基因名：
        /// </summary>
        [DisplayName("致病菌菌体基因名")]
        public string PathogenicGeneName { set; get; }


        /// <summary>
        /// 致病菌菌体基因检测结果 
        /// </summary>
        [DisplayName("致病菌菌体基因检测结果")]
        public string PathogenicGeneDetectionResults { set; get; }

        /// <summary>
        /// 意义
        /// </summary>
        [DisplayName("意义")]
        public string Exegesis { set; get; }
    }
}
