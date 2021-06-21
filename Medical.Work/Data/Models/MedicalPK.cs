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
        [DisplayName("自增")]
        public int ID { set; get; }

        /// <summary>
        /// 管理员账号
        /// </summary>
        [DisplayName("管理员账号")]
        public string AdminName { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateTime { set; get; }

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

    }
}
