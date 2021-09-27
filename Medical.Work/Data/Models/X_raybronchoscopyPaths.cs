using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class X_raybronchoscopyPaths
    {
        [Key]
        public int X_raybronchoscopyPathsID { set; get; }

        public string Adminuser { set; get; }

        public DateTime Createtime { set; get; }


        public string ImgUrl { set; get; }

        public int ID { set; get; }
        public X_raybronchoscopy  x_Raybronchoscopy { set; get; }
    }
}
