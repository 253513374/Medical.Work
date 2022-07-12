namespace Medical.Data.Enum
{
    public class EnumItems
    {
        /// <summary>
        /// 标准血浓度测试方法
        /// </summary>
        public static IEnumerable<string> ConcentrationEnum { set; get; } = new[] {
        "HPLC法","酶联免疫法","质谱法","其他"
         
        };

        public static IEnumerable<string> ConcentrationWeightEnum { get; set; } = new[] {

            "ug/l",
            "mg/l"
             //new string("ug/l","ug/l" ,
             //new string("mg/l","mg/l" 
        };

        /// <summary>
        /// 药品计量单位
        /// </summary>
        public static IEnumerable<string> DrugdosageUnit { set; get; } = new[] {
            "ug",
            "mg",
            "g"
            //new string("","请选择..." 
            //new string("ug","ug" ,
            //new string("mg","mg" ,
            //new string("g","g" 
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
          "q3h","q6h","q8h","q12h","q24h","q36h","qn","qw","qd","bid","tid"
        };

        /// <summary>
        /// 给药途径
        /// </summary>
        public static IEnumerable<string> DrugdosageRouteEnum { set; get; } = new[] {
          "口服","输液","肌肉注射"
            // public static List<string> DrugNCountEnumItems => new( { "q24h", "q12h", "q6h",
            // "q3h", "q36h", "qn", "qw", "qd", "q8h", "bid", "tid" };
        };

        /// <summary>
        /// 药敏检测方法
        /// </summary>
        public static IEnumerable<string> DrugsensitivityEnum { set; get; } = new[] {
            "纸片法",
            "梅里埃的生物药敏板",
            "ETSET法",
            "BMD",
            "其他"            

            //new string("","请选择..." 
            //new string("纸片法",            "纸片法" ,
            //new string("梅里埃的生物药敏板","梅里埃的生物药敏板" ,
            //new string("ETSET法",           "ETSET法" ,
            //new string("BMD",                 "BMD" ,
            //new string("其他",                "其他" ,
            // 维持30min, 维持60min, 维持90min, 维持240min
        };

        /// <summary>
        /// 厂家类型
        /// </summary>
        public static IEnumerable<string> Manufacturertype { set; get; } = new[] {

            "进口",
            "国产"
            //new string("","请选择..." 
            //new string("进口","进口" ,
            //new string("国产","国产" ,
        };

        /// <summary>
        /// 性别
        /// </summary>
        public static IEnumerable<string> SexItems { set; get; } = new[] {
            "男",
            "女"

            //new string("请选择...","请选择..." 
            //new string("男","男" ,
            //new string("女","女" 
        };

        /// <summary>
        /// 手术移植类型
        /// </summary>
        public static IEnumerable<string> TransplantationEnum { set; get; } = new[] {
            "肾移植",
            "肝移植",
            "肺移植",
            "干细胞移植"
            //new string("","请选择..." 
            //new string("肾移植",    "肾移植" ,
            //new string("肝移植",    "肝移植" ,
            //new string("肺移植",    "肺移植" ,
            //new string("干细胞移植","干细胞移植" 
        };

        /// <summary>
        /// 称重单位
        /// </summary>
        public static IEnumerable<string> WeightEnum { set; get; } = new[] {
            "ug",
            "mg",
            "g",
            "kg",
            "平车",
            "卧床"
            //new string("ug",   "ug" ,
            //new string("mg",   "mg" ,
            //new string("g",   "g" ,
            //new string("kg",   "kg" ,
            //new string("平车",   "平车" ,
            //new string("卧床",  "卧床" 
        };

        /// <summary>
        /// 称重类型
        /// </summary>
        public static IEnumerable<string> Weighttype { get; set; } = new []
        {
            "估算",
            "称重"
            //new string("估算", "估算" ,
            //new string("称重", "称重" { Active = true }
        };

        /// <summary>
        /// 药敏性类型
        /// </summary>
        public static IEnumerable<string> SusceptibilityEnum { set; get; } = new[]
        {
            "S",
            "I",
            "R"
            //new string("S", "S" ,
            //new string("I", "I" ,
            //new string("R", "R" 

        };
        public static IEnumerable<string> SpecimenTypeEnum { set; get; } = new[]
        {
            "血液",
            "痰",
            "肺泡灌洗液",
            "导管血",
            "血标本",
            "脑脊",
            "尿液",
            "腹膜透析液",
            //new string("","请选择..." 
            //new string("血液",              "血液" ,
            //new string("痰",               "痰" ,
            //new string("肺泡灌洗液",           "肺泡灌洗液" ,
            //new string("导管血",             "导管血" ,
            //new string("血标本",                "血标本" ,
            //new string("脑脊",              "脑脊" ,
            //new string("尿液",               "尿液" ,
            //new string("腹膜透析液",       "腹膜透析液" 
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
        public static IEnumerable<string> TestorNotEnum { set; get; } = new[]
        {
            "未检出", 
            "已经检出"
              //new string("","请选择..." 
              //new string("未检出", "未检出" ,
              //new string("已经检出", "已经检出" 

        };

        /// <summary>
        /// 是否做检查
        /// </summary>
        public static IEnumerable<string> TestorIsNotEnum { set; get; } = new[]
        {
            "未做",
            "已做"
              //new string("","请选择..." 
              //new string("未做", "未做" ,
              //new string("已做", "已做" ,

        };

        /// <summary>
        /// 采血管 CollectingVesselEnum
        /// </summary>
        public static IEnumerable<string> CollectingVesselEnum { set; get; } = new[]
        {
            "EDTA抗凝血",
            "肝素抗凝血",
            "黄色血清管"
              //new string("","请选择..." 
              //new string("EDTA抗凝血", "EDTA抗凝血" ,
              //new string("肝素抗凝血", "肝素抗凝血" ,
              //new string("黄色血清管", "黄色血清管" 
            //EDTA抗凝血,
            //肝素抗凝血,
            //黄色血清管
        };

        public static IEnumerable<string> ScrEnum { set; get; } = new[] {
            //  酶法, 干化学法, 其他
            //  "","请选择..." 
              "酶法", 
              "干化学法",
              "其他"
        };

        /// <summary>
        /// 用药目的
        /// </summary>
        public static IEnumerable<string> MedicationEnum { set; get; } = new[]
        {
           
              "确诊真菌感染",
              "经验性怀疑真菌感染",
              "预防真菌感染"
            //确诊真菌感染,
            //经验性怀疑真菌感染,
            //预防真菌感染
        };

        /// <summary>
        /// 治疗效果
        /// </summary>
        public static IEnumerable<string> HealingeffectEnum { set; get; } = new[]
        {
          
            "治愈",
            "好转",
            "无效", 
            "死亡",
            //治愈,
            //好转,
            //无效,
            //死亡
        };

        /// <summary>
        /// 病源菌
        /// </summary>
        public static IEnumerable<string> PathogenicbacteriaEnum { set; get; } = new[]
        {
          
            "曲霉菌或经验性考虑曲霉",
            "念珠菌或经验性考虑念珠菌",
            "隐球菌",
            "类鼻疽", 
            "其他真菌"
            //曲霉菌或经验性考虑曲霉,
            //念珠菌或经验性考虑念珠菌,
            //隐球菌,
            //其他真菌,
            //类鼻疽
        };

        /// <summary>
        /// 用药实验状态
        /// </summary>
        public static IEnumerable<string> AssaysituationEnum { set; get; } = new[]
        {
            // 用药前, 用药中, 用药后
          
            "用药前",
            "用药中",
            "用药后", 
        };

        /// <summary>
        ///  放射诊断方式X_rayImagingEnum
        /// </summary>
        public static IEnumerable<string> X_rayImagingEnum { set; get; } = new[]
        {
           
            "X线",
            "超声",
            "CT",
            "磁共振",

        };

        /// <summary>
        ///  放射诊断部位 X_rayImaginglocationEnum
        /// </summary>
        public static IEnumerable<string> X_rayImaginglocationEnum { set; get; } = new[]
        {
         
            "肺部",
            "胸部",
            "腹部", 
            "肝胆胰",
        };


        /// <summary>
        /// 溶媒
        /// </summary>
        public static IEnumerable<string> DrugSpecificationsEnum { set; get; } = new[]
        {

            "生理盐水",
            "纯净水"
           
        };
    }
}