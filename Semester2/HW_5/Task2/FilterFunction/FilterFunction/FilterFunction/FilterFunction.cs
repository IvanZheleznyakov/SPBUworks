using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterFunction
{
    public class FilterFunction<T>
    {
        public static List<T> Filter(List<T> list, Func<T, bool> function)
        {
            var resultList = new List<T>();

            foreach(T element in list)
            {
                if (function(element))
                {
                    resultList.Add(element);
                }
            }

            return resultList;
        }
    }
}
