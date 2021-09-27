using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data.Models
{
    public class X_rayImagePaths
    {

        public int X_rayImagePathsID { set; get; }

        public string Adminuser { set; get; }

        public DateTime Createtime { set; get; }

    
        public string ImgUrl { set; get; }



        public int ID { set; get; }
        public X_rayImaging x_RayImaging { set; get; }

        
    }
}
