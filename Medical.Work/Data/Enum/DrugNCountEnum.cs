using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical.Work.Data.Enum
{

    /// <summary>
    /// 给药频率
    /// </summary>
    public enum DrugNCountEnum
    {
        q24h, q12h, q6h, q3h,q36h, qn, qw, qd, q8h, bid, tid
    }

    public class EnumExtensions
    {
        public static List<string> DrugNCountEnumItems => new() { "q24h", "q12h", "q6h", "q3h", "q36h", "qn", "qw", "qd", "q8h", "bid", "tid" };


        //public T GetEnum<T>(T tParameter)
        //{ 
        //}
    }
}