using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPK
    {


        public string MedicalPKGuid { set; get; }
        public DateTime DateTime { set; get; }

        /// <summary>
        /// 首次给药日期（DATE，day）
        /// </summary>
        public DateTime Firstdate { set; get; }
        /// <summary>
        /// 负荷单次剂量（AMT，mg）
        /// </summary>
        public string AMTsingledose { set; get; }

        /// <summary>
        /// 负荷次数
        /// </summary>
        public string AMTNum { set; get; }

        /// <summary>
        /// 维持给药剂量（AMT，mg）
        /// </summary>
        public string Maintenancedose { set; get; }


        /// <summary>
        /// 溶媒名称
        /// </summary>
        public string Nameofsolvent { set; get; }

        /// <summary>
        /// 溶媒剂量（ml）
        /// </summary>
        public string Solventdose { set; get; }

        /// <summary>
        /// 给药途径：po, ivgtt
        /// </summary>
        public DateTime Channelofdrug { set; get; }

        /// <summary>
        /// 停止给药日期（DATE，day）
        /// </summary>
        public DateTime stopdrugdate { set; get; }

        /// <summary>
        /// 停止给药时间（TIME，hh:mm）
        /// </summary>
        public DateTime stopdrugtime { set; get; }
       
        /// <summary>
        /// 采血前一天给药日期（DATE，day） 
        /// </summary>
        public DateTime beforedrugdate { set; get; }
        /// <summary>
        /// 采血前一天上午给药时间（TIME，hh:mm）
        /// </summary>
        public DateTime beforedrugtimePM { set; get; }

        /// <summary>
        /// 采血日期（DATE，day）
        /// </summary>
        public DateTime bloodcollectiondate { set; get; }
        /// <summary>
        /// 采血当日开始给药时间（TIME，hh:mm）
        /// </summary>
        public DateTime Startingtimeofdrug { set; get; }
        /// <summary>
        /// 采血当日输注时间（TIME，min）
        /// </summary>
        public DateTime Infusiontime { set; get; }

        /// <summary>
        /// 采血当日输注完时间（TIME，hh:mm）
        /// </summary>
        public DateTime Infusiontimecomplete { set; get; }
        /// <summary>
        /// C1采血时间（TIME，hh:mm）
        /// </summary>
        public DateTime C1bloodcollectiontime{set;get;}
        /// <summary>
        /// C2采血时间（TIME，hh:mm）
        /// </summary>
        public DateTime C2bloodcollectiontime { set; get; }
        /// <summary>
        /// C3采血时间（TIME，hh:mm）
        /// </summary>
        public DateTime C3bloodcollectiontime { set; get; }
        /// <summary>
        /// C4采血时间（TIME，hh:mm）
        /// </summary>
        public DateTime C4bloodcollectiontime { set; get; }
        /// <summary>
        /// C5采血时间（TIME，hh:mm）
        /// </summary>
        public DateTime C5bloodcollectiontime { set; get; }


        /// <summary>
        /// C1血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        public string C1dvi { set; get; }
        /// <summary>
        /// C2血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        public string C2dvi { set; get; }
        /// <summary>
        /// C3血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        public string C3dvi { set; get; }

        /// <summary>
        /// C4血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        public string C4dvi { set; get; }

        /// <summary>
        /// C5血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        public string C5dvi { set; get; }

        /// <summary>
        /// 单次透析日期（DATE，day） ：
        /// </summary>
        public DateTime Singledialysisdate { set; get; }



        /// <summary>
        /// 透析类型（CAPD；CRRT；腹透）
        /// </summary>

        public string Dialysistype { set; get; }

        /// <summary>
        /// 单次透析开始时间（TIME，hh:mm）
        /// </summary>
        public string Starttimeofsingledialysis { set; get; }
     
        /// <summary>
        /// 单次透析停止时间（TIME，hh:mm）
        /// </summary>
        public string Stoptimeofsingledialysis { set; get; }

       
        /// <summary>
        /// 单次透析时长（h）
        /// </summary>
        public string DurationofsingledialysisH { set; get; }

        
        /// <summary>
        /// 透析样本采样日期（DATE，day）：
        /// </summary>
        public DateTime dialysissamplesamplingdate { set; get; }

       
        /// <summary>
        /// 透析样本采样时间（TIME，hh:mm）： 
        /// </summary>
        public DateTime dialysissamplesamplingtime { set; get; }



       
        /// <summary>
        /// 透析样本类型: 透析前，透析后，废液 
        /// </summary>
        public string Typesofdialysissamples { set; get; }


        /// <summary>
        /// 透析样本浓度结果（ug/ml，mg/ml）：透析前，透析后，废液 
        /// </summary>
        public string Dialysissampleconcentrationresults { set; get; }


        /// <summary>
        /// 移植情况（肾移植；肝移植；肺移植，干细胞移植………） 
        /// </summary>
        public string Transplantation { set; get; }

        /// <summary>
        /// 术后时间（指已有几年几月）： 
        /// </summary>
        public string Postoperativetime { set; get; }

    }
}
