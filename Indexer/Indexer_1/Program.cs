using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new IndexerNames();
            names[0] = "C#";
            names[1] = "VB";
            names[2] = "VB.NET";
            names[3] = "JAVA";
            names[4] = "Python";
            names[5] = "Javascript";
            names[6] = "TypeScript";
            names[7] = "Ruby";
            names[8] = "C++";
            names[9] = "Cobal";

            for (int i=0; i <= 9; i++) {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(names["C#"]);
            Console.WriteLine(names["JAVA"]);
            Console.WriteLine(names["ES2015"]);

            Console.ReadLine();
        }
    }

    class IndexerNames {
        private string[] nameList = new string[10];

        public IndexerNames() {

            for (int i = 0; i < nameList.Length; i++) {
                nameList[i] = "N/A";
            }
        }

        public string this[int index] {
            get {
                string temp;
                if (index >= 0 && index <= nameList.Length - 1) {
                    temp = nameList[index];
                }
                else {
                    temp = "";
                }
                return temp;
            }

            set {
                if (index >= 0 && index <= nameList.Length - 1) {
                    nameList[index] = value;
                }
            }
        }

        public int this[string name] {

            get {
                int index = 0;
                while (index < nameList.Length) {
                    if (nameList[index] == name) {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
    }

    public interface ISomeInterface {
        int this[int index] {
            get;
            set;
        }
    }

     class IndexerClass : ISomeInterface {

        private int[] arr = new int[100];

        public int this[int index] {
            get {
                return arr[index];
            }
            set {
                arr[index] = value;
            }
        }
    }
}
