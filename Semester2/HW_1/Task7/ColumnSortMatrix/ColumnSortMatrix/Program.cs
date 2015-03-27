using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnSortMatrix
{
    class Program
    {
        /// <summary>
        /// Show matrix on console.
        /// </summary>
        static void showMatrix(int[][] matrix)
        {
            for (int i = 0; i != matrix.GetLength(0); ++i)
            {
                for (int j = 0; j != matrix[i].GetLength(0); ++j)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Selection sort on columns.
        /// </summary>
        static void ColumnSelectionSort(int[][] matrix)
        {
            for (int i = 1; i != matrix[0].GetLength(0); ++i)
            {
                int j = i;
                while (j > 0 && matrix[0][j] < matrix[0][j - 1])
                {
                    for (int k = 0; k != matrix.GetLength(0); ++k)
                    {
                        int temp = matrix[k][j];
                        matrix[k][j] = matrix[k][j - 1];
                        matrix[k][j - 1] = temp;
                    }
                    --j;
                }
            }
        }

        static void Main(string[] args)
        {
            string[] fileData = System.IO.File.ReadAllLines("matrix.txt");
            int[][] matrix = new int[fileData.Length][];
            for (int i = 0; i != fileData.Length; ++i)
            {
                matrix[i] = fileData[i].Split(default(string[]), StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray<int>();
            }
            ColumnSelectionSort(matrix);
            Console.WriteLine("Sorted matrix: ");
            showMatrix(matrix);
        }
    }
}
