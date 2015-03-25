using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibNumb
{
    public class Program
    {
        // Count number of Fibonacci numbers.
        public static int fibNumb(int number)
        {
            if (number < 3)
            {
                return 1;
            }
            const int sizeOfArray = 3;
            int[] array = new int[sizeOfArray];
            array[0] = 1;
            array[1] = 1;
            array[2] = 2;
            for (int i = 3; i != number; ++i)
            {
                int temp = array[2];
                array[2] = array[1] + array[2];
                array[0] = array[1];
                array[1] = temp;
            }
            return array[2];
        }

        static void Main(string[] args)
        {
            Console.Write("Enter natural number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci number is " + fibNumb(number));
        }
    }
}
