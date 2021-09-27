using BootstrapBlazor.Components;
using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{

    /// <summary>
    /// 给药方案
    /// </summary>
    public class MedicalPK : BaseDataInterface
    {
        /*药品通用名，溶媒（如0.9% 氯化钠100ml）,单次剂量，给药频率，给药途径，开始时间，截止时间，公斤体质量日剂量，厂家类型*/


        [AutoGenerateColumn(Ignore = true)]
        public int MedicalPKID { set; get; }

        /// <summary>
        [AutoGenerateColumn(Ignore = true)]
        public string AdminName { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreateTime { set; get; }
        /// <summary>
        /// 病历号
        /// </summary>
        [NotNull]
        [DisplayName("病历号")]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [NotNull]
        [DisplayName("患者姓名")]
        public string UserName { set; get; }


        /// <summary>
        /// 方案名称(可选)
        /// </summary>
        [DisplayName("给药方案名称(可选)")]
        public string MedicalPKName { set; get; }

        /// <summary>
        /// 起始给药日期（DATE，day）
        /// </summary>
        [DisplayName( "起始给药日期")]
        public DateTime? FirstTime { set; get; }

        /// <summary>
        /// 结束给药日期（DATE，day）
        /// </summary>
        [DisplayName("结束给药日期")]
        public DateTime? LasttTime { set; get; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [DisplayName("药品通用名")]
        public string DrugsNmae { set; get; }


        /// <summary>
        /// 药品商品名
        /// </summary>
        [DisplayName("药品商品名")]
        [AutoGenerateColumn(Ignore = true)]
        public string DrugsNmae2 { set; get; }

        /// <summary>
        /// 药品规格
        /// </summary>
        [DisplayName("药品规格")]
        [AutoGenerateColumn(Ignore = true)]
        public string DrugSpecifications { set; get; }


        /// <summary>
        /// 厂家类型
        /// </summary>
        [DisplayName("厂家类型")]
        public ManufacturertypeEnum Manufacturertype { set; get; }


        /// <summary>
        /// 药品单次剂量
        /// </summary>
        [DisplayName("药品剂量")]
        public string Drugdosage { set; get; }

        /// <summary>
        /// 药品剂量单位
        /// </summary>
        [DisplayName("药品剂量单位")]
        [AutoGenerateColumn(Ignore = true)]
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
        public DrugNCountEnum DrugNCount { set; get; }
        /// <summary>
        /// 给药持续时间
        /// </summary>
        [DisplayName("给药持续时间")]
        [AutoGenerateColumn(Ignore = true)]
        public DrugNCountDurationEnum DrugNCountDuration { set; get; }

        /// <summary>
        ///  溶媒
        /// </summary>
        [DisplayName("溶媒")]
        public string DrugSolvent { set; get; }

        /// <summary>
        ///  溶媒剂量
        /// </summary>
        [DisplayName("溶媒剂量")]
        public string SolventToDosage { set; get; }



        /// <summary>
        /// 公斤体质量日剂量：      mg/kg
        /// </summary>
        [DisplayName("公斤体质量日剂量(mg·kg⁻¹·d⁻¹)")]
        public string AMTsingledose { set; get; }


        [AutoGenerateColumn(Ignore = true)]
        public List<MedicalPKSampling> MedicalPKSamplings { set; get; }
    }
}
