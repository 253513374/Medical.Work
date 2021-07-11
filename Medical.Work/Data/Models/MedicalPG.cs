using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPG
    {

        /// <summary>
        /// ID
        /// </summary>
        [DisplayName( "自增")]
        public int ID { set; get; }


        /// <summary>
        /// 维一编码
        /// </summary>
        [DisplayName( "维一编码")]
        public string MedicalPGGuid { set; get; }
        /// <summary>
        /// 维一编码
        /// </summary>
        [DisplayName("维一编码")]
        public string Adminname { set; get; }



        /// <summary>
        /// 创建时间 
        /// </summary>
        [DisplayName( "创建时间")]
        public DateTime CreateTime { set; get; }

 

        /// <summary>
        /// 基因： 
        /// </summary>
        [DisplayName( "基因")]
        public string Genes { set; get; }

        /// <summary>
        /// RS号：（一个基因对应唯一一个RS） 
        /// </summary>
        [DisplayName( "RS号")]
        public string Rs { set; get; }


        /// <summary>
        /// 基因结果： 
        /// </summary>
        [DisplayName( "基因结果")]
        public string GenesResults { set; get; }

        /// <summary>
        ///代谢类型;   必须由多个基因检测结果共同判断代谢类型；例如：CYP2C19*2检测结果为AA, CYP2C19*3检测结果为GG, CYP2C19*17检测结果为CC,那么这个患者代谢类型为：慢代谢型（PM）,如果缺少了任何一个检测值都不能判断。 
        /// </summary>
        [DisplayName( "代谢类型")]
        public string Metabolictype { set; get; }


        /// <summary>
        /// 致病菌菌体基因名：
        /// </summary>
        [DisplayName( "致病菌菌体基因名")]
        public string PathogenicGeneName { set; get; }


        /// <summary>
        /// 致病菌菌体基因检测结果 
        /// </summary>
        [DisplayName( "致病菌菌体基因检测结果")]
        public string PathogenicGeneDetectionResults { set; get; }


        //
        /// <summary>
        /// 生化检测
        /// </summary>
        [DisplayName( "生化检测")]
        public string BiochemicalTest { set; get; }



        /// <summary>
        /// 采血当天的肌酐清除率（CLcr，L/h） 
        /// </summary>
        [DisplayName( "采血当天的肌酐清除率")]
        public string CLcr { set; get; }



        /// <summary>
        /// 小球滤过率（eGFR，mL/(min*1.73m2） 
        /// </summary>
        [DisplayName( "小球滤过率mL/(min*1.73m2")]
        public string EGFR { set; get; }


        /// <summary>
        /// 采血当天血清肌酐值（Scr，μmol/L） 
        /// </summary>
        [DisplayName( "采血当天血清肌酐值 μmol/L")]
        public string Scr { set; get; }

        //采血当天白蛋白（ALB，g/L）
        //public string ALB { set; get; }

        //采血当天总胆红素（（TBLL，μmol/L））
        //public string TBLL { set; get; }


        /// <summary>
        /// 采血当天INR 
        /// </summary>
        [DisplayName( "采血当天INR")]
        public string INR { set; get; }


        /// <summary>
        /// 采血当天C-P评分： 
        /// </summary>
        [DisplayName( "采血当天C-P评分")]
        public string CPscore { set; get; }

        /// <summary>
        /// 采血当天丙氨酸氨基转氨酶（ALT，U/L） 
        /// </summary>
        [DisplayName( "采血当天丙氨酸氨基转氨酶 U/L")]
        public string ALT { set; get; }



        /// <summary>
        /// 采血当天碱性磷酸酶（ALP,U/L） 
        /// </summary>
        [DisplayName( "采血当天碱性磷酸酶 U/L")]
        public string ALP { set; get; }

        //血清肌酐值（Scr，μmol/L）
        // public string Scr { set; get; }


        /// <summary>
        /// 血尿素氮（BUN，mmol/L） 
        /// </summary>
        [DisplayName( "血尿素氮mmol/L")]
        public string BUN { set; get; }

        //丙氨酸氨基转氨酶（ALT，U/L）
        //public string PathogenicGeneDetectionResults { set; get; }


        /// <summary>
        /// 门冬氨酸氨基转移酶（AST，U/L）
        /// </summary>
        [DisplayName( "门冬氨酸氨基转移酶 U/L")]
        public string AST { set; get; }


        /// <summary>
        /// // 总胆红素（TBLL，μmol/L）
        /// </summary>
        [DisplayName( "总胆红素 μmol/L")]
        public string TBLL { set; get; }


        /// <summary>
        /// 直接胆红素（TBLL，μmol/L） 
        /// </summary>
        [DisplayName( "直接胆红素 μmol/L")]
        public string DirectTBLL { set; get; }


        /// <summary>
        /// 间接胆红素（TBLL，μmol/L） 
        /// </summary>
        [DisplayName( "间接胆红素 μmol/L")]
        public string IndirectTBLL { set; get; }

       
        /// <summary>
        /// 血清白蛋白（ALB，g/L，指低值） 
        /// </summary>
        [DisplayName( "血清白蛋白 g/L")]
        public string ALB { set; get; }

        

        /// <summary>
        /// 血小板计数（PLT，*109/L，指低值）
        /// </summary>
        [DisplayName( "血小板计数 *109/L")]
        public string PLT { set; get; }

   
        /// <summary>
        /// 白细胞计数（WBC，*109/L）
        /// </summary>
        [DisplayName( "白细胞计数 *109/L")]
        public string WBC { set; get; }


        /// <summary>
        ///  C-反应蛋白（CRP,mg/L）
        /// </summary>
        [DisplayName( "C-反应蛋白 mg/L")]
        public string CRP { set; get; }

   
        /// <summary>
        /// 降钙素原（PCT，ng/ml）
        /// </summary>
        [DisplayName( "降钙素原 ng/ml")]
        public string PCT { set; get; }

        
        /// <summary>
        /// 白介素6（IL6,pg/ml）
        /// </summary>
        [DisplayName( "白介素6 pg/ml")]
        public string IL6 { set; get; }

        
        /// <summary>
        /// 红细胞沉降（ESR,mm/h）
        /// </summary>
        [DisplayName( "红细胞沉降 mm/h")]
        public string ESR { set; get; }

 
        /// <summary>
        /// 合并用药情况：需要录入什么时间服用什么药，给药途径是什么，给药剂量是多少，一天给几次，，什么时间停止。例如：2021.01.01----2021.01.06：伏立康唑200mg,po,bid。
        /// </summary>
        [DisplayName( "合并用药情况")]
        public string Combineduseofdrugs { set; get; }


        /// <summary>
        /// 不良反应症状
        /// </summary>
        [DisplayName( "不良反应症状")]
        public string Symptomsofadversereactions { set; get; }

       
        /// <summary>
        /// 不良反应类型：肝毒性，视觉异常，过敏………
        /// </summary>
        [DisplayName( "不良反应类型")]
        public string Typesofadversereactions { set; get; }


        /// <summary>
        /// 不良反应处理措施及分析：
        /// </summary>
        [DisplayName( "不良反应处理措施及分析")]
        public string Analysisadversereactions { set; get; }

        /// <summary>
        /// 厂家：进口，国产
        /// </summary>
        [DisplayName( "厂家")]
        public string Manufacturer { set; get; }


        /// <summary>
        /// 治疗结局：死亡，有效
        /// </summary>
        [DisplayName( "治疗结局")]
        public string Treatmentoutcome { set; get; }

    
        /// <summary>
        /// 治疗总结：
        /// </summary>
        [DisplayName( "治疗总结")]
        public string Treatmentsummary { set; get; }

   
        /// <summary>
        /// 备注：
        /// </summary>
        [DisplayName( "备注")]
        public string Remarks { set; get; }


        /// <summary>
        /// 登陆用户名称
        /// </summary>
        [DisplayName( "账号")]
        public string Username { set; get; }

    }
}
