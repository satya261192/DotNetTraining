using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to get a Pattern ");
            int n = int.Parse(Console.ReadLine() + "");

            for(int i=1; i<=n; i++)
            {
                int j = i ;
                if(j % 5 != 0)
                {
                    if (j<10)
                    {
                        Console.Write("0"+i + " ");
                    }
                    else
                    { 
                    Console.Write(i +" ");
                    }
                }
                else
                {
                    if (j < 10)
                    {
                        Console.WriteLine("0" + j + " ");
                    }
                    else
                    {
                        Console.WriteLine(j + " ");
                    }
                }

            }



            //int n1, n2, n3;

            //n1 = 0;
            //n2 = 1;
            //n3 = n1 + n2;

            //Console.Write(n1 + " " + n2 + " " + n3 + " ");
            //for(int i=0; i<n-3; i++)
            //{
            //    n1 = n2;
            //    n2 = n3;
            //    n3 = n1 + n2;
            //    Console.Write(n3 + " ");
            //}



            Console.ReadLine();
        }
    }
}
