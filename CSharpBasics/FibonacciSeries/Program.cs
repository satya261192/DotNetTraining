using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 1 1 2 3 5 8 13 21 34 55
            Console.WriteLine("Eneter a number to get a fibonacci series");
            int n = int.Parse(Console.ReadLine());
            int prv, prsnt, nxt;
            prv = 0;
            prsnt = 1;

            for(int i=0; i<=n; i++)
            {
                nxt = prv + prsnt;

                prv = prsnt;
                prsnt = nxt;

                Console.Write(nxt + " ");
            }

            Console.ReadLine();
        }
    }
}
