using Medical.Data.Models;

namespace Medical.Data.Command
{
    public static class PatientInfoExtend
    {
        public static string GetBMI(this PatientInfo patientInfo)
        {
            if (patientInfo is null) return "";

            var hei = Convert.ToDouble(patientInfo.HEI);
            var heith = hei / 100;

            if (patientInfo.BW is not null) return (patientInfo.BW / (heith * heith)).Value.ToString("0.00");

            return "";
        }

        public static string GetBsa(this PatientInfo patientInfo)
        {
            //S=0.0061×身高+0.0124×体重-0.0099
            if (patientInfo is null) return "";

            if (patientInfo.HEI is not null && patientInfo.BW is not null)
            {
                return (patientInfo.HEI * 0.0061 + 0.0124 * patientInfo.BW - 0.0099).Value.ToString("0.000");
            }

            return "";
        }
    }
}