using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{

    /// <summary>
    /// 给药方案
    /// </summary>
    public class MedicalPK
    {
        /// <summary>
        /// 自增
        /// </summary>
        public int ID { set; get; }

        /// <summary>
        /// 管理员账号
        /// </summary>
        public string AdminName { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime DateTime { set; get; }

        /// <summary>
        /// 首次给药日期（DATE，day）
        /// </summary>
        [DisplayName( "首次给药日期")]
        public DateTime FirstTime { set; get; }

        /// <summary>
        /// 首次给药日期（DATE，day）
        /// </summary>
        [DisplayName("首次给药日期")]
        public DateTime LasttTime { set; get; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [DisplayName("药品通用名")]
        public string DrugsNmae { set; get; }

        /// <summary>
        /// 药品商品名
        /// </summary>
        [DisplayName("药品商品名")]
        public string DrugsNmae2 { set; get; }

        /// <summary>
        /// 药品规格
        /// </summary>
        [DisplayName("药品规格")]
        public string DrugSpecifications { set; get; }


        /// <summary>
        /// 厂家类型
        /// </summary>
        [DisplayName("厂家类型")]
        public ManufacturertypeEnum Manufacturertype { set; get; }


       /// <summary>
       /// 单词剂量
       /// </summary>
        [DisplayName("药品剂量")]
        public string Drugdosage { set; get; }

        /// <summary>
        /// 单词剂量
        /// </summary>
        [DisplayName("药品剂量单位")]
        public WeightEnum DrugdosageUnit { set; get; }

        /// <summary>
        /// 给药途径
        /// </summary>
        [DisplayName("给药途径")]
        public string DrugdosageRoute { set; get; }

        /// <summary>
        /// 给药频率
        /// </summary>
        [DisplayName("给药频率")]
        public string DrugNCount { set; get; }



        /// <summary>
        /// 公斤体质量日剂量：      mg/kg
        /// </summary>
        [DisplayName("公斤体质量日剂量")]
        public string AMTsingledose { set; get; }

       // /// <summary>
       // /// 负荷次数
       // /// </summary>
       // [DisplayName( "负荷次数")]
       // public string AMTNum { set; get; }

       // /// <summary>
       // /// 维持给药剂量（AMT，mg）
       // /// </summary>
       // [DisplayName( "维持给药剂量mg")]
       // public string Maintenancedose { set; get; }


       // /// <summary>
       // /// 溶媒名称
       // /// </summary>
       // [DisplayName("溶媒名称")]
       // public string Nameofsolvent { set; get; }


       // /// <summary>
       // /// 溶媒剂量（ml）
       // /// </summary>
       // [DisplayName( "溶媒剂量ml")]
       // public string Solventdose { set; get; }

       // /// <summary>
       // /// 给药途径：po, ivgtt
       // /// </summary>
       // [DisplayName( "给药途径")]
       // public DateTime Channelofdrug { set; get; }



      


       // /// <summary>
       // /// 停止给药日期（DATE，day）
       // /// </summary>
       // [DisplayName( "停止给药日期")]
       // public DateTime stopdrugdate { set; get; }

       // /// <summary>
       // /// 停止给药时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "停止给药时间")]
       // public DateTime stopdrugtime { set; get; }

       // /// <summary>
       // /// 采血前一天给药日期（DATE，day） 
       // /// </summary>
       // [DisplayName( "采血前一天给药日期")]
       // public DateTime beforedrugdate { set; get; }
       // /// <summary>
       // /// 采血前一天上午给药时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "采血前一天上午给药时间")]
       // public DateTime beforedrugtimePM { set; get; }

       // /// <summary>
       // /// 采血日期（DATE，day）
       // /// </summary>
       // [DisplayName( "采血日期")]
       // public DateTime bloodcollectiondate { set; get; }
       // /// <summary>
       // /// 采血当日开始给药时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "采血当日开始给药时间")]
       // public DateTime Startingtimeofdrug { set; get; }
       // /// <summary>
       // /// 采血当日输注时间（TIME，min）
       // /// </summary>
       // [DisplayName( "采血当日输注时间")]
       // public DateTime Infusiontime { set; get; }

       // /// <summary>
       // /// 采血当日输注完时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "采血当日输注完时间")]
       // public DateTime Infusiontimecomplete { set; get; }
       // /// <summary>
       // /// C1采血时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "C1采血时间")]
       // public DateTime C1bloodcollectiontime{set;get;}
       // /// <summary>
       // /// C2采血时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "C2采血时间")]
       // public DateTime C2bloodcollectiontime { set; get; }
       // /// <summary>
       // /// C3采血时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "C3采血时间")]
       // public DateTime C3bloodcollectiontime { set; get; }
       // /// <summary>
       // /// C4采血时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "C4采血时间")]
       // public DateTime C4bloodcollectiontime { set; get; }
       // /// <summary>
       // /// C5采血时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "C5采血时间")]
       // public DateTime C5bloodcollectiontime { set; get; }


       // /// <summary>
       // /// C1血药浓度（DVI）(单位：ug/ml，mg/ml)
       // /// </summary>
       //[DisplayName( "C1血药浓度ug/ml，mg/ml")]
       // public string C1dvi { set; get; }
       // /// <summary>
       // /// C2血药浓度（DVI）(单位：ug/ml，mg/ml)
       // /// </summary>
       // [DisplayName( "C2血药浓度ug/ml，mg/ml")]
       // public string C2dvi { set; get; }
       // /// <summary>
       // /// C3血药浓度（DVI）(单位：ug/ml，mg/ml)
       // /// </summary>
       // [DisplayName( "C3血药浓度ug/ml，mg/ml")]
       // public string C3dvi { set; get; }

       // /// <summary>
       // /// C4血药浓度（DVI）(单位：ug/ml，mg/ml)
       // /// </summary>
       // [DisplayName( "C4血药浓度ug/ml，mg/ml")]
       // public string C4dvi { set; get; }

       // /// <summary>
       // /// C5血药浓度（DVI）(单位：ug/ml，mg/ml)
       // /// </summary>
       // [DisplayName( "C5血药浓度ug/ml，mg/ml")]
       // public string C5dvi { set; get; }

       // /// <summary>
       // /// 单次透析日期（DATE，day） ：
       // /// </summary>
       // [DisplayName( "单次透析日期")]
       // public DateTime Singledialysisdate { set; get; }



       // /// <summary>
       // /// 透析类型（CAPD；CRRT；腹透）
       // /// </summary>
       // [DisplayName( "透析类型")]
       // public string Dialysistype { set; get; }

       // /// <summary>
       // /// 单次透析开始时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "单次透析开始时间")]
       // public string Starttimeofsingledialysis { set; get; }

       // /// <summary>
       // /// 单次透析停止时间（TIME，hh:mm）
       // /// </summary>
       // [DisplayName( "单次透析停止时间")]
       // public string Stoptimeofsingledialysis { set; get; }


       // /// <summary>
       // /// 单次透析时长（h）
       // /// </summary>
       // [DisplayName( "单次透析时长")]
       // public string DurationofsingledialysisH { set; get; }


       // /// <summary>
       // /// 透析样本采样日期（DATE，day）：
       // /// </summary>
       // [DisplayName( "透析样本采样日期")]
       // public DateTime dialysissamplesamplingdate { set; get; }


       // /// <summary>
       // /// 透析样本采样时间（TIME，hh:mm）： 
       // /// </summary>
       // [DisplayName( "透析样本采样时间")]
       // public DateTime dialysissamplesamplingtime { set; get; }




       // /// <summary>
       // /// 透析样本类型: 透析前，透析后，废液 
       // /// </summary>
       // [DisplayName( "透析样本类型")]
       // public string Typesofdialysissamples { set; get; }


       // /// <summary>
       // /// 透析样本浓度结果（ug/ml，mg/ml）：透析前，透析后，废液 
       // /// </summary>
       // [DisplayName( "透析样本浓度结果")]
       // public string Dialysissampleconcentrationresults { set; get; }


       // /// <summary>
       // /// 移植情况（肾移植；肝移植；肺移植，干细胞移植………） 
       // /// </summary>
       // [DisplayName( "移植情况")]
       // public string Transplantation { set; get; }

       // /// <summary>
       // /// 术后时间（指已有几年几月）： 
       // /// </summary>
       // [DisplayName( "术后时间")]
       // public string Postoperativetime { set; get; }


      

    }
}
