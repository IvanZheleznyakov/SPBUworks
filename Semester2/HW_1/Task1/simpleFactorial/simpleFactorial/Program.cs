using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactorial
{
    public class Program
    {
        /// <summary>
        /// Count factorial.
        /// </summary>
        /// <param name="number">Factorial of this number count.</param>
        /// <returns>Factorial of number.</returns>
        public static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i != number + 1; ++i)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter natural number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Factorial is " + Factorial(number));
                return;
            }
            Console.WriteLine("You entered not natural number.");
        }
    }
}
