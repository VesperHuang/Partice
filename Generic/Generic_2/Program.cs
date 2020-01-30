using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_2
{
    delegate T NumberCharger<T>(T n);
    class Program
    {
        static int num = 10;

        public static int AddNum(int p) {
            num += p;
            return num;
        }

        public static int MultNum(int p) {
            num *= p;
            return num;
        }

        static void Main(string[] args)
        {
            NumberCharger<int> nc1 = new NumberCharger<int>(AddNum);
            NumberCharger<int> nc2 = new NumberCharger<int>(MultNum);

            nc1(25);
            Console.WriteLine(num);
            nc2(5);
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
