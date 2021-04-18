using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Medical.Work.Data.Command
{
    static  public  class DisplayAttributeExtend
    {

        /// <summary>
        /// 获取标签【DisplayName】名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        static public Dictionary<string, object?> GetAttributeExtends<T>(T t)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            Dictionary<string, object?> dic = new Dictionary<string, object?>();
            foreach (var p in properties)
            {
                //display名字
                var name = p.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
                //对应的值

                var property = t.GetType().GetProperty(p.Name).GetValue(t, null);


                var value = property ?? null;

                dic.Add(name, value);
            }
            return dic;
        }

        static public List<string> GetAttributeExtend<T>(T t)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
         
            var list =  new  List<string>();
            foreach (var p in properties)
            {
                list.Add(p.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
            }

            return list;

        }
    }

}

