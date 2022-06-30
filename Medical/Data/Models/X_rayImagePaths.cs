using System;

namespace Medical.Data.Models
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