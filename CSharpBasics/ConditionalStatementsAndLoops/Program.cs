using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    //if
    //if else
    //if else ladder
    //switch
    //go to lable
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for B");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Given Values are equal");
            }
            else
            {
                Console.WriteLine("Given Values are not equal");
            }


            //If-Else ladder and goto labale example;

            Console.WriteLine("Enter city to which you want to go?");
            string City = Console.ReadLine();
            if (City == "Hyderabad")
            {
                Console.WriteLine("Proceed to Route 1");
                goto Hyderabad;
            }
            else if (City == "Bangalore")
            {
                Console.WriteLine("Proceed to Route 2");
                goto Bangalore;
            }
            else if (City == "Chennai")
            {
                Console.WriteLine("Proceed to Route 3");
                goto Chennai;
            }
            else
            {
                Console.WriteLine("Your city not listed here.");
                goto Default;
            }

        Hyderabad:
            {
                Console.WriteLine(" Label Rout 1");
            }
        Bangalore:
            {
                Console.WriteLine("Label Rout 2");
            }
        Chennai:
            {
                Console.WriteLine(" Label Rout 3");
            }
        Default:
            {
                Console.WriteLine(" Label Rout is not listed");
            }

            //Switch Statement
            switch (City)
            {
                case "Hyderad":
                    {
                        Console.WriteLine("Proceed to Route 1");
                        break;
                    }
                case "Bangalore":
                    {
                        Console.WriteLine("Proceed to Route 2");
                        break;
                    }
                case "Chennai":
                    {
                        Console.WriteLine("Proceed to Route 3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Your city not listed here.");
                        break;
                    }
            }

            Console.ReadLine();

        }

    }
}
