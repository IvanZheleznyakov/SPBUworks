using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleFactorial
{
    class Program
    {
        // Count factorial.
        static int Factorial(int number)
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
            Console.WriteLine("Factorial is " + Factorial(number));
        }
    }
}
