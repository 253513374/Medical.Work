using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class Contacts :  BaseDataInterface
    {




        /// <summary>
        /// 联系电话
        /// </summary>
        [DisplayName("联系电话")]
        public string Contactnumber { set; get; }
        /// <summary>
        /// 患者邮件
        /// </summary>
        [DisplayName("患者邮件")]
        public string Emai { set; get; }

        /// <summary>
        /// 单位及地址
        /// </summary>
        [DisplayName("单位及地址")]
        public string Address { set; get; }



        /// <summary>
        /// 记录人账号
        /// </summary>
        [DisplayName("记录人账号")]
        public string Adminname { set; get; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [DisplayName("记录时间")]
        public DateTime? Createtime { set; get; }

        
    }
}
