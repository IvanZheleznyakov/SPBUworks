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
        static void FillArray(int[] array, int sizeOfArray)
        {
            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i != sizeOfArray; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Show array.
        /// </summary>
        /// <param name="array">Array that need to show.</param>
        /// <param name="sizeOfArray">Size of array.</param>
        static void ShowArray(int[] array, int sizeOfArray)
        {
            for (int i = 0; i != sizeOfArray; ++i)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Sort array with selection sort.
        /// </summary>
        /// <param name="array">Array that need to sort.</param>
        /// <param name="sizeOfArray">Size of array.</param>
        static void SelectionSort(int[] array, int sizeOfArray)
        {
            for (int i = 1; i!=sizeOfArray; ++i)
            {
                int j = i;
                while (j > 0 && array[j] < array[j-1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    --j;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array (natural number): ");
            int sizeOfArray = int.Parse(Console.ReadLine());
            if (sizeOfArray < 1)
            {
                Console.WriteLine("You entered not natural number.");
                return;
            }
            int[] array = new int[sizeOfArray];
            FillArray(array, sizeOfArray);
            SelectionSort(array, sizeOfArray);
            Console.WriteLine("Sorted array: ");
            ShowArray(array, sizeOfArray);
        }
    }
}
