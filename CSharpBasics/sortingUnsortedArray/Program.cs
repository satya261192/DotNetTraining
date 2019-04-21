using System;

namespace sortingUnsortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the different numbers not in order to sort them");
            Console.WriteLine("Enter the length of an array");

            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            for(int i=0; i<length; i++)
            {
                Console.WriteLine("Enter the number for array["+i+"]");
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<length; i++)
            {
                for(int j=i+1; j<length; j++)
                {

                }
            }
        }
    }
}
