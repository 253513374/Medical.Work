using Medical.Work.Data.Enum;
using Microsoft.Extensions.Hosting;
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



        public int MedicalPKSamplingID { set; get; }

        public int MedicalPKID { set; get; }
        public MedicalPK medicalPK {set;get; } 

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// 标本类型
        /// </summary>
        [DisplayName("标本类型")]
        public SpecimenTypeEnum SpecimenType { set; get; }

        /// <summary>
        /// 采集时间
        /// </summary>
        [DisplayName("采集时间")]
        public DateTime CollectDateTime { set; get; }
        /// <summary>
        ///采血当日开始给药时间
        /// </summary>
        [DisplayName("采血当日开始给药时间")]
        public DateTime StartDateTime { set; get; }
        /// <summary>
        /// 采血当日输注完时间
        /// </summary>
        [DisplayName("采血当日输注完时间")]
        public DateTime EndDateTime { set; get; }

        /// <summary>
        /// 采血前最后一次给药时间
        /// </summary>
        [DisplayName("采血前最后一次给药时间")]
        public DateTime LastDateTime { set; get; }

        /// <summary>
        /// 采血管
        /// </summary>
        [DisplayName("采血管")]
        public CollectingVesselEnum Collectingvessel { set; get; }



        /// <summary>
        /// 采血样品详细信息
        /// </summary>
        public  List<MedicalPKSampling_sample>  medicalPKSamplings { get; set; }


    }
}
