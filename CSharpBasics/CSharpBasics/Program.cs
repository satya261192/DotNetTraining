using System;
using System.IO;

namespace CSharpBasics
{
    class Program
    {
        private static int _myProperty;
        public static int MyProperty
        {
            get
            {
                return _myProperty;
            }
            set
            {
                _myProperty = value;
            }
        }
        static void Main(string[] args)
        {
            // Variable names can not start with number or special characters other than _
            // name can contain letters and numbers
            // name should start with letter
            // naming can follow either PASCAL or CAMEL case according to project guidelines.
            //MyProperty = 20;
            //Console.WriteLine(MyProperty);
            //int a;
            //int b;
            //int c;
            //Console.WriteLine("Enter value for A:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter value for B:");
            //b = int.Parse(Console.ReadLine());
            //c = a + b;
            //Console.WriteLine("a + b = " + c);
            //c = a - b;
            //Console.WriteLine("a - b = " + c);

            //ExecuteOperators();
            //CoalesceOperator();
            //Console.WriteLine("Inline true");
            //InlineCondition(true);
            //Console.WriteLine("Inline false");
            //InlineCondition(false);


            Console.WriteLine("Enter Value to Verify");
            int value = int.Parse(Console.ReadLine());
            //CheckEvenOrOd(val);
            if (value % 2 == 0)
            {
                Console.WriteLine("Given Number is even");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }

            Console.ReadLine();
        }
        static void CheckEvenOrOd(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine("Given Number is even");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }
        }

        static void CoalesceOperator()
        {
            int? x = 5;
            int? y = 10;

            Console.WriteLine(x ?? y);
        }

        static void InlineCondition(bool cond)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine(cond ? x : y);
        }

        static void ExecuteOperators()
        {
            //primary Operators 
            int x = 1;
            Console.WriteLine("Post Increament (x++) operator explanation ");
            Console.WriteLine("x = " + x);
            Console.WriteLine("x = " + (x++));
            Console.WriteLine("x = " + x);
            x = 1;
            Console.WriteLine("Pre Increament (++x) operator explanation ");
            Console.WriteLine("x = " + x);
            Console.WriteLine("x = " + (++x));
            Console.WriteLine("x = " + x);
        }
        // Numbers:: uint, int, long, int16, int32, int64
        // Decimal: decimal, float
        // String:  "<value>"
        // Char
        // Bool:  bool (true/false)
        // Nullable Types  for all premitive data types
    }
}

