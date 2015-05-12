using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine(array.Length);
            array[0] = 2;
            Console.WriteLine(array.Length);
            array[0] = default(int);
            Console.WriteLine(array.Length);
        }
    }
}
