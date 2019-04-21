using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missingNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter values in order 1 to any");
            //int length = int.Parse(Console.ReadLine());

            //int[] array = new int[length];
            //for(int i=0; i<length; i++)
            //{
            //    Console.WriteLine("Enter the value for array[" + i + "]");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < length-1; i++)
            //{
            //    if (array[i] == array[i+1] - 1)
            //    {
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Missing number " + (array[i] + 1) );
            //    }
            //}

            Console.WriteLine("Enter the sequence of numbers");
            Console.WriteLine("Enter length of an array");

            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            for(int i=0; i<length; i++)
            {
                Console.WriteLine("Enter value for array["+i+"]");
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<length-1; i++)
            {
                if(array[i] != array[i+1] - 1)
                {
                    Console.WriteLine("Here is the missing number in an Array : " + (array[i] + 1));

                }
                else
                {
                    //return;
                    Console.WriteLine();

                }
            }
            Console.ReadLine();
        }
    }
}
