using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class MedicalDGK
    {

        public int ID { set; get; }
        public string MedicalDGKGuid { set; get; }

        public DateTime Createtime { set; get; }

        public string patientInfoGuid { set; get; }
        
        public string medicalPgguid { set; get; }
        public string medicalPdguid { set; get; }
        public string medicalPkguid { set; get; }

    }
}
