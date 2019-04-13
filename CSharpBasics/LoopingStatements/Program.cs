using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingStatements
{
    // for loop
    // while loop
    // do while loop
    // foreacch
    class Program
    {
        static void Main(string[] args)
        {
            //for (< iterator >;< condition >;< increment >)
            //{
            //    // Statement block
            //}
            for (int i = 0; i < 10; i++)
            {
                if ((i + 1) == 5)
                {
                    break;
                }
                Console.WriteLine(i+1);
                //for (int j = 0; j < 10; j++)
                //{
                //    Console.WriteLine("[" + i + "][" + j + "]");
                //}
            }


            //while (<condition>)
            // {
            //  Statement Block
            // }
            string choice = "no";
            int k = 0;
            while (choice == "continue")
            {
                Console.WriteLine("you continued while loop for " + (++k) + " number of times.");
                Console.WriteLine("do you want to continue?");
                choice = Console.ReadLine();
            }

            string userChoice;
            do
            {
                Console.WriteLine("you continued do-while loop for " + (++k) + " number of times.");
                Console.WriteLine("do you want to continue?");
                userChoice = Console.ReadLine();
            } while (userChoice == "continue");

            //do
            // {
            //  Statement Block
            // } while (<condition>);

            Console.ReadLine();
        }
    }
}
