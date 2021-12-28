using System.ComponentModel;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 药物基因组学
    /// </summary>
    public class MedicalPG_Pharmacogenomics : BaseDataInterface
    {
        /// <summary>
        /// 基因：
        /// </summary>
        [DisplayName("基因名")]
        public string Genes { set; get; }

        /// <summary>
        /// RS号：（一个基因对应唯一一个RS）
        /// </summary>
        [DisplayName("RS号")]
        public string Rs { set; get; }

        /// <summary>
        /// 基因结果：
        /// </summary>
        [DisplayName("基因结果")]
        public string GenesResults { set; get; }

        /// <summary>
        ///代谢类型;   必须由多个基因检测结果共同判断代谢类型；例如：CYP2C19*2检测结果为AA, CYP2C19*3检测结果为GG, CYP2C19*17检测结果为CC,那么这个患者代谢类型为：慢代谢型（PM）,如果缺少了任何一个检测值都不能判断。
        /// </summary>
        [DisplayName("代谢型")]
        public string Metabolictype { set; get; }

        /// <summary>
        /// 意义
        /// </summary>
        [DisplayName("意义")]
        public string Exegesis { set; get; }
    }
}