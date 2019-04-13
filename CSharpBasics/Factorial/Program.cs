using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print factorial");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1; ;
            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}
