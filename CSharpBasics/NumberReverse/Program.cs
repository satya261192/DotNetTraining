using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "yes";
            while (choice == "yes")
            {
                Console.WriteLine("Enter a number to reverse it:");
                int n = int.Parse(Console.ReadLine());
                int result = 0;
                while(n>0)
                {
                    int reminder = n % 10;
                    result = (result * 10) + reminder;
                    n = n / 10;
                }
                Console.WriteLine("Result : " + result);

                Console.WriteLine(" ");
                Console.WriteLine("Type 'yes' to try for other number -->");
                choice = Console.ReadLine();
            }

            //Console.ReadLine();
        }
  
    }
}
