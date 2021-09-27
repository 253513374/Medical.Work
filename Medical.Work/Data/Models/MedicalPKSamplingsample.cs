using BootstrapBlazor.Components;
using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPKSamplingsample
    {

        [AutoGenerateColumn(Ignore = true)]
        public int MedicalPKSampling_sampleID { set; get; }



        [AutoGenerateColumn(Ignore = true)]
        public int ID { get; set; }

        [AutoGenerateColumn(Ignore = true)]
        public MedicalPKSampling medicalPKSampling { get; set; }

        /// <summary>
        /// 样品编号
        /// </summary>
        [DisplayName("采样点")]
        public string SamplingNumber { get; set; }
        /// <summary>
        /// 样品编号
        /// </summary>
        [DisplayName("编号")]
        public string Number { get; set; }
        /// <summary>
        /// 抽血护士
        /// </summary>
        [DisplayName("抽血护士")]
        public string Samplingname { get; set; }

        /// <summary>
        /// C1采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName("采血时间")]
        public DateTime C1bloodcollectiontime { set; get; }

        /// <summary>
        /// C1浓度
        /// </summary>
        [DisplayName("浓度")]
        public string C1Concentration { set; get; }

        /// <summary>
        /// C1浓度单位
        /// </summary>
        [DisplayName("浓度单位")]
        public WeightEnum C1ConcentrationUnit { set; get; } = WeightEnum.mg;

        /// <summary>
        /// C1标准化血药浓度
        /// </summary>
        [DisplayName("标准化血药浓度")]
        public string C1ConcentrationStandard { set; get; }

        /// <summary>
        /// C1浓度方法
        /// </summary>
        [DisplayName("浓度方法")]
        public ConcentrationEnum? C1ConcentrationMethod { set; get; }


        /// <summary>
        /// 其他
        /// </summary>
        [DisplayName("其他")]
        public string Other { set; get; }
        /// <summary>
        /// C1备注
        /// </summary>
        [DisplayName("备注")]
        public string C1Remarks { set; get; }
    }
}
