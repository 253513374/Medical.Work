using System.ComponentModel;

namespace Medical.Data.Models
{
    /// <summary>
    /// 采样信息
    /// </summary>
    public class MedicalPKSampling : BaseDataInterface
    {
        /// <summary>
        /// 标本类型 SpecimenTypeEnum
        /// </summary>
        [DisplayName("标本类型")]
        public string? SpecimenType { set; get; }

        /// <summary>
        /// 采集时间
        /// </summary>
        [DisplayName("采集时间")]
        public DateTime? CollectDateTime { set; get; }

        /// <summary>
        ///采血当日开始给药时间
        /// </summary>
        [DisplayName("采血当日开始给药时间")]
        public DateTime? StartDateTime { set; get; }

        /// <summary>
        /// 采血当日输注完时间
        /// </summary>
        [DisplayName("采血当日输注完时间")]
        public DateTime? EndDateTime { set; get; }

        /// <summary>
        /// 采血前最后一次给药时间
        /// </summary>
        [DisplayName("采血前最后一次给药时间")]
        public DateTime? LastDateTime { set; get; }

        /// <summary>
        /// 采血管 CollectingVesselEnum
        /// </summary>
        [DisplayName("采血管")]
        public string? Collectingvessel { set; get; }

        /// <summary>
        /// 采血样品详细信息
        /// </summary>
        //[AutoGenerateColumn(Ignore = true)]
        public List<MedicalPKSamplingsample> medicalPKSamplings { get; set; }
    }
}