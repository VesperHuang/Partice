using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public enum Grades { F = 0, D = 1, C = 2, B = 3, A = 4 }
    class Program
    {
        static void Main(string[] args)
        {
            //DemoLing
            //StringCount();
            var g1 = Grades.D;
            var g2 = Grades.F;
            var g3 = Grades.A;

            Console.WriteLine("Fist {0} a passing grade",g1.Passing() ? "is":"is not");
            Console.WriteLine("Second {0} a passing grade", g2.Passing() ? "is" : "is not");
            Console.WriteLine("Third {0} a passing grade", g3.Passing() ? "is" : "is not");

            Extesions.minPassing = Grades.C;

            Console.WriteLine("Fist {0} a passing grade", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade", g2.Passing() ? "is" : "is not");
            Console.WriteLine("Third {0} a passing grade", g3.Passing() ? "is" : "is not");

            Console.ReadLine();
        }

        private static void DemoLing() {
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g);

            foreach (var i in result)
            {
                Console.WriteLine("{0}", i);
            }
        }

        private static void StringCount() {

            string s = "This is vesper's C# tutorial!";
            int i = s.WordCount();
            Console.WriteLine("Word count of s is {0}", i);
        }
    }
    public static class StringExtension {
        public static int WordCount(this string str) {

            return str.Split(new char[] { ' ', '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class Extesions {

        public static Grades minPassing = Grades.D;
        public static bool Passing(this Grades grade) {
            return grade >= minPassing;
        }
    }
}
