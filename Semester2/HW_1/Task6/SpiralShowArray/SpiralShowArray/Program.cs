using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralShowArray
{
    class Program
    {
        /// <summary>
        /// Function show the matrix spirally.
        /// </summary>
        /// <param name="matrix">Matrix which will be shown.</param>
        /// <param name="sizeOfMatrix">Number of columns or strings.</param>
        static void SpiralShowMatrix(int[][] matrix, int sizeOfMatrix)
        {
            const int right = 0;
            const int down = 1;
            const int left = 2;
            const int up = 3;
            int move = 0;
            int currentX = sizeOfMatrix / 2;
            int currentY = sizeOfMatrix / 2;
            int currentNumberOfSteps = 1;
            Console.Write(matrix[currentX][currentY] + " ");
            int i = 0;
            while (i != sizeOfMatrix*sizeOfMatrix - 1)
            {
                if (move == up || move == down)
                {
                    ++currentNumberOfSteps;
                }
                if (move != up)
                {
                    ++move;
                }
                else
                {
                    move = right;
                }
                for (int j = 0; j!=currentNumberOfSteps; ++j)
                {
                    switch (move)
                    {
                        case right:
                            {
                                ++currentX;
                            }
                            break;
                        case down:
                            {
                                ++currentY;
                            }
                            break;
                        case left:
                            {
                                --currentX;
                            }
                            break;
                        case up:
                            {
                                --currentY;
                            }
                            break;
                    }
                    Console.Write(matrix[currentX][currentY]);
                }
                ++i;
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
        }
    }
}
