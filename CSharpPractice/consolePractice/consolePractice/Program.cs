using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1st value to check");

            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd value to check");

            int value2 = int.Parse(Console.ReadLine());

            int add = value1 + value2;
            int sub = value1 - value2;
            int mul = value1 * value2;
            int div = value1 / value2;

            //Console.WriteLine("Addition = " +  add);
            //Console.WriteLine("Subtraction = " + sub);
            //Console.WriteLine("Multiplication = " + mul);
            //Console.WriteLine("Division = " + div);


            if (add % 2 ==0)
            {
                Console.WriteLine(add + "Addition value is Even");
            }
           else
            {
                Console.WriteLine( add + "Addition value is Odd");
            }

            if (sub % 2 == 0)
            {
                Console.WriteLine(sub + "Subtraction value is Even");
            }
            else
            {
                Console.WriteLine(sub + "Subtraction value is Odd");
            }
            if (mul % 2 == 0)
            {
                Console.WriteLine(mul + "Multiplication value is Even");
            }
            else
            {
                Console.WriteLine(mul + "Multiplication value is Odd");
            }
            if (div % 2 == 0)
            {
                Console.WriteLine(div + "Division value is Even");
            }
            else
            {
                Console.WriteLine(div +  "Division value is Odd");
            }



            //  if (value % 2 == 0) {
            //      Console.WriteLine("Given Number is even");
            //  }
            // else
            //  {
            //      Console.WriteLine("Given Number is odd");
            //  }


            int a;
            int b;
            int c;

            Console.WriteLine("Enter value for a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enjkdn");
            b = int.Parse(Console.ReadLine());

            c = a + b;

            Console.WriteLine("a+b = " + c);

            Console.ReadLine();
        }
    }
}
