using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOfArray
{
    public class Program
    {
        /// <summary>
        /// Fill array.
        /// </summary>
        /// <param name="array">Array that need to fill.</param>
        /// <param name="sizeOfArray">Size of array.</param>
        private static void FillArray(int[] array)
        {
            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i != array.GetLength(0); ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Show array.
        /// </summary>
        /// <param name="array">Array that need to show.</param>
        /// <param name="sizeOfArray">Size of array.</param>
        private static void ShowArray(int[] array)
        {
            for (int i = 0; i != array.GetLength(0); ++i)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Sort array with selection sort.
        /// </summary>
        /// <param name="array">Array that need to sort.</param>
        /// <param name="sizeOfArray">Size of array.</param>
        public static void SelectionSort(int[] array)
        {
            for (int i = 1; i != array.GetLength(0); ++i)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    --j;
                }
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array (natural number): ");
            int sizeOfArray = int.Parse(Console.ReadLine());
            if (sizeOfArray < 1)
            {
                Console.WriteLine("You entered not natural number.");
                return;
            }
            int[] array = new int[sizeOfArray];
            FillArray(array);
            SelectionSort(array);
            Console.WriteLine("Sorted array: ");
            ShowArray(array);
        }
    }
}
