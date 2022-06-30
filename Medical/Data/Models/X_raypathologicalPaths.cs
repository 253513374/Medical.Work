using System;

namespace Medical.Data.Models
{
    public class X_raypathologicalPaths
    {
        public int X_raypathologicalPathsID { set; get; }

        public string Adminuser { set; get; }

        public DateTime Createtime { set; get; }

        public string ImgUrl { set; get; }

        public int ID { set; get; }
        public X_raypathological x_Raypathological { set; get; }
    }
}