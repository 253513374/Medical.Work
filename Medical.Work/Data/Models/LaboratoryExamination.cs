using BootstrapBlazor.Components;
using Medical.Work.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    /// <summary>
    /// 实验室检查
    /// </summary>
    public class LaboratoryExamination
    {
        [AutoGenerateColumn(Ignore = true)]
        public int LaboratoryExaminationID { set; get; }
        [AutoGenerateColumn(Ignore = true)]
        public string AdminName{ set; get; }

        /// <summary>
        /// 病历号
        /// </summary>
        [NotNull]
        [DisplayName("病历号")]
        [AutoGenerateColumn(Ignore = true)]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [NotNull]
        [DisplayName("患者姓名")]
        [AutoGenerateColumn(Ignore = true)]
        public string UserName { set; get; }

        [DisplayName("唯一编码")]
        [AutoGenerateColumn(Ignore = true)]
        public string PatientInfoGuid { set; get; }

        [DisplayName("记录时间")]
        public DateTime Createtime { set; get; }


        /// <summary>
        /// 用药前  用药中  用药后
        /// </summary>
        [DisplayName("实验状态")]
        public AssaysituationEnum Assaysituation { set; get; }

        /// <summary>
        /// 检测时间
        /// </summary>
        [DisplayName("检测时间")]
        public DateTime Assaytime { set; get; }



        /// <summary>
        /// 体温°C  
        /// </summary>
        [DisplayName("体温°C ")]
        public string BodyTemperature { set; get; }

        /// <summary>
        /// 血清肌酐值(Scr)       μmol/L 
        /// </summary>
        [DisplayName("血清肌酐值(Scr)μmol/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string Scr { set; get; }

        /// <summary>
        /// 下拉框选择：酶法  □干化学法  其他  
        /// </summary>
        [DisplayName("血清肌酐实验方法")]
        [AutoGenerateColumn(Ignore = true)]
        public ScrEnum Screnum { set; get; }

        /// <summary>
        /// 其他
        /// </summary>
        [DisplayName("其他")]
        [AutoGenerateColumn(Ignore = true)]
        public string Screnumother { set; get; }

        /// <summary>
        ///  血尿素氮(BUN)
        /// </summary>
        [DisplayName("血尿素氮(BUN) mmol/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string BUN { set; get; }

        /// <summary>
        ///  肌酐清除率 L/h 
        /// </summary>
        [DisplayName("肌酐清除率 L/h ")]
        [AutoGenerateColumn(Ignore = true)]
        public string CLcr { set; get; }
        /// <summary>
        /// 小球滤过率 mL/(min*1.73m2)
        /// </summary>
        [DisplayName("小球滤过率 mL/(min*1.73m2)")]
        [AutoGenerateColumn(Ignore = true)]
        public string eGFR { set; get; }
        /// <summary>
        /// 丙氨酸氨基转氨酶（ALT）U/L
        /// </summary>
        [DisplayName("丙氨酸氨基转氨酶（ALT）U/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string ALT { set; get; }
        /// <summary>
        /// 门冬氨酸氨基转移酶（AST）         U/L 
        /// </summary>
        [DisplayName("门冬氨酸氨基转移酶（AST）U/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string AST { set; get; }
        /// <summary>
        ///  碱性磷酸酶（ALP）         U/L 
        /// </summary>
        [DisplayName("碱性磷酸酶（ALP）U/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string ALP { set; get; }
        /// <summary>
        ///  总胆红素（TBLL，）        μmol/L 
        /// </summary>
        [DisplayName("总胆红素（TBLL，）μmol/L  ")]
        [AutoGenerateColumn(Ignore = true)]
        public string TBLL { set; get; }
        /// <summary>
        ///  直接胆红素（TBLL，）       μmol/L 
        /// </summary>
        [DisplayName("直接胆红素（TBLL，）μmol/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string TBLL_Z { set; get; }
        /// <summary>
        /// 间接胆红素（TBLL）       μmol/L 
        /// </summary>
        [DisplayName("间接胆红素（TBLL）μmol/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string TBLL_J { set; get; }
        /// <summary>
        ///  血清白蛋白（ALB）       g/L  
        /// </summary>
        [DisplayName("血清白蛋白（ALB）g/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string ALB { set; get; }
        /// <summary>
        /// INR    S  
        /// </summary>
        [DisplayName("INR (S)")]
        [AutoGenerateColumn(Ignore = true)]
        public string INR { set; get; }

        /// <summary>
        ///  Child-pugh评分           (下拉框选择：A级、B级、C级)，；
        /// </summary>
        [DisplayName("Child-pugh评分")]
        [AutoGenerateColumn(Ignore = true)]
        public string Child_pugh { set; get; }
        /// <summary>
        ///  血小板计数（PLT） *109/L 
        /// </summary>
        [DisplayName("血小板计数（PLT） *109/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string PLT { set; get; }
        /// <summary>
        ///  白细胞计数（WBC）*109/L  
        /// </summary>
        [DisplayName("白细胞计数(WBC*109/L)")]
        [AutoGenerateColumn(Ignore = true)]
        public string WBC { set; get; }

        /// <summary>
        ///  中性粒细胞（NE%）        % 
        /// </summary>
        [DisplayName("中性粒细胞 NE% ")]
        [AutoGenerateColumn(Ignore = true)]
        public string NE { set; get; }
        /// <summary>
        ///  谷氨酰转肽酶：       u/L 
        /// </summary>
        [DisplayName("谷氨酰转肽酶u/L")]
        [AutoGenerateColumn(Ignore = true)]
        public string GGT { set; get; }
        /// <summary>
        /// 血红蛋白       g/L 
        /// </summary>
        [DisplayName("血红蛋白g/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string Hemoglobin { set; get; }
        /// <summary>
        ///  C-反应蛋白（CRP）       mg/L 
        /// </summary>
        [DisplayName("C-反应蛋白（CRP）mg/L ")]
        [AutoGenerateColumn(Ignore = true)]
        public string CRP { set; get; }
        /// <summary>
        ///  降钙素原（PCT）       ng/ml  
        /// </summary>
        [DisplayName(" 降钙素原（PCT）ng/ml  ")]
        [AutoGenerateColumn(Ignore = true)]
        public string PCT { set; get; }
        /// <summary>
        /// 白介素6（IL6）       pg/ml  
        /// </summary>
        [DisplayName("白介素6（IL6）pg/ml  ")]
        [AutoGenerateColumn(Ignore = true)]
        public string IL6 { set; get; }

        /// <summary>
        /// 红细胞沉降（ESR）       mm/h 
        /// </summary>
        [DisplayName("红细胞沉降（ESR）mm/h ")]
        [AutoGenerateColumn(Ignore = true)]
        public string ESR { set; get; }
        /// <summary>
        ///  尿白细胞计数      个/UL 
        /// </summary>
        [DisplayName(" 尿白细胞计数 个/UL ")]
        [AutoGenerateColumn(Ignore = true)]
        public string Uricine { set; get; }
        /// <summary>
        ///  亚硝酸盐   
        /// </summary>
        [DisplayName("亚硝酸盐")]
        [AutoGenerateColumn(Ignore = true)]
        public string Nitrite { set; get; }
        /// <summary>
        /// 细菌     个/UL 
        /// </summary>
        [DisplayName("细菌（个/UL） ")]
        [AutoGenerateColumn(Ignore = true)]
        public string bacterial { set; get; }
        /// <summary>
        ///  酵母菌     个/UL 
        /// </summary>
        [DisplayName("酵母菌（个/UL） ")]
        [AutoGenerateColumn(Ignore = true)]
        public string Yeast { set; get; }
        /// <summary>
        ///  脑脊液白细胞计数      个/UL
        /// </summary>
        [DisplayName("脑脊液白细胞计数 (个/UL) ")]
        [AutoGenerateColumn(Ignore = true)]
        public string CSF { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注 ")]
        [AutoGenerateColumn(Ignore = true)]
        public string Remark { set; get; }

    }
}
