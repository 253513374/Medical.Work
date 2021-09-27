using BootstrapBlazor.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{

    /// <summary>
    /// 病原菌基因
    /// </summary>
    public class MedicalPG_PathogenGene : BaseDataInterface
    {
    


   

        /// <summary>
        /// 致病菌名称：
        /// </summary>
        [DisplayName("致病菌名称")]
        public string PathogenName { set; get; }

        /// <summary>
        /// 致病菌菌体基因名：
        /// </summary>
        [DisplayName("致病菌菌体基因名")]
        public string PathogenicGeneName { set; get; }


        /// <summary>
        /// 致病菌菌体基因检测结果 
        /// </summary>
        [DisplayName("致病菌菌体基因检测结果")]
        public string PathogenicGeneDetectionResults { set; get; }

        /// <summary>
        /// 意义
        /// </summary>
        [DisplayName("意义")]
        public string Exegesis { set; get; }
    }
}
