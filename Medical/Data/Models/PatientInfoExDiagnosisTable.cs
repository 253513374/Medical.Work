using System.ComponentModel;

namespace Medical.Data.Models
{
    public class PatientInfoExDiagnosisTable
    {
        /// <summary>
        /// id
        /// </summary>
        [DisplayName("id")]
       // [AutoGenerateColumn(Ignore = true)]
        public int PatientInfoExDiagnosisTableID { set; get; }

     //   [AutoGenerateColumn(Ignore = true)]
        public int ID { set; get; }

        public SummaryOfCases Summaryofcases { set; get; }

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