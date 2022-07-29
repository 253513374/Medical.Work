using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Medical.Data.Models
{
    public class Contacts : BaseDataInterface
    {
        /// <summary>
        /// 联系电话
        /// </summary>
        [DisplayName("联系电话")]
        [Required(ErrorMessage = "必须填写")]
        public string Contactnumber { set; get; }

        /// <summary>
        /// 患者邮件 mail
        /// </summary>
        [DisplayName("患者邮件")]
        
        public string Email { set; get; }

        /// <summary>
        /// 单位及地址
        /// </summary>
        [Required(ErrorMessage = "必须填写")]
        [DisplayName("单位及地址")]
        public string Address { set; get; }

        ///// <summary>
        ///// 记录人账号
        ///// </summary>
        //[DisplayName("记录人账号")]
        //public string Adminname { set; get; }

        ///// <summary>
        ///// 记录时间
        ///// </summary>
        //[DisplayName("记录时间")]
        //public DateTime? Createtime { set; get; }
    }
}