using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 1;
            a[4] = 5;
            int[] b = new int[3] {1,2,3 };
            int[] c = new int[] { 1, 2, 3, 4, 5 };
            int[] d = { 2, 3, 4, 5, 6 };

            Console.WriteLine("Enter length of array");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter value for array["+i+"]");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++) {
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
            //string[] name = new string[] { "satya" };
            Console.ReadLine();
        }
    }
}
