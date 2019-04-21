using System;

namespace multidimensionalarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[4, 3];
            array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Jagged Arrays");
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 1,2};
            jaggedArray[1] = new int[3] { 3,4,5 };
            jaggedArray[2] = new int[4] { 6, 7,8,9 };
            foreach (var element in jaggedArray)
            {
                foreach (int value in element)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
    }
}
