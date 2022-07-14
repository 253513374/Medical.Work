using Medical.Data.Enum;

namespace Medical.Data
{
    public  class EnumServer
    {

        /// <summary>
        /// 溶媒
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static async Task<IEnumerable<string>> OnAutoSearchDrugSpecifications(string value)
        {
            if (string.IsNullOrEmpty(value))
                return EnumItems.DrugSpecificationsEnum;
            return EnumItems.DrugSpecificationsEnum.Where(x => x.Contains(value));
        }


        /// <summary>
        /// 给药频率
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private async Task<IEnumerable<string>> OnAutoSearchDrugNCount(string value)
        {
            if (string.IsNullOrEmpty(value))
                return EnumItems.DrugNCountEnum;
            return EnumItems.DrugNCountEnum.Where(x => x.Contains(value));
        }


        /// <summary>
        /// 给药持续时间
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private async Task<IEnumerable<string>> OnAutoSearchDrugNCountDuration(string value)
        {
            if (string.IsNullOrEmpty(value))
                return EnumItems.DrugNCountDurationEnum;
            return EnumItems.DrugNCountDurationEnum.Where(x => x.Contains(value));
        }

        /// <summary>
        /// 给药途径
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static async Task<IEnumerable<string>> OnAutoSearchDrugdosageRoute(string value)
        {
            if (string.IsNullOrEmpty(value))
                return EnumItems.DrugdosageRouteEnum;
            return EnumItems.DrugdosageRouteEnum.Where(x => x.Contains(value));
        }

        /// <summary>
        /// 给药计量单位
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private async Task<IEnumerable<string>> OnAutoSearchDrugdosageUnit(string value)
        {
            if (string.IsNullOrEmpty(value))
                return EnumItems.DrugdosageUnit;
            return EnumItems.DrugdosageUnit.Where(x => x.Contains(value));
        }
    }
}
