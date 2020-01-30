using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region lesson_1
            //MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            //for (int c = 0; c < 5; c++) {
            //    intArray.SetItem(c, c  *  5);
            //}

            //for (int c = 0; c < 5; c++) {
            //    Console.Write(intArray.GetItem(c) + " ");
            //}

            //Console.WriteLine();

            //MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            //for (int c = 0; c < 5; c++)
            //{
            //    charArray.SetItem(c, (char)(c + 97));
            //}

            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(charArray.GetItem(c) + " ");
            //}
            #endregion

            #region lesson_2
            //MyGenericArray<int, char> intArray = new MyGenericArray<int, char>(5);
            //for (int c = 0; c < 5; c++)
            //{
            //    intArray.SetItem(c, c * 5);
            //}

            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(intArray.GetItem(c) + " ");
            //}

            //Console.WriteLine();
            //intArray.GenericMethod<string>("Hello Generic ");
            //intArray.GenericMethod<int>(100);

            //MyGenericArray<char,string> charArray = new MyGenericArray<char, string>(5);
            //for (int c = 0; c < 5; c++)
            //{
            //    charArray.SetItem(c, (char)(c + 97));
            //}

            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(charArray.GetItem(c) + " ");
            //}
            #endregion

            #region lesson_3
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            Console.WriteLine("a:{0},b:{1}", a, b);
            Console.WriteLine("c:{0},d:{1}", c, d);

            Swap<int>(ref a,ref b);
            Swap<char>(ref c, ref d);

            Console.WriteLine("a:{0},b:{1}", a, b);
            Console.WriteLine("c:{0},d:{1}", c, d);

            Console.ReadLine();
            #endregion
        }

        private static void Swap<T>(ref T lhs, ref T rhs) {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }

        public void GenericMethod<X>(X x) {
            Console.WriteLine(x.ToString());
        }
    }

    // class interface instance class
    public class MyGenericArray<T,K> where T:struct //T 必需為值類型
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }

        public void GenericMethod<X>(X x)
        {
            Console.WriteLine(x.ToString());
        }
    }

    //public class SubClass : MyGenericArray<int>{
    //}

    //public class SubGenericClass<T> : MyGenericArray<T> where T : struct {

    //}
}
