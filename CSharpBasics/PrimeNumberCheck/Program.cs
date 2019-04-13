using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check whether it's Prime Number or Not");

            int n = int.Parse(Console.ReadLine());

            int fctr = 0;
            DateTime dt = DateTime.Now;

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    fctr++;
                    break;
                }
            }
            if (fctr == 0)
            {
                Console.WriteLine(n + " - is Prime number");
            }
            else
            {
                Console.WriteLine(n + " - is NOT a Prime number");
            }
            TimeSpan ts = DateTime.Now - dt;
            Console.WriteLine(" Time to execute the operation: " + ts.Milliseconds);
            Console.ReadLine();
        }
    }
}
