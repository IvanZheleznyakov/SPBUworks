using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibNumb
{
    public class Program
    {
        /// <summary>
        /// Count number of Fibonacci numbers.
        /// </summary>
        /// <param name="number">Number of Fibonacci numbers.</param>
        /// <returns>Fibonacci number.</returns>
        public static int FibNumb(int number)
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
            if (number > 0)
            {
                Console.WriteLine("Fibonacci number is " + FibNumb(number));
                return;
            }
            Console.WriteLine("You entered not natural number.");
        }
    }
}
