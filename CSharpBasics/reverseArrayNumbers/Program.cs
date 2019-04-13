using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter the value for array["+i+"] ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("array["+i+"] = " + array[(length-1)-i]);
            }

            Console.ReadLine();
        }
    }
}
