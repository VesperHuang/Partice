//#define DEBUG
using System;
using System.Diagnostics;

namespace Attribute_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Message("In Main function");
            Function1();
            Console.ReadLine();
        }

        [Obsolete("Don't use old Method")]
        static void Function1() {
            MyClass.Message("In Function1");
            Function2();
        }

        static void Function2() {
            MyClass.Message("In Function2");
        }
    }

    public class MyClass {

        [Conditional("DEBUG")]
        public static void Message(string msg) {
            Console.WriteLine(msg);
        }
    }
}
