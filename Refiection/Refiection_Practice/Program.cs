using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Refiection_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Type 常用屬性 FullName NameSpace BaseType IsXXXX GetMethod
            string s = "Hello Reflection";
            Type t = s.GetType();
            Console.WriteLine(t.FullName);

            Type t2 = Type.GetType("System.string",false,true); 
            Console.WriteLine(t2.FullName);

            Type t3 = typeof(string);
            Console.WriteLine(t3.FullName);

            //GetMethods(t);
            //Console.WriteLine("Join method:{0}",t.GetMethod("Copy"));
            GetMethods(t, BindingFlags.Public | BindingFlags.Instance);

            Console.ReadLine();
        }

        public static void GetMethods(Type t,BindingFlags f) {
            MethodInfo[] mi = t.GetMethods(f);

            foreach (MethodInfo m in mi) {
                Console.WriteLine("{0}",m.Name);
            }
        }
    }
}
