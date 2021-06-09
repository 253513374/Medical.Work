using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{

    /// <summary>
    /// 药学监护报告
    /// </summary>
    public class Summaryreport
    {


 
        public int ID { set; get; }

        public DateTime Cretetime { set; get; }


        /// <summary>
        /// 管理员账号
        /// </summary>
        public string Amdinname { set; get; }


        /// <summary>
        /// 患者名称
        /// </summary>
        public string Username { set; get; }

        /// <summary>
        /// 病历号
        /// </summary>
        [DisplayName("病历号")]
        public string Medicalrecordnumber { set; get; }

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
        
    }
}
