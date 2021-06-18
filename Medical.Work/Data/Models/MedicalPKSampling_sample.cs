using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPKSampling_sample
    {

       
        public int MedicalPKSampling_sampleID { set; get; }

        public int MedicalPKSamplingID { get; set; }
        public MedicalPKSampling medicalPKSampling { get; set; }

        /// <summary>
        /// 样品编号
        /// </summary>
        [DisplayName("样品编号")]
        public string SamplingNumber { get; set; }

        /// <summary>
        /// C1采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName("C1采血时间")]
        public DateTime C1bloodcollectiontime { set; get; }

        /// <summary>
        /// C1浓度
        /// </summary>
        [DisplayName("C1浓度")]
        public string C1Concentration { set; get; }

        /// <summary>
        /// C1浓度单位
        /// </summary>
        [DisplayName("C1浓度单位")]
        public string C1ConcentrationUnit { set; get; }

        /// <summary>
        /// C1标准化血药浓度
        /// </summary>
        [DisplayName("C1标准化血药浓度")]
        public string C1ConcentrationStandard { set; get; }

        /// <summary>
        /// C1浓度方法
        /// </summary>
        [DisplayName("C1浓度方法")]
        public ConcentrationEnum C1ConcentrationMethod { set; get; }

        /// <summary>
        /// C1备注
        /// </summary>
        [DisplayName("C1备注")]
        public string C1Remarks { set; get; }
    }
}
