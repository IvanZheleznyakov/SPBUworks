using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapFunction
{
    public class MapFunction<T>
    {
        public static List<T> Map(List<T> list, Func<T, T> function)
        {
            var resultList = new List<T>();
            foreach (T element in list)
            {
                resultList.Add(function(element));
            }
            return resultList;
        }
    }
}
