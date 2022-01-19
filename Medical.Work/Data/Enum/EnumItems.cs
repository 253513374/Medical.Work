using BootstrapBlazor.Components;
using System.Collections;
using System.Collections.Generic;

namespace Medical.Work.Data.Enum
{
    public class EnumItems
    {
        /// <summary>
        /// 标准血浓度测试方法
        /// </summary>
        public static IEnumerable<SelectedItem> ConcentrationEnum { set; get; } = new[] {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("HPLC法","HPLC法"),
            new SelectedItem("酶联免疫法","酶联免疫法"),
            new SelectedItem("质谱法","质谱法"),
            new SelectedItem("其他","其他")
            // 维持30min, 维持60min, 维持90min, 维持240min
        };

        public static IEnumerable<SelectedItem> ConcentrationWeightEnum { get; set; } = new[] {
             new SelectedItem("","请选择..."){ Active = true },
             new SelectedItem("ug/l","ug/l"),
             new SelectedItem("mg/l","mg/l")
        };

        /// <summary>
        /// 药品计量单位
        /// </summary>
        public static IEnumerable<SelectedItem> DrugdosageUnit { set; get; } = new[] {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("ug","ug"),
            new SelectedItem("mg","mg"),
            new SelectedItem("g","g")
        };

        /// <summary>
        /// 持续给药时间
        /// </summary>
        public static IEnumerable<string> DrugNCountDurationEnum { set; get; } = new[] {
          "30min","60min","90min" ,"240min"
            // 维持30min, 维持60min, 维持90min, 维持240min
        };

        /// <summary>
        /// 给药频率
        /// </summary>
        public static IEnumerable<string> DrugNCountEnum { set; get; } = new[] {
           "q24h","q12h","q6h","q3h","q24h","q36h","qn","qw","qd","q8h","bid","tid"
            // public static List<string> DrugNCountEnumItems => new() { "q24h", "q12h", "q6h",
            // "q3h", "q36h", "qn", "qw", "qd", "q8h", "bid", "tid" };
        };

        /// <summary>
        /// 药敏检测方法
        /// </summary>
        public static IEnumerable<SelectedItem> DrugsensitivityEnum { set; get; } = new[] {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("纸片法","纸片法"),
            new SelectedItem("梅里埃的生物药敏板","梅里埃的生物药敏板"),
            new SelectedItem("ETSET法","ETSET法"),
            new SelectedItem("BMD","BMD"),
            new SelectedItem("其他","其他"),
            // 维持30min, 维持60min, 维持90min, 维持240min
        };

        /// <summary>
        /// 厂家类型
        /// </summary>
        public static IEnumerable<SelectedItem> Manufacturertype { set; get; } = new[] {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("进口","进口"),
            new SelectedItem("国产","国产"),
        };

        /// <summary>
        /// 性别
        /// </summary>
        public static IEnumerable<SelectedItem> SexItems { set; get; } = new[] {
            new SelectedItem("请选择...","请选择..."){ Active = true },
            new SelectedItem("男","男"),
            new SelectedItem("女","女")
        };

        /// <summary>
        /// 手术移植类型
        /// </summary>
        public static IEnumerable<SelectedItem> TransplantationEnum { set; get; } = new[] {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("肾移植","肾移植"),
            new SelectedItem("肝移植","肝移植"),
            new SelectedItem("肺移植","肺移植"),
            new SelectedItem("干细胞移植","干细胞移植")
        };

        /// <summary>
        /// 称重单位
        /// </summary>
        public static IEnumerable<SelectedItem> WeightEnum { set; get; } = new[] {
            new SelectedItem("ug","ug"),
            new SelectedItem("mg","mg"),
            new SelectedItem("g","g"),
            new SelectedItem("kg","kg"),
            new SelectedItem("平车","平车"),
            new SelectedItem("卧床","卧床")
        };

        /// <summary>
        /// 称重类型
        /// </summary>
        public static IEnumerable<SelectedItem> Weighttype { get; set; } = new SelectedItem[]
        {
            new SelectedItem("估算", "估算") ,
            new SelectedItem("称重", "称重"){ Active = true }
        };

        /// <summary>
        /// 药敏性类型
        /// </summary>
        public static IEnumerable<SelectedItem> SusceptibilityEnum { set; get; } = new[]
        {
            new SelectedItem("S", "S"),
            new SelectedItem("I", "I"),
            new SelectedItem("R", "R")
           
        };
        public static IEnumerable<SelectedItem> SpecimenTypeEnum { set; get; } = new[]
        {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("血液", "血液"),
            new SelectedItem("痰", "痰"),
            new SelectedItem("肺泡灌洗液", "肺泡灌洗液"),
            new SelectedItem("导管血", "导管血"),
            new SelectedItem("血标本", "血标本"),
            new SelectedItem("脑脊", "脑脊"),
            new SelectedItem("尿液", "尿液"),
            new SelectedItem("腹膜透析液", "腹膜透析液")
            //血液,
            //痰,
            //肺泡灌洗液,
            //导管血,
            //脑脊液,
            //血标本,
            //脑脊,
            //尿液,
            //腹膜透析液
        };

