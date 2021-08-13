using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5]; //can use initialized lists here as well
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            //alternative method:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 5, 7, 11},
                new int[] {1, 2, 3}
            };

            //challenge, print all values from Jagged array to console
            foreach (int[] row in jaggedArray2)
            {
                foreach (int value in row)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }

        }
    }
}
