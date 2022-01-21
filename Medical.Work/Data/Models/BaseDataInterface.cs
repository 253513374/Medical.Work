using BootstrapBlazor.Components;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Medical.Work.Data
{
    public class BaseDataInterface
    {
        /// <summary>
        /// ID
        /// </summary>
        [DisplayName("自增")]
        [AutoGenerateColumn(Ignore = true)]
        public int ID { set; get; }

        //[AutoGenerateColumn(Ignore = true)]
        //public int LaboratoryExaminationID { set; get; }

        /// <summary>
        /// 登陆用户名称
        /// </summary>
        [AutoGenerateColumn(Ignore = true)]
        public string Adminname { set; get; }

        /// <summary>
        /// 病历号 编号
        /// </summary>
        [NotNull]
        [DisplayName("编号")]
        [AutoGenerateColumn(Ignore = false)]
        public string Medicalrecordnumber { set; get; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [NotNull]
        [DisplayName("患者姓名")]
        [AutoGenerateColumn(Ignore = false)]
        public string Username { set; get; }

        [DisplayName("唯一编码")]
        [AutoGenerateColumn(Ignore = true)]
        public string Guid { set; get; }

        [DisplayName("记录时间")]
        public DateTime Createtime { set; get; }
    }
}