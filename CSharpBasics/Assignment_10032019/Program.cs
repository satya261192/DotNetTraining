using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10032019
{
    class Program
    {

        //1
        //1 2
        //1 2 3
        //1 2 3 4
        //1 2 3 4 5


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print pattern");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((j + 1) + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
