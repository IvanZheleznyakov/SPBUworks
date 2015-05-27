using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldFunction
{
    public class FoldFunction<T>
    {
        public static T Fold(List<T> list, T primaryValue, Func<T, T, T> function)
        {
            for (int i = 0; i != list.Count; ++i)
            {
                primaryValue = function(primaryValue, list[i]);
            }

            return primaryValue;
        }
    }
}
