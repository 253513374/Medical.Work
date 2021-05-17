using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class PatientInfoExDiagnosisTable
    {


        /// <summary>
        /// 感染诊断
        /// </summary>
        [DisplayName("感染诊断")]
        public int ID { set; get; }
        /// <summary>
        /// 感染诊断
        /// </summary>
        [DisplayName("感染诊断")]
        public string AffectedDiagnosis { set; get; }

        /// <summary>
        /// 感染部位
        /// </summary>
        [DisplayName("感染部位")]
        public string Affectedarea { set; get; }
    }
}
