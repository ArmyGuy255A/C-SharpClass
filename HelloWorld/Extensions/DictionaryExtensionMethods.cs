using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Extensions
{
    public static class DictionaryExtensions
    {
        public static void HelloBob<T,U>(this Dictionary<T, U> dic, T key)
        {
            
        }

        //public static U GetOrDefault<T, U>(this Dictionary<T, U> dic, T key)
        //{
        //    if (dic.ContainsKey(key)) return dic[key];
        //    return default(U);
        //}
    }
}


