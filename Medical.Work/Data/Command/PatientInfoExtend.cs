using Medical.Work.Data.Models;
using System;

namespace Medical.Work.Data.Command
{
    public static class PatientInfoExtend
    {
        public static string GetBMI(this PatientInfo patientInfo)
        {
            if (patientInfo != null)
            {
                var hei = Convert.ToDouble(patientInfo.HEI);
                var heith = hei / 100;
                return (patientInfo.BW / (heith * heith)).ToString("0.00");
            }
            return "";
        }

        public static string GetBsa(this PatientInfo patientInfo)
        {
            //S=0.0061×身高+0.0124×体重-0.0099
            if (patientInfo != null)
            {
                return (patientInfo.HEI * 0.0061 + 0.0124 * patientInfo.BW - 0.0099).ToString();
            }
            return "";
        }
    }
}