        /// <summary>
        /// 是否检查出结果{未检出} or {已经检出}  
        /// </summary>
        public static IEnumerable<SelectedItem> TestorNotEnum { set; get; } = new[]
        {
              new SelectedItem("","请选择..."){ Active = true },
              new SelectedItem("未检出", "未检出"),
              new SelectedItem("已经检出", "已经检出")
          
        };

        /// <summary>
        /// 是否做检查
        /// </summary>
        public static IEnumerable<SelectedItem> TestorIsNotEnum { set; get; } = new[]
        {
              new SelectedItem("","请选择..."){ Active = true },
              new SelectedItem("未做", "未做"),
              new SelectedItem("已做", "已做"),
           
        };

        /// <summary>
        /// 采血管 CollectingVesselEnum
        /// </summary>
        public static IEnumerable<SelectedItem> CollectingVesselEnum { set; get; } = new[]
        {
              new SelectedItem("","请选择..."){ Active = true },
              new SelectedItem("EDTA抗凝血", "EDTA抗凝血"),
              new SelectedItem("肝素抗凝血", "肝素抗凝血"),
              new SelectedItem("黄色血清管", "黄色血清管")
            //EDTA抗凝血,
            //肝素抗凝血,
            //黄色血清管
        };

        public static IEnumerable<SelectedItem> ScrEnum { set; get; } = new[] {
            //  酶法, 干化学法, 其他
              new SelectedItem("","请选择..."){ Active = true },
              new SelectedItem("酶法", "酶法"),
              new SelectedItem("干化学法", "干化学法"),
              new SelectedItem("其他", "其他")
        };

        /// <summary>
        /// 用药目的
        /// </summary>
        public static IEnumerable<SelectedItem> MedicationEnum { set; get; } = new[]
        {
              new SelectedItem("","请选择..."){ Active = true },
              new SelectedItem("确诊真菌感染", "确诊真菌感染"),
              new SelectedItem("经验性怀疑真菌感染", "经验性怀疑真菌感染"),
              new SelectedItem("预防真菌感染", "预防真菌感染")
            //确诊真菌感染,
            //经验性怀疑真菌感染,
            //预防真菌感染
        };

        /// <summary>
        /// 治疗效果
        /// </summary>
        public static IEnumerable<SelectedItem> HealingeffectEnum { set; get; } = new[]
        {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("治愈", "治愈"),
            new SelectedItem("好转", "好转"),
            new SelectedItem("无效", "无效"),
            new SelectedItem("死亡", "死亡")
            //治愈,
            //好转,
            //无效,
            //死亡
        };

        /// <summary>
        /// 病源菌
        /// </summary>
        public static IEnumerable<SelectedItem> PathogenicbacteriaEnum { set; get; } = new[]
        {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("曲霉菌或经验性考虑曲霉", "曲霉菌或经验性考虑曲霉"),
            new SelectedItem("念珠菌或经验性考虑念珠菌", "念珠菌或经验性考虑念珠菌"),
            new SelectedItem("隐球菌", "隐球菌"),
            new SelectedItem("类鼻疽", "类鼻疽"),
            new SelectedItem("其他真菌", "其他真菌")
            //曲霉菌或经验性考虑曲霉,
            //念珠菌或经验性考虑念珠菌,
            //隐球菌,
            //其他真菌,
            //类鼻疽
        };

        /// <summary>
        /// 用药实验状态
        /// </summary>
        public static IEnumerable<SelectedItem> AssaysituationEnum { set; get; } = new[]
        {
            // 用药前, 用药中, 用药后
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("用药前", "用药前"),
            new SelectedItem("用药中", "用药中"),
            new SelectedItem("用药后", "用药后")
        };

        /// <summary>
        ///  放射诊断方式X_rayImagingEnum
        /// </summary>
        public static IEnumerable<SelectedItem> X_rayImagingEnum { set; get; } = new[]
        {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("X线", "X线"),
            new SelectedItem("超声", "超声"),
            new SelectedItem("CT", "CT"),
            new SelectedItem("磁共振", "磁共振")
          
        };

        /// <summary>
        ///  放射诊断部位 X_rayImaginglocationEnum
        /// </summary>
        public static IEnumerable<SelectedItem> X_rayImaginglocationEnum { set; get; } = new[]
        {
            new SelectedItem("","请选择..."){ Active = true },
            new SelectedItem("肺部", "肺部"),
            new SelectedItem("胸部", "胸部"),
            new SelectedItem("腹部", "腹部"),
            new SelectedItem("肝胆胰", "肝胆胰")
        };

    }
}