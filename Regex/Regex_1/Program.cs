using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s1 = "abc123";
            //var pattern = "abc";
            //Console.WriteLine(Regex.IsMatch(s1,pattern));
            //Console.ReadLine();

            //RegIsMatch();
            //ReqMatch();
            //RegexReplace();
            //RegexSplit();
            //Match();
            Groups();

            Console.ReadLine();
        }

        private static void RegIsMatch()
        {
            string[] values = { "111-22-3333", "111-2-3333" };
            string pattern = @"^\d{3}-\d{2}-\d{4}";

            foreach (var value in values)
            {
                if (Regex.IsMatch(value, pattern))
                {
                    Console.WriteLine("{0} is vaild", value);
                }
                else
                {
                    Console.WriteLine("{0} is not vaild", value);
                }
            }
        }

        private static void ReqMatch() {

            var input = "This is jikexueyuan jikexueyuan";
            var pattern = @"\b(\w+)\W(\1)\b";
            Match match = Regex.Match(input, pattern);

            while (match.Success) {
                Console.WriteLine("Duplication {0} found",match.Groups[1]);

                match = match.NextMatch();
            }

        }

        private static void RegexReplace() {

            string pattern = @"\b\d+\.\d{2}\b";
            string replacement = "$$$&";
            string input = "Total cost:103.64";

            Console.WriteLine(Regex.Replace(input,pattern,replacement));
        }

        private static void RegexSplit() {
            string input = "1. Egg 2. Bread 3. Mike 4. Coffee";
            string pattern = @"\b\d{1,2}\.\s";

            foreach (string item in Regex.Split(input, pattern)) {

                if (!string.IsNullOrEmpty(item)) {
                    Console.WriteLine(item);
                }
            }
        }

        private static void Match() {

            MatchCollection matches;

            Regex r = new Regex("abc");
            matches = r.Matches("123abcd4abc");
            foreach (Match match in matches) {
                Console.WriteLine("{0} found at position {1}",match.Value,match.Index);

                Console.WriteLine("{0}", match.Result("$&,hello vesper")); //$& 前面匹配的結果
            }
        }

        private static void Groups() {
            string input = "Born: July 28, 1989";
            string pattern = @"\b(\w+)\s(\d{1,2}),\s(\d{4})\b";

            Match match = Regex.Match(input,pattern);
            if (match.Success) {
                for (int ctr = 0; ctr < match.Groups.Count; ctr++) {
                    Console.WriteLine("Group {0}:{1}",ctr,match.Groups[ctr].Value);
                }
            }
        }

    }
}
