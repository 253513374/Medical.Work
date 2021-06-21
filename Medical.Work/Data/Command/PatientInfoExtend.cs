using Medical.Work.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Command
{
    public static class PatientInfoExtend
    {
        public static string GetBMI(this PatientInfo patientInfo)
        {

            if(patientInfo!=null)
            {
                return (patientInfo.BW / (patientInfo.HEI * patientInfo.HEI)).ToString();
            }
            return "";
        }

        public static string GetBsa(this PatientInfo patientInfo)
        {

            //S=0.0061×身高+0.0124×体重-0.0099
            if (patientInfo != null)
            {
                return (patientInfo.HEI*0.0061+0.0124*patientInfo.BW-0.0099).ToString();
            }
            return "";
        }
    }
}
