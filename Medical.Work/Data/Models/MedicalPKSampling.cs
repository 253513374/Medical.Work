using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{

    /// <summary>
    /// 采样信息
    /// </summary>
    public class MedicalPKSampling
    {
        /// <summary>
        /// 标本类型
        /// </summary>
       public SpecimenTypeEnum SpecimenType { set; get; }

        /// <summary>
        /// 采集时间
        /// </summary>
        public DateTime CollectDateTime { set; get; }
        /// <summary>
        ///采血当日开始给药时间
        /// </summary>
        public DateTime StartDateTime { set; get; }
        /// <summary>
        /// 采血当日输注完时间
        /// </summary>
        public DateTime EndDateTime { set; get; }

        /// <summary>
        /// 采血前最后一次给药时间
        /// </summary>
        public DateTime LastDateTime { set; get; }

        /// <summary>
        /// 采血管
        /// </summary>
        public CollectingVesselEnum Collectingvessel { set; get; }


        /// <summary>
        /// C1采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName("C1采血时间")]
        public DateTime C1bloodcollectiontime { set; get; }

        /// <summary>
        /// C1浓度
        /// </summary>
        public string C1Concentration { set; get; }

        /// <summary>
        /// C1浓度单位
        /// </summary>
        public string C1ConcentrationUnit { set; get; }

        /// <summary>
        /// C1标准化血药浓度
        /// </summary>
        public string C1ConcentrationStandard { set; get; }

        /// <summary>
        /// C1浓度方法
        /// </summary>
        public ConcentrationEnum C1ConcentrationMethod { set; get; }

        /// <summary>
        /// C1备注
        /// </summary>
        public string C1Remarks { set; get; }

    }
}
