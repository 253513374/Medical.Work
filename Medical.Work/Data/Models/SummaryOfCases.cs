using Medical.Work.Data.Enum;
using System.Collections.Generic;
using System.ComponentModel;

namespace Medical.Work.Data.Models
{
    public class SummaryOfCases : BaseDataInterface
    {
        /// <summary>
        /// 病史概要
        /// </summary>
        [DisplayName("病史概要")]
        public string Medicalhistorysummary { set; get; }

        /// <summary>
        /// 用药目的
        /// </summary>
        [DisplayName("用药目的")]
        public MedicationEnum? Medication { set; get; }

        /// <summary>
        /// 病原菌
        /// </summary>
        [DisplayName("病原菌")]
        public GermsEnum? Pathogenicbacteria { set; get; }

        /// <summary>
        /// 治疗效果
        /// </summary>
        [DisplayName("治疗效果")]
        public HealingeffectEnum? Healingeffect { set; get; }

        /// <summary>
        /// 文本路径
        /// </summary>
        public string TextUrl { set; get; }

        /// <summary>
        /// 感染
        /// </summary>
        [DisplayName("感染")]
        public List<PatientInfoExDiagnosisTable> PatientInfoExDiagnosisTable { set; get; }
    }
}