using System;

namespace MaxDistanceOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the different values in to array");
            Console.WriteLine("Enter the length of an array");

            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            for(int i=0; i<length; i++)
            {
                Console.WriteLine("Enter the value of array["+i+"]");
                array[i] = int.Parse(Console.ReadLine());
            }


        }
    }
}
