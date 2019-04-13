using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
  
            string choice = "yes";

            while(choice == "yes")
            {
                Console.WriteLine("Enter number to build Pyramid");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine("");
                }


                Console.WriteLine("Do you want to get an other Pattern");
                choice = Console.ReadLine();
            }


            //for (int i = 0; i < n; i++)
            //{

            //    for (int j = n; j > i; j--)
            //    {

            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int k = 1; k < i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine("");
            //}


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int k = 1; k < i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= n - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int k = 0; k < n-i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine("");
            //}

            Console.ReadLine();
        }

    }

}

//static void Main(string[] args)
//{
//    Console.WriteLine("Enter a number to print pattern");
//    int n = int.Parse(Console.ReadLine());

//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j <= i; j++)
//        {
//            Console.Write((j + 1) + " ");
//        }
//        Console.WriteLine();
//    }

//    Console.ReadLine();
//}
