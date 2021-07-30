using BootstrapBlazor.Components;
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
        /// id
        /// </summary>
        [DisplayName("id")]
        [AutoGenerateColumn(Ignore = true)]
        public int PatientInfoExDiagnosisTableID { set; get; }

        [AutoGenerateColumn(Ignore = true)]
        public int PatientInfoID { set; get; }

        public PatientInfo Patient { set; get; }
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
