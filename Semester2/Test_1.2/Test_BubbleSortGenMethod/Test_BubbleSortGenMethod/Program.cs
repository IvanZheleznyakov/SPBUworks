using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_BubbleSortGenMethod
{
    public class Program
    {
        /// <summary>
        /// Swap two elements in list.
        /// </summary>
        public static List<T> SwapInList<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
            return list;
        }

        /// <summary>
        /// Sort elements in list with bubble sort.
        /// </summary>
        public static List<T> BubbleSort<T>(List<T> list, Comparer<T> comparer)
        {
            int sizeOfList = list.Count<T>();
            for (int i = 0; i != sizeOfList - 1; ++i)
            {
                for (int j = 0; j != sizeOfList - i - 1; ++j)
                {
                    if (comparer.Compare(list[j], list[j + 1]) > 0)
                    {
                        list = SwapInList<T>(list, j, j + 1);
                    }
                }
            }
                return list;
        }

        static void Main(string[] args)
        {
        }
    }
}
