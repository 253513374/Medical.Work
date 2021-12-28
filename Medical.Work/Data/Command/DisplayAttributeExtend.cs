using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Medical.Work.Data.Command
{
    public static class DisplayAttributeExtend
    {
        /// <summary>
        /// 获取标签【DisplayName】名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Dictionary<string, object?> GetAttributeExtends<T>(T t)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            Dictionary<string, object?> dic = new Dictionary<string, object?>();
            foreach (var p in properties)
            {
                //display名字
                var name = p.GetCustomAttribute<DisplayNameAttribute>();

                if (name != null)
                {
                    var property = t.GetType().GetProperty(p.Name).GetValue(t, null);

                    var value = property ?? null;
                    //  NameAttribute = name.DisplayName;
                    dic.Add(name.DisplayName, value);
                }
                //对应的值
            }
            return dic;
        }

        public static List<string> GetAttributeExtend<T>(T t)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            var list = new List<string>();
            foreach (var p in properties)
            {
                list.Add(p.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
            }

            return list;
        }
    }
}