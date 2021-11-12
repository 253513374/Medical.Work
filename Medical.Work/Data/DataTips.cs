


using System.Collections.Generic;

namespace Medical.Work.Data
{
    public static class DataTips
    {
      
        public static IEnumerable<PatientsTips> PatientsTips = new List<PatientsTips>();    


        public static Dictionary<string,string> Tips { set; get; }=new Dictionary<string, string>(1000);

       
    }
    public class PatientsTips
    {
         public string Number { get; set; }
        
         public string Description { get; set; } 
    }

}
