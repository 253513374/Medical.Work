using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPK
    {

        public int ID { set; get; }
        public string MedicalPKGuid { set; get; }
        public DateTime DateTime { set; get; }

        /// <summary>
        /// 首次给药日期（DATE，day）
        /// </summary>
        [Display(Name = "首次给药日期")]
        public DateTime Firstdate { set; get; }
        /// <summary>
        /// 负荷单次剂量（AMT，mg）
        /// </summary>
        [Display(Name = "负荷单次剂量mg")]
        public string AMTsingledose { set; get; }

        /// <summary>
        /// 负荷次数
        /// </summary>
        [Display(Name = "负荷次数")]
        public string AMTNum { set; get; }

        /// <summary>
        /// 维持给药剂量（AMT，mg）
        /// </summary>
        [Display(Name = "维持给药剂量mg")]
        public string Maintenancedose { set; get; }


        /// <summary>
        /// 溶媒名称
        /// </summary>
        [Display(Name = "溶媒名称")]
        public string Nameofsolvent { set; get; }

        /// <summary>
        /// 溶媒剂量（ml）
        /// </summary>
        [Display(Name = "溶媒剂量ml")]
        public string Solventdose { set; get; }

        /// <summary>
        /// 给药途径：po, ivgtt
        /// </summary>
        [Display(Name = "给药途径")]
        public DateTime Channelofdrug { set; get; }

        /// <summary>
        /// 停止给药日期（DATE，day）
        /// </summary>
        [Display(Name = "停止给药日期")]
        public DateTime stopdrugdate { set; get; }

        /// <summary>
        /// 停止给药时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "停止给药时间")]
        public DateTime stopdrugtime { set; get; }

        /// <summary>
        /// 采血前一天给药日期（DATE，day） 
        /// </summary>
        [Display(Name = "采血前一天给药日期")]
        public DateTime beforedrugdate { set; get; }
        /// <summary>
        /// 采血前一天上午给药时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "采血前一天上午给药时间")]
        public DateTime beforedrugtimePM { set; get; }

        /// <summary>
        /// 采血日期（DATE，day）
        /// </summary>
        [Display(Name = "采血日期")]
        public DateTime bloodcollectiondate { set; get; }
        /// <summary>
        /// 采血当日开始给药时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "采血当日开始给药时间")]
        public DateTime Startingtimeofdrug { set; get; }
        /// <summary>
        /// 采血当日输注时间（TIME，min）
        /// </summary>
        [Display(Name = "采血当日输注时间")]
        public DateTime Infusiontime { set; get; }

        /// <summary>
        /// 采血当日输注完时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "采血当日输注完时间")]
        public DateTime Infusiontimecomplete { set; get; }
        /// <summary>
        /// C1采血时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "C1采血时间")]
        public DateTime C1bloodcollectiontime{set;get;}
        /// <summary>
        /// C2采血时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "C2采血时间")]
        public DateTime C2bloodcollectiontime { set; get; }
        /// <summary>
        /// C3采血时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "C3采血时间")]
        public DateTime C3bloodcollectiontime { set; get; }
        /// <summary>
        /// C4采血时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "C4采血时间")]
        public DateTime C4bloodcollectiontime { set; get; }
        /// <summary>
        /// C5采血时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "C5采血时间")]
        public DateTime C5bloodcollectiontime { set; get; }


        /// <summary>
        /// C1血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
       [Display(Name = "C1血药浓度ug/ml，mg/ml")]
        public string C1dvi { set; get; }
        /// <summary>
        /// C2血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [Display(Name = "C2血药浓度ug/ml，mg/ml")]
        public string C2dvi { set; get; }
        /// <summary>
        /// C3血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [Display(Name = "C3血药浓度ug/ml，mg/ml")]
        public string C3dvi { set; get; }

        /// <summary>
        /// C4血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [Display(Name = "C4血药浓度ug/ml，mg/ml")]
        public string C4dvi { set; get; }

        /// <summary>
        /// C5血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [Display(Name = "C5血药浓度ug/ml，mg/ml")]
        public string C5dvi { set; get; }

        /// <summary>
        /// 单次透析日期（DATE，day） ：
        /// </summary>
        [Display(Name = "单次透析日期")]
        public DateTime Singledialysisdate { set; get; }



        /// <summary>
        /// 透析类型（CAPD；CRRT；腹透）
        /// </summary>
        [Display(Name = "透析类型")]
        public string Dialysistype { set; get; }

        /// <summary>
        /// 单次透析开始时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "单次透析开始时间")]
        public string Starttimeofsingledialysis { set; get; }

        /// <summary>
        /// 单次透析停止时间（TIME，hh:mm）
        /// </summary>
        [Display(Name = "单次透析停止时间")]
        public string Stoptimeofsingledialysis { set; get; }


        /// <summary>
        /// 单次透析时长（h）
        /// </summary>
        [Display(Name = "单次透析时长")]
        public string DurationofsingledialysisH { set; get; }


        /// <summary>
        /// 透析样本采样日期（DATE，day）：
        /// </summary>
        [Display(Name = "透析样本采样日期")]
        public DateTime dialysissamplesamplingdate { set; get; }


        /// <summary>
        /// 透析样本采样时间（TIME，hh:mm）： 
        /// </summary>
        [Display(Name = "透析样本采样时间")]
        public DateTime dialysissamplesamplingtime { set; get; }




        /// <summary>
        /// 透析样本类型: 透析前，透析后，废液 
        /// </summary>
        [Display(Name = "透析样本类型")]
        public string Typesofdialysissamples { set; get; }


        /// <summary>
        /// 透析样本浓度结果（ug/ml，mg/ml）：透析前，透析后，废液 
        /// </summary>
        [Display(Name = "透析样本浓度结果")]
        public string Dialysissampleconcentrationresults { set; get; }


        /// <summary>
        /// 移植情况（肾移植；肝移植；肺移植，干细胞移植………） 
        /// </summary>
        [Display(Name = "移植情况")]
        public string Transplantation { set; get; }

        /// <summary>
        /// 术后时间（指已有几年几月）： 
        /// </summary>
        [Display(Name = "术后时间")]
        public string Postoperativetime { set; get; }

    }
}
