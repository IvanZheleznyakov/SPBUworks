using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    public static class CopyList<T>
    {
        public static void Copy(List<T> listFrom, ref List<T> listTo)
        {
            listTo.Clear();

            for (int i = 0; i != listFrom.Count; ++i)
            {
                listTo.Add(listFrom[i]);
            }
        }
    }
}
