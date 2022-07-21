using System;
using System.ComponentModel.DataAnnotations;

namespace Medical.Data.Models
{
    public class X_raybronchoscopyPaths
    {

        /// <summary>
        /// 唯一主键
        /// </summary>
        [Key]
        public int X_raybronchoscopyPathsID { set; get; }

        /// <summary>
        /// 上传人员
        /// </summary>
        public string Adminuser { set; get; }


        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createtime { set; get; }


        /// <summary>
        /// 保存路径
        /// </summary>
        public string ImgUrl { set; get; }


        public int ID { set; get; }
        public X_raybronchoscopy x_Raybronchoscopy { set; get; }
    }
}