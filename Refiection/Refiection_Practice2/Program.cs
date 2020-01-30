using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Refiection_Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly objAssembly;
            objAssembly = Assembly.Load("mscorlib,2.0.0.0,Neutral,b77a5c561934e089");

            Type[] types = objAssembly.GetTypes();

            //foreach (var t in types) {
            //    Console.WriteLine(t.Name);
            //}

            objAssembly = Assembly.GetExecutingAssembly();
            Type t = objAssembly.GetType("Refiection_Practice2.Car",false,true);
            object obj = Activator.CreateInstance(t); //實例化 動態加載進來的 Class，因為不確定 Class 型別 所以用 object
            MethodInfo mi = t.GetMethod("IsMoving");
            var isMoving = (bool)mi.Invoke(obj,null);

            if (isMoving){
                Console.WriteLine("Is moving");
            }
            else {
                Console.WriteLine("Not is moving");
            }
            // System.Emit 動態創建一個 Class

            Console.ReadLine();
        }
    }

    public class Car
    {

        public bool IsMoving()
        {
            return true;
        }
    }
}
