using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalPG
    {
        public int ID { set; get; }
        public string MedicalPGGuid { set; get; }

        public DateTime DateTime { set; get; }


        //祖籍：***省份
        public string Ancestralhome { set; get; }
        //民族：
        public string Nationality { set; get; }
        //基因：
        public string Genes { set; get; }
        //RS号：（一个基因对应唯一一个RS）
        public string Rs { set; get; }
        //基因结果：
        public string GenesResults { set; get; }
        //代谢类型;   必须由多个基因检测结果共同判断代谢类型；例如：CYP2C19*2检测结果为AA, CYP2C19*3检测结果为GG, CYP2C19*17检测结果为CC,那么这个患者代谢类型为：慢代谢型（PM）,如果缺少了任何一个检测值都不能判断。
        public string Metabolictype { set; get; }

        //致病菌菌体基因名：
        public string PathogenicGeneName { set; get; }
        //致病菌菌体基因检测结果
        public string PathogenicGeneDetectionResults { set; get; }


        //生化检测
        public string BiochemicalTest { set; get; }

        //采血当天的肌酐清除率（CLcr，L/h）
        public string CLcr { set; get; }

        //小球滤过率（eGFR，mL/(min*1.73m2）
        public string EGFR { set; get; }

        //采血当天血清肌酐值（Scr，μmol/L）
        public string Scr { set; get; }

        //采血当天白蛋白（ALB，g/L）
        //public string ALB { set; get; }

        //采血当天总胆红素（（TBLL，μmol/L））
        //public string TBLL { set; get; }

        //采血当天INR
        public string INR { set; get; }

        //采血当天C-P评分：
        public string CPscore { set; get; }

        //采血当天丙氨酸氨基转氨酶（ALT，U/L）
        public string ALT { set; get; }

        //采血当天碱性磷酸酶（ALP,U/L）
        public string ALP { set; get; }

        //血清肌酐值（Scr，μmol/L）
       // public string Scr { set; get; }

        //血尿素氮（BUN，mmol/L）
        public string BUN { set; get; }

        //丙氨酸氨基转氨酶（ALT，U/L）
        //public string PathogenicGeneDetectionResults { set; get; }

        //门冬氨酸氨基转移酶（AST，U/L）
        public string AST { set; get; }

        //总胆红素（TBLL，μmol/L）
        public string TBLL { set; get; }

        //直接胆红素（TBLL，μmol/L）
        public string DirectTBLL { set; get; }

        //间接胆红素（TBLL，μmol/L）
        public string IndirectTBLL { set; get; }

        //血清白蛋白（ALB，g/L，指低值）
        public string ALB { set; get; }

        //血小板计数（PLT，*109/L，指低值）
        public string PLT { set; get; }

        //白细胞计数（WBC，*109/L）
        public string WBC { set; get; }

        //C-反应蛋白（CRP,mg/L）
        public string CRP { set; get; }

        //降钙素原（PCT，ng/ml）
        public string PCT { set; get; }

        //白介素6（IL6,pg/ml）
        public string IL6 { set; get; }

        //红细胞沉降（ESR,mm/h）
        public string ESR { set; get; }

        //合并用药情况：需要录入什么时间服用什么药，给药途径是什么，给药剂量是多少，一天给几次，，什么时间停止。例如：2021.01.01----2021.01.06：伏立康唑200mg,po,bid。
        public string Combineduseofdrugs { set; get; }

        //不良反应症状：
        public string Symptomsofadversereactions { set; get; }

        //不良反应类型：肝毒性，视觉异常，过敏………
        public string Typesofadversereactions { set; get; }

        //不良反应处理措施及分析：
        public string Analysisadversereactions { set; get; }

        //厂家：进口，国产
        public string Manufacturer { set; get; }

        //治疗结局：死亡，有效
        public string Treatmentoutcome { set; get; }

        //治疗总结：
        public string Treatmentsummary { set; get; }

        //备注：
        public string Remarks { set; get; }

    }
}
