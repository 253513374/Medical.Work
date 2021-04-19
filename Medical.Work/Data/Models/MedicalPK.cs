using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPK
    {
        /// <summary>
        /// 自增
        /// </summary>
        [DisplayName( "自增")]
        public int ID { set; get; }

        /// <summary>
        /// 唯一编码
        /// </summary>
        [DisplayName( "唯一编码")]
        public string MedicalPKGuid { set; get; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间")]
        public DateTime DateTime { set; get; }

        /// <summary>
        /// 首次给药日期（DATE，day）
        /// </summary>
        [DisplayName( "首次给药日期")]
        public DateTime Firstdate { set; get; }
        /// <summary>
        /// 负荷单次剂量（AMT，mg）
        /// </summary>
        [DisplayName( "负荷单次剂量mg")]
        public string AMTsingledose { set; get; }

        /// <summary>
        /// 负荷次数
        /// </summary>
        [DisplayName( "负荷次数")]
        public string AMTNum { set; get; }

        /// <summary>
        /// 维持给药剂量（AMT，mg）
        /// </summary>
        [DisplayName( "维持给药剂量mg")]
        public string Maintenancedose { set; get; }


        /// <summary>
        /// 溶媒名称
        /// </summary>
        [DisplayName( "溶媒名称")]
        public string Nameofsolvent { set; get; }

        /// <summary>
        /// 溶媒剂量（ml）
        /// </summary>
        [DisplayName( "溶媒剂量ml")]
        public string Solventdose { set; get; }

        /// <summary>
        /// 给药途径：po, ivgtt
        /// </summary>
        [DisplayName( "给药途径")]
        public DateTime Channelofdrug { set; get; }

        /// <summary>
        /// 停止给药日期（DATE，day）
        /// </summary>
        [DisplayName( "停止给药日期")]
        public DateTime stopdrugdate { set; get; }

        /// <summary>
        /// 停止给药时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "停止给药时间")]
        public DateTime stopdrugtime { set; get; }

        /// <summary>
        /// 采血前一天给药日期（DATE，day） 
        /// </summary>
        [DisplayName( "采血前一天给药日期")]
        public DateTime beforedrugdate { set; get; }
        /// <summary>
        /// 采血前一天上午给药时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "采血前一天上午给药时间")]
        public DateTime beforedrugtimePM { set; get; }

        /// <summary>
        /// 采血日期（DATE，day）
        /// </summary>
        [DisplayName( "采血日期")]
        public DateTime bloodcollectiondate { set; get; }
        /// <summary>
        /// 采血当日开始给药时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "采血当日开始给药时间")]
        public DateTime Startingtimeofdrug { set; get; }
        /// <summary>
        /// 采血当日输注时间（TIME，min）
        /// </summary>
        [DisplayName( "采血当日输注时间")]
        public DateTime Infusiontime { set; get; }

        /// <summary>
        /// 采血当日输注完时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "采血当日输注完时间")]
        public DateTime Infusiontimecomplete { set; get; }
        /// <summary>
        /// C1采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "C1采血时间")]
        public DateTime C1bloodcollectiontime{set;get;}
        /// <summary>
        /// C2采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "C2采血时间")]
        public DateTime C2bloodcollectiontime { set; get; }
        /// <summary>
        /// C3采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "C3采血时间")]
        public DateTime C3bloodcollectiontime { set; get; }
        /// <summary>
        /// C4采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "C4采血时间")]
        public DateTime C4bloodcollectiontime { set; get; }
        /// <summary>
        /// C5采血时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "C5采血时间")]
        public DateTime C5bloodcollectiontime { set; get; }


        /// <summary>
        /// C1血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
       [DisplayName( "C1血药浓度ug/ml，mg/ml")]
        public string C1dvi { set; get; }
        /// <summary>
        /// C2血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [DisplayName( "C2血药浓度ug/ml，mg/ml")]
        public string C2dvi { set; get; }
        /// <summary>
        /// C3血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [DisplayName( "C3血药浓度ug/ml，mg/ml")]
        public string C3dvi { set; get; }

        /// <summary>
        /// C4血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [DisplayName( "C4血药浓度ug/ml，mg/ml")]
        public string C4dvi { set; get; }

        /// <summary>
        /// C5血药浓度（DVI）(单位：ug/ml，mg/ml)
        /// </summary>
        [DisplayName( "C5血药浓度ug/ml，mg/ml")]
        public string C5dvi { set; get; }

        /// <summary>
        /// 单次透析日期（DATE，day） ：
        /// </summary>
        [DisplayName( "单次透析日期")]
        public DateTime Singledialysisdate { set; get; }



        /// <summary>
        /// 透析类型（CAPD；CRRT；腹透）
        /// </summary>
        [DisplayName( "透析类型")]
        public string Dialysistype { set; get; }

        /// <summary>
        /// 单次透析开始时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "单次透析开始时间")]
        public string Starttimeofsingledialysis { set; get; }

        /// <summary>
        /// 单次透析停止时间（TIME，hh:mm）
        /// </summary>
        [DisplayName( "单次透析停止时间")]
        public string Stoptimeofsingledialysis { set; get; }


        /// <summary>
        /// 单次透析时长（h）
        /// </summary>
        [DisplayName( "单次透析时长")]
        public string DurationofsingledialysisH { set; get; }


        /// <summary>
        /// 透析样本采样日期（DATE，day）：
        /// </summary>
        [DisplayName( "透析样本采样日期")]
        public DateTime dialysissamplesamplingdate { set; get; }


        /// <summary>
        /// 透析样本采样时间（TIME，hh:mm）： 
        /// </summary>
        [DisplayName( "透析样本采样时间")]
        public DateTime dialysissamplesamplingtime { set; get; }




        /// <summary>
        /// 透析样本类型: 透析前，透析后，废液 
        /// </summary>
        [DisplayName( "透析样本类型")]
        public string Typesofdialysissamples { set; get; }


        /// <summary>
        /// 透析样本浓度结果（ug/ml，mg/ml）：透析前，透析后，废液 
        /// </summary>
        [DisplayName( "透析样本浓度结果")]
        public string Dialysissampleconcentrationresults { set; get; }


        /// <summary>
        /// 移植情况（肾移植；肝移植；肺移植，干细胞移植………） 
        /// </summary>
        [DisplayName( "移植情况")]
        public string Transplantation { set; get; }

        /// <summary>
        /// 术后时间（指已有几年几月）： 
        /// </summary>
        [DisplayName( "术后时间")]
        public string Postoperativetime { set; get; }


        /// <summary>
        /// 登陆用户名称
        /// </summary>
        [DisplayName( "账号")]
        public string Username { set; get; }

    }
}
