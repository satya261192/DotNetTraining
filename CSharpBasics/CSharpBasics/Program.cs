using System;
using System.IO;

namespace CSharpBasics
{
    class Program
    {
        private static int _myProperty;
        public static int MyProperty {
            get {
                return _myProperty;
            }
            set {
                _myProperty = value;
            } }
        static void Main(string[] args)
        {
            // Variable names can not start with number or special characters other than _
            // name can contain letters and numbers
            // name should start with letter
            // naming can follow either PASCAL or CAMEL case according to project guidelines.
            MyProperty = 20;
            Console.WriteLine(MyProperty);
            int a;
            int b;
            int c;
            Console.WriteLine("Enter value for A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for B:");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("a + b = " + c);
            c = a - b;
            Console.WriteLine("a - b = " + c);
            Console.ReadLine();
        }
        // Numbers:: uint, int, long, int16, int32, int64
        // Decimal: decimal, float
        // String:  "<value>"
        // Char
        // Bool:  bool (true/false)
        // Nullable Types  for all premitive data types
    }
}

